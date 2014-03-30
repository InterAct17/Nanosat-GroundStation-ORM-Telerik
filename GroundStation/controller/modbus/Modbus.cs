using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Modbus.Device;
using Modbus.IO;
using log4net;
using log4net.Config;

namespace controller
{
    public class Modbus
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(Modbus));
        private IModbusSerialMaster master;
        private SerialPort port = new SerialPort();
        //private MBStream port;

        public Modbus(SerialPort port)
        {
            try
            {
                if (port != null)
                    this.port = port;// new MBStream(port);
            }
            catch (Exception ex)
            {
                log.Error("Init MODBUS: " + ex.Message, ex);
            }
        }

        public bool isOpen()
        {
            return port.IsOpen;
        }

        public void connectDevice()
        {
            try
            {
                port.Open();
                log.Info("Port opened successfully...");
                master = ModbusSerialMaster.CreateRtu(port);
                //master.Transport.CheckFrame = false;
                log.Info("ModBus master initialized successfully !");
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }

        public void disconnectDevice()
        {
            try
            {
                port.Close();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }

        public ushort[] transferProcessing(byte devAdr, ModBusFunc funcOp, ushort regAdr, ushort regType, ushort[] value)
        {
            //funcOp = ModBusFunc.READ_HOLDING_REGISTER;
            try
            {                
                if (port.IsOpen)
                {
                    switch (funcOp)
                    {
                        case ModBusFunc.READ_HOLDING_REGISTER: return master.ReadHoldingRegisters(devAdr, regAdr, regType);
                        case ModBusFunc.WRITE_HOLDING_REGISTER: master.WriteMultipleRegisters(devAdr, regAdr, value); break;
                        default: throw new Exception(" transferProcessing(byte devAdr, ModBusFunc funcOp, ushort regAdr, ushort regType, ushort[] value) Unknown modbus function.");
                    }
                }
                else
                {
                    throw new Exception("transferProcessing(byte devAdr, ModBusFunc funcOp, ushort regAdr, ushort regType, ushort[] value) Port closed!!");
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
                return null;
            }
            return null;

            //Object _this = assembleParam(p.parameterParts);
            //if (p.return_type.ToLower().Equals("float")) return (float)(_this);
            //if (p.return_type.ToLower().Equals("double")) return (double)(_this);
            //if (p.return_type.ToLower().Equals("uint16")) return (UInt16)(_this);
            //if (p.return_type.ToLower().Equals("uint32")) return (UInt32)(_this);
            //if (p.return_type.ToLower().Equals("int16")) return (Int16)(_this);
            //if (p.return_type.ToLower().Equals("int32")) return (Int32)(_this);
        }

    }
}
