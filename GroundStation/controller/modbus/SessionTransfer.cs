using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using log4net;
using controller;
using GroundStation.view;
using GroundStation.model.entity.telerik;
namespace controller
{
    class SessionTransfer
    {
        private bool isRecordTelemetry = false;
        public static readonly ILog log = LogManager.GetLogger(typeof(mainForm));
        public controller.Modbus modbus = new controller.Modbus(ConnectionInterface.getSerialPortObject("SerialPort.config"));
        CommandLine commandLine = new CommandLine();
        ParametersManager parametersManager = new ParametersManager();
        SessionOperationListManager sessionOperationManager = new SessionOperationListManager();
        DevicesManager deviceManager = new DevicesManager();
        ModBusTypesManager mt = new ModBusTypesManager();
        TelemetryDataManager telemetryDataManager = new TelemetryDataManager();

        int nextRow = 1;

        public SessionTransfer(bool isRecordTelemetry)
        {
            this.isRecordTelemetry = isRecordTelemetry;
        }
        public int transferSessionNotArragment(C1.Win.C1FlexGrid.C1FlexGrid g)
        {
            int sessionCount = g.Rows.Count;

            //g.FirstDisplayedScrollingRowIndex = nextRow;
            int idParam = Convert.ToInt16(g[nextRow, "id"]);
            Session_operation_list so = sessionOperationManager.getSessionOperationById(idParam);
            Parameter p = parametersManager.getParameter(so.Parameter_id);
            Device d = deviceManager.getDivice(p.Device_id);

            g.Select(nextRow, 0);
            string transactionInfo = "System name: " + d.Name + " operation: " + so.Type + " value: " + so.Value + " register adr: " + p.Register_address_start + " register type: " + p.Modbus_type_id;
            log.Debug(transactionInfo);
            int nextRowByCMD = -1;
            try
            {
                if ((ModBusFunc)so.Type == ModBusFunc.READ_HOLDING_REGISTER)
                {
                    g[nextRow, "value"] = modbus.transferProcessing((byte)d.Modbus_address, ModBusFunc.READ_HOLDING_REGISTER, (ushort)p.Register_address_start, (ushort)1, assembleParamForWrite(so.Value, 1))[0];
                }
                else
                {
                    modbus.transferProcessing((byte)d.Modbus_address, ModBusFunc.WRITE_HOLDING_REGISTER, (ushort)p.Register_address_start, (ushort)1, assembleParamForWrite(so.Value, 1));
                }

                // Перевірка строки керування
                if (so.Command_control_type != 0)
                {
                    long? nextRowPriority = commandLine.analysis(so, Convert.ToDouble(g[nextRow, "value"]));
                    for (int i = 1; i < g.Rows.Count; i++)
                    {
                        if (Convert.ToInt16(g[i, "priority"]) == nextRowPriority) { nextRowByCMD = i; break; }
                    }
                }
            }
            catch (Exception ex)
            {
                if ((new QuestionFrm(transactionInfo, ex.Message, 7)).DialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    nextRow--;
                }
                else
                {
                    g[nextRow, "value"] = "ERROR";
                }
            }

            if (nextRowByCMD >= 0)
            {
                nextRow = nextRowByCMD;
            }
            else
            {
                nextRow++;
            }

            return nextRow;
        }

        public int transferSessionArragment(DataGridView g, List<List<V_session_operation_list_arragment>> a)
        {
            int sessionCount = g.RowCount;

            g.FirstDisplayedScrollingRowIndex = nextRow;
            int idParam = Convert.ToInt16(g[0, nextRow].Value);
            int nowGroup = Convert.ToInt16(g.Rows[nextRow].HeaderCell.Value);
            
            Telemetry_data_arragment telemetryObject = new Telemetry_data_arragment();

            telemetryObject.Operation_group_id = a[nowGroup][0].Operation_group_id;
            telemetryObject.Operation_group_id = nowGroup;
            telemetryObject.Date = DateTime.Now;

            int tmp = nextRow;
            //Select rows can optimize..
            foreach (DataGridViewRow r in g.Rows)
            {
                if (r.HeaderCell.Value.Equals(g.Rows[tmp].HeaderCell.Value))
                {
                    r.Selected = true;
                    nextRow++;
                }
                else
                    r.Selected = false;
            }
            nextRow--;


            long? startAdr = a[nowGroup][0].Register_address_start;
            long? countReg = a[nowGroup][0].Modbus_register_count;
            long? modbusAdr = a[nowGroup][0].Modbus_address;
            int readWrite = a[nowGroup][0].Type.Equals("WRITE") ? 1 : 0;

            if (a[nowGroup].Count > 0)
            {
                for (int i = 1; i < a[nowGroup].Count; i++)
                {
                    countReg += a[nowGroup][i].Modbus_register_count;
                }
            }

            string transactionInfo = "Next reading: System adr: " + modbusAdr + " start adr: " + startAdr + " count reg: " + countReg;
            log.Debug(transactionInfo);
            int nextRowGroupByCMD = -1;
            try
            {
                ushort[] reciveArray = { };
                if ((ModBusFunc)readWrite == ModBusFunc.READ_HOLDING_REGISTER)
                {
                    reciveArray = modbus.transferProcessing((byte)modbusAdr, ModBusFunc.READ_HOLDING_REGISTER, (ushort)startAdr, (ushort)countReg, null);
                    telemetryObject.Data = ushortATobyteA(reciveArray);

                    if (isRecordTelemetry) telemetryDataManager.addTelemetryData(telemetryObject);

                    int index = 0;
                    short? offset = 0;
                    // Розкладуємо прийняті значення в грід
                    foreach (DataGridViewRow r in g.Rows)
                    {
                        if (r.HeaderCell.Value.Equals(g.Rows[tmp].HeaderCell.Value))
                        {
                            r.Cells["value"].Value = assembleParam(reciveArray, offset, a[nowGroup][index].Modbus_register_count);
                            r.Cells["alias"].Value = assembleParam(reciveArray, offset, a[nowGroup][index].Modbus_register_count);
                            offset += a[nowGroup][index].Modbus_register_count;
                            index++;
                        }
                    }
                }
                else
                {
                    modbus.transferProcessing((byte)modbusAdr, ModBusFunc.WRITE_HOLDING_REGISTER, (ushort)startAdr, (ushort)countReg, assembleParamForWrite(a[nowGroup]));
                }


                // Перевірка строки керування
                if (a[nowGroup].Count == 1 && a[nowGroup][0].Command_control_type != 0)
                {
                    long? nextRowPriority = commandLine.analysis(a[nowGroup][0], Convert.ToDouble(g["value", nextRow].Value));
                    if (nextRowPriority >= 0)
                        foreach (DataGridViewRow r in g.Rows)
                            if (Convert.ToInt16(r.Cells["priority"].Value) == nextRowPriority) { nextRowGroupByCMD = Convert.ToInt16(r.HeaderCell.Value); break; }
                }
            }
            catch (Exception ex)
            {
                if ((new QuestionFrm(transactionInfo, ex.Message, 7)).DialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    nextRow--;
                }
                else
                {
                    foreach (DataGridViewRow r in g.Rows)
                    {
                        if (r.HeaderCell.Value.Equals(g.Rows[tmp].HeaderCell.Value)) r.Cells["value"].Value = "ERROR";
                        telemetryObject.Data = null;
                        if (isRecordTelemetry) telemetryDataManager.addTelemetryData(telemetryObject);
                    }
                }
            }

            if (nextRowGroupByCMD >= 0)
            {
                int rowGroup;
                foreach (DataGridViewRow r in g.Rows)
                {
                    rowGroup = Convert.ToInt16(r.HeaderCell.Value);
                    if (rowGroup.Equals(nextRowGroupByCMD)) { nextRow = r.Index; break; }
                }
            }
            else
            {
                nextRow++;
            }

            return nextRow;
        }
        
        List<Alias_group> aliasGroupList = (new AliasManager()).getAliasGroupList();
       
        private String getAliasName(long? groupId, Object value)
        {
            foreach (Alias_group ag in aliasGroupList)
            {
                if (ag.Id.Equals(groupId)) 
                {
                    foreach (Value_alia va in ag.Value_alias)
                    {
                        if (va.Value.Equals(Convert.ToDouble(value))) return va.Alias_text;
                    }
                }
            }
            return "NO ALIAS FOR VALUE";
        }
        public int transferSessionArragment(C1.Win.C1FlexGrid.C1FlexGrid g, List<List<V_session_operation_list_arragment>> a)
        {
            int sessionCount = g.Rows.Count;

            int idParam = Convert.ToInt16(g[nextRow, "id"]);
            int nowGroup = Convert.ToInt16(g[nextRow, "group_id"]);

            Telemetry_data_arragment telemetryObject = new Telemetry_data_arragment();

            telemetryObject.Operation_group_id = a[nowGroup][0].Operation_group_id;
            telemetryObject.Operation_group_id = nowGroup;
            telemetryObject.Date = DateTime.Now;

            int tmp = nextRow;

            //Select rows can optimize..
            for (int i = 1; i < g.Rows.Count; i++)
            {
                if (g[i, "group_id"].Equals(g[tmp, "group_id"]))
                {
                    g.Rows[i].Selected = true;
                    nextRow++;
                }
                else
                    g.Rows[i].Selected = false;
            }

            nextRow--;


            long? startAdr = a[nowGroup][0].Register_address_start;
            long? countReg = a[nowGroup][0].Modbus_register_count;
            long? modbusAdr = a[nowGroup][0].Modbus_address;
            int readWrite = a[nowGroup][0].Type.Equals("WRITE") ? 1 : 0;

            if (a[nowGroup].Count > 0)
            {
                for (int i = 1; i < a[nowGroup].Count; i++)
                {
                    countReg += a[nowGroup][i].Modbus_register_count;
                }
            }

            string transactionInfo = "Next reading: System adr: " + modbusAdr + " start adr: " + startAdr + " count reg: " + countReg;
            log.Debug(transactionInfo);
            int nextRowGroupByCMD = -1;
            try
            {
                ushort[] reciveArray = { };
                if ((ModBusFunc)readWrite == ModBusFunc.READ_HOLDING_REGISTER)
                {
                    reciveArray = modbus.transferProcessing((byte)modbusAdr, ModBusFunc.READ_HOLDING_REGISTER, (ushort)startAdr, (ushort)countReg, null);
                    telemetryObject.Data = ushortATobyteA(reciveArray);

                    if (isRecordTelemetry) telemetryDataManager.addTelemetryData(telemetryObject);

                    int index = 0;
                    short? offset = 0;
                    // Розкладуємо прийняті значення в грід
                    for (int i = 1; i < g.Rows.Count; i++)
                    {
                        if (g[i, "group_id"].Equals(g[tmp, "group_id"]))
                        {
                            Object readValue = assembleParam(reciveArray, offset, a[nowGroup][index].Modbus_register_count);
                            g[i, "value"] = readValue;

                            if (a[nowGroup][index].Alias_group_id != 0)
                            {
                                g[i, "alias"] = getAliasName(a[nowGroup][index].Alias_group_id, readValue);                                                                
                            }                                

                            offset += a[nowGroup][index].Modbus_register_count;
                            index++;
                        }
                    }
                }
                else
                {
                    modbus.transferProcessing((byte)modbusAdr, ModBusFunc.WRITE_HOLDING_REGISTER, (ushort)startAdr, (ushort)countReg, assembleParamForWrite(a[nowGroup]));
                }


                // Перевірка строки керування
                if (a[nowGroup].Count == 1 && a[nowGroup][0].Command_control_type != 0)
                {
                    long? nextRowPriority = commandLine.analysis(a[nowGroup][0], Convert.ToDouble(g[nextRow, "value"]));
                    if (nextRowPriority >= 0)
                    {
                        for (int i = 1; i < g.Rows.Count; i++)
                        {
                            if (Convert.ToInt16(g[i, "priority"]) == nextRowPriority) { nextRowGroupByCMD = Convert.ToInt16(g[i, "group_id"]); break; }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if ((new QuestionFrm(transactionInfo, ex.Message, 7)).DialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    nextRow--;
                }
                else
                {
                    for (int i = 1; i < g.Rows.Count; i++)
                    {
                        if ((g[i, "group_id"].Equals(g[tmp, "group_id"]))) g[i, "value"] = "ERROR";
                        telemetryObject.Data = null;
                        if (isRecordTelemetry) telemetryDataManager.addTelemetryData(telemetryObject);
                    }
                }
            }

            if (nextRowGroupByCMD >= 0)
            {
                int rowGroup;
                for (int i = 1; i < g.Rows.Count; i++)
                {
                    rowGroup = Convert.ToInt16(g[i, "group_id"]);
                    if (rowGroup.Equals(nextRowGroupByCMD)) { nextRow = i; break; }
                }
            }
            else
            {
                nextRow++;
            }

            return nextRow;
        }

        private String assembleParam(ushort[] recive, short? offset, short? countReg)
        {
            String result = "";
            for (int i = 0; i < countReg; i++)
            {
                result += " " + recive[i + (short)offset].ToString();
            }
            return result;
        }

        private ushort[] assembleParamForWrite(long? value, short? countReg)
        {
            ushort[] result = { (ushort)value };
            return result;

            //Object _this = assembleParam(p.parameterParts);
            //if (p.return_type.ToLower().Equals("float")) return (float)(_this);
            //if (p.return_type.ToLower().Equals("double")) return (double)(_this);
            //if (p.return_type.ToLower().Equals("uint16")) return (UInt16)(_this);
            //if (p.return_type.ToLower().Equals("uint32")) return (UInt32)(_this);
            //if (p.return_type.ToLower().Equals("int16")) return (Int16)(_this);
            //if (p.return_type.ToLower().Equals("int32")) return (Int32)(_this);
        }

        private ushort[] assembleParamForWrite(List<V_session_operation_list_arragment> group)
        {
            List<ushort> arr = new List<ushort>();

            foreach (V_session_operation_list_arragment item in group)
            {
                arr.AddRange(assembleParamForWrite(item.Value, item.Modbus_register_count));
            }

            return arr.ToArray();
        }

        private Object assembleParamInType(ushort[] recive, int offset, int countReg)
        {
            switch (countReg)
            {
                case 1: return (UInt16)recive[offset];
                case 2: return (UInt32)((UInt32)recive[offset] << 16 | (UInt16)recive[1 + offset]);
                default: throw new Exception("Error number of registers: " + countReg);
            }
        }

        public Byte[] ushortATobyteA(ushort[] array)
        {
            int k = 0;
            Byte[] a = new Byte[array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                a[k] = (Byte)array[i];
                a[k + 1] = (Byte)(array[i] >> 8);
                k += 2;
            }
            return a;
        }

        public ushort[] byteAToUshortA(Byte[] bytes)
        {
            //BitConverter.ToInt16(new byte[] { 1, 2 }, 0);
            int k = 0;
            ushort[] a = new ushort[bytes.Length / 2];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = (ushort)(((ushort)bytes[k + 1] << 8) | bytes[k]);
                k += 2;
            }

            return a;
        }
    }
}
