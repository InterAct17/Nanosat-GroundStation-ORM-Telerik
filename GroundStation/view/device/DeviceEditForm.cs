using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using log4net;
using GroundStation.model.entity.telerik;

namespace GroundStation.view
{
    public partial class DeviceEditForm : Form
    {
        public Device dev;
        public static readonly ILog log = LogManager.GetLogger(typeof(DeviceEditForm));    

        public DeviceEditForm(Device d)
        {
            InitializeComponent();

            if (d != null)
            {
                dev = d;
                idTxt.ReadOnly = true;
                this.Text = "Редагування: " + d.Name;
                idTxt.Text = d.Id.ToString();
                modbus_addressTxt.Text = d.Modbus_address.ToString();
                nameTxt.Text = d.Name;
                descriptionTxt.Text = d.Description;
            }
            else if (d == null)
            {
                dev = new Device();
                idTxt.ReadOnly = true;
                this.Text = "Додати систему";
                idTxt.Text = "0";
                modbus_addressTxt.Text = "0";
                nameTxt.Text = "Назва";
                descriptionTxt.Text = "Опис";
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dev.Id = Convert.ToInt16(idTxt.Text);
                dev.Modbus_address = Convert.ToInt16(modbus_addressTxt.Text);
                dev.Name = nameTxt.Text;
                dev.Description = descriptionTxt.Text;
                DialogResult = System.Windows.Forms.DialogResult.OK;                
            }
            catch (Exception ex) {
                log.Error(ex.Message, ex);
            }
        }
    }
}
