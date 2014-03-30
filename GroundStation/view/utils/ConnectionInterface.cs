using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Configuration;
using Microsoft.Win32;
using log4net;

namespace GroundStation.view
{
    static public class ConnectionInterface
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(ConnectionInterface));

        static public SerialPort getSerialPortObject(String configFileName)
        {
            try
            {
                var configMap = new ExeConfigurationFileMap { ExeConfigFilename = configFileName };
                Configuration externalConfig = ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None);

                SerialPort sp = new SerialPort();

                sp.PortName = externalConfig.AppSettings.Settings["PortName"].Value;
                sp.BaudRate = Convert.ToInt32(externalConfig.AppSettings.Settings["baudRate"].Value);
                sp.ReadBufferSize = Convert.ToInt32(externalConfig.AppSettings.Settings["readBufferSize"].Value);
                sp.WriteBufferSize = Convert.ToInt32(externalConfig.AppSettings.Settings["writeBufferSize"].Value);
                sp.ReadTimeout = Convert.ToInt32(externalConfig.AppSettings.Settings["readTimeout"].Value);
                sp.WriteTimeout = Convert.ToInt32(externalConfig.AppSettings.Settings["writeTimeout"].Value);
                sp.DataBits = 8;
                sp.Parity = Parity.None;
                sp.StopBits = StopBits.One;

                return sp;
            }
            catch (Exception e)
            {
                log.Error("setProperty() -> init serial port object", e);
            }
            return null;
        }
    }
}
