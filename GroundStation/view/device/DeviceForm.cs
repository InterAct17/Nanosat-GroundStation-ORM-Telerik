using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using controller;

namespace GroundStation.view
{
    public partial class DeviceForm : Form
    {        
        DevicesManager d = new DevicesManager();
        public DeviceForm()
        {
            InitializeComponent();
        }

        private void DeviceForm_Load(object sender, EventArgs e)
        {
            deviceGrid.DataSource = d.getDivices();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
                
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void mobBusMapBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void editBtnMenu_Click(object sender, EventArgs e)
        {
            DeviceEditForm de = new DeviceEditForm(d.getDivice(Convert.ToInt16(deviceGrid.CurrentRow.Cells[0].Value)));
            if (de.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {                
                ConnectionManager.saveEntitiesChanges();
                deviceGrid.DataSource = d.getDivices();
            }     
        }

        private void addBtnMenu_Click(object sender, EventArgs e)
        {
            DeviceEditForm de = new DeviceEditForm(null);
            if (de.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                d.addDivice(de.dev);
                deviceGrid.DataSource = d.getDivices();
            }
        }

        private void delBtnMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show((string)deviceGrid.CurrentRow.Cells[2].Value, "Видалити систему?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                d.deleteDivice(Convert.ToInt16(deviceGrid.CurrentRow.Cells[0].Value));
                deviceGrid.DataSource = d.getDivices();
            }
        }

        private void modBusMapEditBtnMenu_Click(object sender, EventArgs e)
        {
            if (deviceGrid.CurrentRow != null)
            {
                (new ParametersForm(Convert.ToInt16(deviceGrid.CurrentRow.Cells[0].Value))).Show();
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void deviceGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            modBusMapEditBtnMenu_Click(sender, e);
        }
    }
}
