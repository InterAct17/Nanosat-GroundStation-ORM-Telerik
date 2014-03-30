using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Configuration;
using Microsoft.Win32;
using log4net;



namespace GroundStation.view
{
    [Serializable()]
    public partial class ConnectionPropertyForm : Form
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(ConnectionPropertyForm));
        readonly string configFileName;
        private Dictionary<string, string> friendlyPorts;       

        public ConnectionPropertyForm(String configFileName)
        {
            InitializeComponent();
            this.configFileName = configFileName;
        }

        private void initForm()
        {
            try
            {
                ComboBoxPortName.Items.Clear();
                ComboBoxBoudRate.Items.Clear();

                // Список портів            
                friendlyPorts = BuildPortNameHash(SerialPort.GetPortNames());
                if (friendlyPorts.Count > 0)
                {
                    foreach (KeyValuePair<string, string> kvp in friendlyPorts)
                    {
                        ComboBoxPortName.Items.Add(kvp.Value);
                    }
                }
                else {
                    ComboBoxPortName.Items.Add("none");
                }

                ComboBoxPortName.SelectedIndex = ComboBoxPortName.Items.Count - 1;
                //Швидкость передачі
                ComboBoxBoudRate.Items.Add("2400");
                ComboBoxBoudRate.Items.Add("4800");
                ComboBoxBoudRate.Items.Add("9600");
                ComboBoxBoudRate.Items.Add("14400");
                ComboBoxBoudRate.Items.Add("19200");
                ComboBoxBoudRate.Items.Add("115200");
                ComboBoxBoudRate.Items.Add("256000");
                ComboBoxBoudRate.SelectedIndex = 5;

                var configMap = new ExeConfigurationFileMap { ExeConfigFilename = configFileName };
                Configuration externalConfig = ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None);
                ComboBoxPortName.Text = externalConfig.AppSettings.Settings["PortName"].Value;
                ComboBoxBoudRate.Text = externalConfig.AppSettings.Settings["baudRate"].Value;
                TxtBufferReadSize.Text = externalConfig.AppSettings.Settings["readBufferSize"].Value;
                TxtBufferWriteSize.Text = externalConfig.AppSettings.Settings["writeBufferSize"].Value;
                TxtReadTimeout.Text = externalConfig.AppSettings.Settings["readTimeout"].Value;
                TxtWriteTimeout.Text = externalConfig.AppSettings.Settings["writeTimeout"].Value;
                //setProperty();
            }
           catch (Exception e)
            {
                log.Error("init connection form", e);
            }
        }

        private void setProperty()
        {   
            try
            {
                //Save prop
                var configMap = new ExeConfigurationFileMap { ExeConfigFilename = configFileName };
                Configuration externalConfig = ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None);
                externalConfig.AppSettings.Settings["PortName"].Value = friendlyPorts.FirstOrDefault(x => x.Value == ComboBoxPortName.Text).Key; 
                externalConfig.AppSettings.Settings["baudRate"].Value = ComboBoxBoudRate.Text;
                externalConfig.AppSettings.Settings["readBufferSize"].Value = TxtBufferReadSize.Text;
                externalConfig.AppSettings.Settings["writeBufferSize"].Value = TxtBufferWriteSize.Text;
                externalConfig.AppSettings.Settings["readTimeout"].Value = TxtReadTimeout.Text;
                externalConfig.AppSettings.Settings["writeTimeout"].Value = TxtWriteTimeout.Text;

                externalConfig.AppSettings.Settings["dataBits"].Value = "8";
                externalConfig.AppSettings.Settings["parity"].Value = ((int)Parity.None).ToString();
                externalConfig.AppSettings.Settings["stopBits"].Value = ((int)StopBits.One).ToString();
                externalConfig.Save(ConfigurationSaveMode.Full);
            }
            catch (Exception e)
            {
                log.Error("setProperty() -> save to config file", e);
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            setProperty();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        /// <summary>
        /// Begins recursive registry enumeration
        /// </summary>
        /// <param name="portsToMap">array of port names (i.e. COM1, COM2, etc)</param>
        /// <returns>a hashtable mapping Friendly names to non-friendly port values</returns>
        static Dictionary<string, string> BuildPortNameHash(string[] portsToMap)
        {
            Dictionary<string, string> oReturnTable = new Dictionary<string, string>();
            MineRegistryForPortName("SYSTEM\\CurrentControlSet\\Enum", oReturnTable, portsToMap);
            return oReturnTable;
        }
        /// <summary>
        /// Recursively enumerates registry subkeys starting with startKeyPath looking for 
        /// "Device Parameters" subkey. If key is present, friendly port name is extracted.
        /// </summary>
        /// <param name="startKeyPath">the start key from which to begin the enumeration</param>
        /// <param name="targetMap">dictionary that will get populated with 
        /// nonfriendly-to-friendly port names</param>
        /// <param name="portsToMap">array of port names (i.e. COM1, COM2, etc)</param>
        static void MineRegistryForPortName(string startKeyPath, Dictionary<string, string> targetMap,
            string[] portsToMap)
        {
            if (targetMap.Count >= portsToMap.Length)
                return;
            using (RegistryKey currentKey = Registry.LocalMachine)
            {
                try
                {                     
                    using (RegistryKey currentSubKey = currentKey.OpenSubKey(startKeyPath))
                    {
                        string[] currentSubkeys = currentSubKey.GetSubKeyNames();
                        if (currentSubkeys.Contains("Device Parameters") &&
                            startKeyPath != "SYSTEM\\CurrentControlSet\\Enum")
                        {
                            object portName = Registry.GetValue("HKEY_LOCAL_MACHINE\\" +
                                startKeyPath + "\\Device Parameters", "PortName", null);
                            if (portName == null ||
                                portsToMap.Contains(portName.ToString()) == false)
                                return;
                            object friendlyPortName = Registry.GetValue("HKEY_LOCAL_MACHINE\\" +
                                startKeyPath, "FriendlyName", null);
                            string friendlyName = "N/A";
                            if (friendlyPortName != null)
                                friendlyName = friendlyPortName.ToString();
                            if (friendlyName.Contains(portName.ToString()) == false)
                                friendlyName = string.Format("{0} ({1})", friendlyName, portName);
                            targetMap[portName.ToString()] = friendlyName;
                        }
                        else
                        {
                            foreach (string strSubKey in currentSubkeys)
                                MineRegistryForPortName(startKeyPath + "\\" + strSubKey, targetMap, portsToMap);
                        }
                    }
                }
                catch (Exception e)
                {
                   log.Error("MineRegistryForPortName()", e);
                }
            }
        }

        private void FrmProperty_Shown(object sender, EventArgs e)
        {
            initForm();
        }
    }
}
