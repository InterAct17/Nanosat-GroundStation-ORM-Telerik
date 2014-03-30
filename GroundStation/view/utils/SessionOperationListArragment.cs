using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using controller;
using log4net;
using C1.Win.C1FlexGrid;
using GroundStation.model.entity.telerik;



namespace GroundStation.view
{
    /// <summary>
    /// Клас компоновки параметрів
    /// </summary>
    public class SessionOperationListArragment
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(SessionOperationListArragment));

        List<V_session_operation_list_arragment> vsol = null;

        //List<VSessionOperationArragment> sola = new List<VSessionOperationArragment>();
        List<V_session_operation_list_arragment> solaTemp = new List<V_session_operation_list_arragment>();

        List<List<V_session_operation_list_arragment>> finish = new List<List<V_session_operation_list_arragment>>();


        ParametersManager paramManager = new ParametersManager();
        DevicesManager devicesManager = new DevicesManager();


        public SessionOperationListArragment(List<V_session_operation_list_arragment> vsol)
        {
            log.Debug("Початок компоновки сеансу зв'язку...");
            this.vsol = vsol;
            proccess_stage1();

            proccess_stage2();
            log.Debug("Компоновки сеансу зв'язку закінчена...");
            log.Info(getExchangeTime());
        }

        public List<List<V_session_operation_list_arragment>> getSessionOperationListArragment()
        {
            return finish;
        }

        private void proccess_stage1()
        {
            try
            {
                foreach (V_session_operation_list_arragment vso in vsol)
                {
                    if ((CommandControlType)vso.Command_control_type == CommandControlType.NONE && vso.Is_not_arragment == false) // Наступний елемент без строки керування
                    {
                        if (solaTemp.Count == 0)
                        {
                            log.Debug("Пріорітет першого елемент: " + vso.Priority);
                            solaTemp.Add(vso);
                        }
                        else if (solaTemp[0].Type.Equals(vso.Type) && solaTemp[0].Modbus_address.Equals(vso.Modbus_address))
                        {
                            log.Debug("Пріорітет нового елементу задовільняючого умову: " + vso.Priority);
                            solaTemp.Add(vso);
                        }
                        else
                        { // Інший тип доступу або інша система                             
                            solaTempProccess();

                            log.Debug("Інший тип доступу або інша система пріорітет: " + vso.Priority);
                            log.Debug("Пріорітет першого елемент: " + vso.Priority);
                            solaTemp.Add(vso); // Нова строка                            
                        }
                    }
                    else //if (solaTemp.Count != 0)
                    {
                        log.Debug("Пріорітет команди: " + vso.Priority);
                        if (solaTemp.Count != 0) solaTempProccess();
                        solaTemp.Add(vso); //"Строка рерування: "
                        finish.Add(solaTemp.ToList());
                        solaTemp.Clear();
                    }
                }

                if (solaTemp.Count != 0) solaTempProccess();
            }
            catch (Exception ex)
            {
                log.Error("private void proccess()" + ex.Message, ex);
            }
        }

        private void solaTempProccess()
        {
            List<V_session_operation_list_arragment> solaTempSort = new List<V_session_operation_list_arragment>();
            try
            {
                log.Debug(">>Початок аналізу тимчасового масиву: ");
                solaTempSort = solaTemp.OrderBy(register_address_start => register_address_start.Register_address_start).ToList();
                solaTemp.Clear();

                V_session_operation_list_arragment lastOperation = solaTempSort[0];
                solaTemp.Add(lastOperation);
                if (solaTempSort.Count > 1)
                {
                    for (int i = 1; i < solaTempSort.Count; i++)
                    {
                        if (((lastOperation.Register_address_start + lastOperation.Modbus_register_count) == solaTempSort[i].Register_address_start))
                        {
                            solaTemp.Add(solaTempSort[i]);
                        }
                        else
                        {
                            finish.Add(solaTemp.ToList());
                            solaTemp.Clear();
                            solaTemp.Add(solaTempSort[i]);
                        }

                        if (i == solaTempSort.Count - 1)
                        {
                            finish.Add(solaTemp.ToList());
                            solaTemp.Clear();
                        }

                        lastOperation = solaTempSort[i];
                    }
                }
                else
                {
                    finish.Add(solaTemp.ToList());
                    solaTemp.Clear();
                }

                log.Debug(">>Кінець аналізу тимчасового масиву: ");
            }
            catch (Exception ex)
            {
                log.Error("private void solaTempProccess()" + ex.Message, ex);
            }

        }
        [Obsolete]
        public void fillSessionOperationGrid(DataGridView g)
        {
            try
            {
                g.Rows.Clear();
                g.Columns.Clear();

                g.Columns.Add("id", "Ідентифікатор");
                g.Columns["id"].Visible = false;

                g.Columns.Add("priority", "Пріорітет");
                g.Columns.Add("command_control_type", "Строка керування");
                g.Columns.Add("is_not_arragment", "Не компонувати");
                g.Columns.Add("device_name", "(Адр.) Пристрій");
                g.Columns.Add("parameter_name", "(Адр.) Параметер");
                g.Columns.Add("type", "Операція");
                g.Columns.Add("value", "Значення");

                for (int i = 0; i < finish.Count; i++)
                {
                    g.RowCount += finish[i].Count;
                }

                g.RowHeadersVisible = true;
                g.RowHeadersWidth = 70;

                int rowCount = 0;
                for (int i = 0; i < finish.Count; i++)
                {
                    for (int j = 0; j < finish[i].Count; j++)
                    {
                        //g.Rows[i].HeaderCell.Value = sos[i].id.ToString();
                        g["id", rowCount].Value = finish[i][j].Session_operation_list_id;
                        g["priority", rowCount].Value = finish[i][j].Priority;
                        g["command_control_type", rowCount].Value = (CommandControlType)finish[i][j].Command_control_type;
                        g["is_not_arragment", rowCount].Value = finish[i][j].Is_not_arragment;
                        g["device_name", rowCount].Value = finish[i][j].Device_name;
                        g["parameter_name", rowCount].Value = finish[i][j].Parameter_name;
                        g["type", rowCount].Value = finish[i][j].Type;
                        g["value", rowCount].Value = finish[i][j].Value;
                        rowCount++;
                    }

                }
                sessionGrid_Paint(g);
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }

        private void sessionGrid_Paint(DataGridView g)
        {
            List<Color> lc = new List<Color>() { Color.DarkGray, Color.DarkGreen, Color.Yellow, Color.Gold, Color.Purple };
            List<String> devNames = new List<String>();

            foreach (DataGridViewRow row in g.Rows)
            {
                String devName = row.Cells["device_name"].Value.ToString();
                row.Cells["device_name"].Style.BackColor = Color.FromArgb((new Random(devName[0].GetHashCode()).Next(150, 255)), (new Random(devName[1].GetHashCode()).Next(180, 255)), (new Random(devName.GetHashCode()).Next(100, 255)));

                if (row.Cells["type"].Value.ToString() == "WRITE")
                {
                    row.Cells["type"].Style.ForeColor = Color.Red;
                }
                else if (row.Cells["type"].Value.ToString() == "READ")
                {
                    row.Cells["type"].Style.ForeColor = Color.Blue;
                    row.Cells["value"].Style.ForeColor = Color.DarkGray;
                }

                if ((CommandControlType)row.Cells["command_control_type"].Value != CommandControlType.NONE)
                {
                    row.Cells["command_control_type"].Style.ForeColor = Color.DarkGreen;
                    row.Cells["command_control_type"].Style.BackColor = Color.LightBlue;
                }

                if ((Boolean)row.Cells["is_not_arragment"].Value)
                {
                    row.Cells["is_not_arragment"].Style.BackColor = Color.LightCoral;
                }
            }
            g.EnableHeadersVisualStyles = false;
            int rowCount = 0;
            for (int i = 0; i < finish.Count; i++)
            {

                for (int j = 0; j < finish[i].Count; j++)
                {
                    g.Rows[rowCount].HeaderCell.Style.BackColor = FavoriteColors.c[i % FavoriteColors.c.Count()];
                    g.Rows[rowCount].HeaderCell.Value = i.ToString();
                    rowCount++;
                }
            }

            foreach (DataGridViewColumn column in g.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        public void fillSessionOperationGrid(C1.Win.C1FlexGrid.C1FlexGrid g)
        {

            g.Tree.Column = 0;
            g.Tree.Style = TreeStyleFlags.Simple;
            g.Tree.LineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            g.AllowMerging = AllowMergingEnum.Nodes;         
            try
            {
                g.Rows.Count = 1;
                for (int i = 0; i < finish.Count; i++)
                {
                    g.Rows.Count += finish[i].Count;
                }

                int rowCount = 1;
                for (int i = 0; i < finish.Count; i++)
                {
                   // g.Rows.Add();
                    g.Rows[rowCount].IsNode = true;
                    g.Rows[rowCount].Node.Level = 1;
                    //g.Rows[rowCount].Node.Collapsed = true;
                    //rowCount++;
                    for (int j = 0; j < finish[i].Count; j++)
                    {
                     //   g.Rows.Add();
                        //g.Rows[i].HeaderCell.Value = sos[i].id.ToString();
                        g[rowCount, "group_id"] = i;
                        g[rowCount, "id"] = finish[i][j].Session_operation_list_id;
                        g[rowCount, "priority"] = finish[i][j].Priority;
                        g[rowCount, "command_control_type"] = (CommandControlType)finish[i][j].Command_control_type;
                        g[rowCount, "is_not_arragment"] = finish[i][j].Is_not_arragment;
                        g[rowCount, "device_name"] = finish[i][j].Device_name;
                        g[rowCount, "parameter_name"] = finish[i][j].Parameter_name;
                        g[rowCount, "type"] = finish[i][j].Type;
                        g[rowCount, "value"] = finish[i][j].Value;
                        rowCount++;
                    }

                }
                g.AutoSizeCols();
                sessionGrid_Paint(g);
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }

        private void sessionGrid_Paint(C1FlexGrid g)
        {
            initStyles(g);
            List<Color> lc = new List<Color>() { Color.DarkGray, Color.DarkGreen, Color.Yellow, Color.Gold, Color.Purple };
            List<String> devNames = new List<String>();

            for (int i = 1; i < g.Rows.Count; i++)
            {
                String devName = g[i, "device_name"].ToString();
                C1.Win.C1FlexGrid.CellStyle cs = g.Styles.Add(devName);
                cs.BackColor = Color.FromArgb((new Random(devName[0].GetHashCode()).Next(150, 255)), (new Random(devName[1].GetHashCode()).Next(180, 255)), (new Random(devName.GetHashCode()).Next(100, 255)));
                g.SetCellStyle(i, g.Cols["device_name"].Index, devName);

                if (g[i, "type"].ToString() == "WRITE")
                {
                    g.SetCellStyle(i, g.Cols["type"].Index, "w");
                }
                else if (g[i, "type"].ToString() == "READ")
                {
                    g.SetCellStyle(i, g.Cols["type"].Index, "r");
                    g.SetCellStyle(i, g.Cols["value"].Index, "r_value");
                }

                if ((CommandControlType)g[i, "command_control_type"] != CommandControlType.NONE)
                {
                    g.SetCellStyle(i, g.Cols["command_control_type"].Index, "command_control_type");
                }

                if ((Boolean)g[i, "is_not_arragment"])
                {
                    g.SetCellStyle(i, g.Cols["is_not_arragment"].Index, "is_not_arragment");
                }
            }
            ExpandNodes(g, false);
            //int rowCount = 1;
            //for (int i = 0; i < finish.Count; i++)
            //{
            //    for (int j = 0; j < finish[i].Count; j++)
            //    {
            //        //C1.Win.C1FlexGrid.CellStyle cs = g.Styles.Add(i.ToString());
            //        //cs.BackColor = FavoriteColors.c[i % FavoriteColors.c.Count()];
            //        //g.SetCellStyle(rowCount, g.Cols["group_id"].Index, i.ToString());

            //        g[rowCount, "group_id"] = i.ToString();
            //        rowCount++;
            //    }
            //}
        }

        private void ExpandNodes(C1FlexGrid g, bool expand)
        {
            //cycle through all rows collapsing or expanding nodes
            for (int i = 1; i < g.Rows.Count; i++)
            {
                if (g.Rows[i].IsNode)
                    g.Rows[i].Node.Collapsed = !expand;
            }
            // done
            g.Focus();
        }

        private static void initStyles(C1.Win.C1FlexGrid.C1FlexGrid g)
        {
            C1.Win.C1FlexGrid.CellStyle cs = g.Styles.Add("w");
            cs.ForeColor = Color.Red;

            cs = g.Styles.Add("r");
            cs.ForeColor = Color.Blue;

            cs = g.Styles.Add("r_value");
            cs.ForeColor = Color.DarkGray;

            cs = g.Styles.Add("command_control_type");
            cs.ForeColor = Color.DarkGreen;
            cs.BackColor = Color.LightBlue;

            cs = g.Styles.Add("is_not_arragment");
            cs.BackColor = Color.LightCoral;
        }

        static double processingTime = 0.01; // Время обработки запроса            
        static double orbitalAltitude = 700; // Высота орбиты
        static double maximumRange = 3000; // Максимальная дальность связи
        double averageTransitTime = (orbitalAltitude + maximumRange) / 2 / 300000; // Время прохождения сигнала среднее

        public String getGroupExchangeTime(int groupId)
        {
            DataBudget db = calcBudget(finish[groupId]);
            return "PACK: " + groupId + " TX: " + (int)db.dataUpByte + " byte " + String.Format("{0:0.00 ms}", db.timeUp * 1000) + "; RX: " + (int)db.dataDownByte + " byte " + String.Format("{0:0.00 ms}", db.timeDown * 1000) + "; FULL TIME: " + String.Format("{0:0.00 ms}", db.allTime * 1000);
        }

        public String getExchangeTime()
        {
            double fullDataUpByte = 0;
            double fullTimeUp = 0;
            double fullDataDownByte = 0;
            double fullTimeDown = 0;
            double fullAllTime = 0;
            DataBudget db;
            foreach (List<V_session_operation_list_arragment> group in finish)
            {
                db = calcBudget(group);

                fullDataUpByte += (int)db.dataUpByte;
                fullTimeUp += db.timeUp;
                fullDataDownByte += (int)db.dataDownByte;
                fullTimeDown += db.timeDown;
                fullAllTime += db.allTime;
            }
            return "Data budget TX: " + fullDataUpByte + " byte " + String.Format("{0:0.00 ms}", fullTimeUp * 1000) + "; RX: " + fullDataDownByte + " byte " + String.Format("{0:0.00 ms}", fullTimeDown * 1000) + "; FULL TIME: " + String.Format("{0:0.00 ms}", fullAllTime * 1000);
        }

        DataBudget calcBudget(List<V_session_operation_list_arragment> gr)
        {
            DataBudget db = new DataBudget();

            db.dataDownByte = (gr[0].Type == "READ" ? 5 : 8); // Читання 5 байт / Запис 8 байт
            db.dataUpByte = (gr[0].Type == "READ" ? 8 : 9);  // Читання 8 байт / Запис 9 байт
            foreach (V_session_operation_list_arragment o in gr)
            {
                if (gr[0].Type == "READ")
                    db.dataDownByte += (int)o.Modbus_register_count * 2;
                else
                    db.dataUpByte += (int)o.Modbus_register_count * 2;
            }

            db.dataUpByte = (db.dataUpByte + 20) * 1.07;
            db.dataDownByte = (db.dataDownByte + 20) * 1.07;
            db.timeUp = (db.dataUpByte * 8) / 2400; // Час передачі вниз = кілікість біт передічі / швідкість передачі
            db.timeSat = ((db.dataDownByte + db.dataUpByte) * 10) / 115200; // Час передачі в супутнику
            db.timeDown = (db.dataDownByte * 8) / 9600; // Час передачі вверх = кілікість біт передічі / швідкість передачі
            db.timeComputure = db.timeSat; // Час передачі в комп-трансивер
            db.allTime = db.timeUp + db.timeSat + db.timeDown + db.timeComputure + averageTransitTime + processingTime; // Загальний час: 

            return db;
        }

        private struct DataBudget
        {
            public double dataDownByte;
            public double timeDown;
            public double dataUpByte;
            public double timeUp;
            public double timeSat;
            public double timeComputure;
            public double allTime;
        }

        /*
         * Компонування - другий етап
         * Тільки для типу "ЧИТАННЯ"!!
         */
        private void proccess_stage2()
        {
            log.Debug(">>>>> Arragment stage 2 begin ");
            List<List<V_session_operation_list_arragment>> newFinish = new List<List<V_session_operation_list_arragment>>();
            int index = 0;

            List<V_session_operation_list_arragment> prevGroup = null;

            foreach (List<V_session_operation_list_arragment> group in finish)
            {
                if (group[0].Is_not_arragment == false && (CommandControlType)group[0].Command_control_type == CommandControlType.NONE && group[0].Type.Equals("READ"))  // Тільки якщо група для читання, можна спробувати склеїти
                {
                    if (prevGroup != null)
                    {
                        if (prevGroup[0].Modbus_address == group[0].Modbus_address) //Адреса співпадає
                        {
                            log.Debug("Group " + index + " with common prev group prop.");
                            double timeToProccessTwoGroup = calcBudget(prevGroup).allTime + calcBudget(group).allTime;
                            List<V_session_operation_list_arragment> newGroup = glueGroup(prevGroup, group);
                            if (newGroup.Count > 0)
                            {
                                double newTimeToProccessOneGroup = calcBudget(newGroup).allTime;
                                log.Debug("timeToProccessTwoGroup = " + timeToProccessTwoGroup + " newTimeToProccessOneGroup = " + newTimeToProccessOneGroup);

                                if (timeToProccessTwoGroup > newTimeToProccessOneGroup) // Новий час менший
                                {
                                    newFinish.Add(newGroup);
                                    prevGroup = null;
                                    index++;
                                    continue;
                                }
                                else // Новий час більший
                                {
                                    newFinish.Add(prevGroup);
                                }
                            }
                            else // Склеїти групи не вийшло
                            {
                                newFinish.Add(prevGroup);
                            }
                        }
                        else // Інша адреса системи.
                        {
                            newFinish.Add(prevGroup);
                        }
                    }
                }
                else // Група на запис
                {
                    if (prevGroup != null) newFinish.Add(prevGroup);
                    newFinish.Add(group);
                    prevGroup = null;
                    index++;
                    continue;
                }

                // Якщо остання група додаємо її
                if ((finish.Count - 1) == index)
                {
                    newFinish.Add(group);
                }

                prevGroup = group;
                index++;
            }

            if (finish.Count != newFinish.Count)
            {
                finish = newFinish;
                proccess_stage2();
            }
            log.Debug("<<<<< Arragment stage 2 end. ");
        }

        /*
         * Функція склеює дві групи, якщо це можливо
         */
        private List<V_session_operation_list_arragment> glueGroup(List<V_session_operation_list_arragment> prevGroup, List<V_session_operation_list_arragment> group)
        {
            List<V_session_operation_list_arragment> result = new List<V_session_operation_list_arragment>();

            //if (prevGroup[0].register_address_start != group[0].register_address_start) // Групи не починаються з однакового регістру
            if (prevGroup[prevGroup.Count - 1].Register_address_start < group[0].Register_address_start
                &&
                prevGroup[0].Register_address_start < group[group.Count - 1].Register_address_start)
            {
                result.AddRange(prevGroup);
                long? nextStartRegisterAdr = prevGroup[prevGroup.Count - 1].Register_address_start + prevGroup[prevGroup.Count - 1].Modbus_register_count;
                long? registerInterval = group[0].Register_address_start - nextStartRegisterAdr;
                log.Debug("Register interval: " + registerInterval);
                for (int r = 0; r < registerInterval; r++)
                {
                    V_session_operation_list_arragment newOp = null; //= (V_session_operation_list_arragment)result[0].Clone();

                    newOp.Modbus_register_count = 1;
                    newOp.Register_address_start = nextStartRegisterAdr + r;
                    newOp.Priority = 0;
                    newOp.Parameter_id = 0;
                    newOp.Session_operation_list_id = 0;     
                    newOp.Parameter_name = "(" + newOp.Register_address_start + ") < ARRAGMENT OPTIMIZATION >";
                    newOp.Command_control_type = 0;
                    result.Add(newOp);

                }
                result.AddRange(group);

            }
            else if (prevGroup[prevGroup.Count - 1].Register_address_start > group[0].Register_address_start
                &&
                prevGroup[0].Register_address_start > group[group.Count - 1].Register_address_start)
            {
                result.AddRange(group);
                result.AddRange(prevGroup);
            }

            return result;
        }
    }
}
