using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using controller;
using GroundStation.model.entity.telerik;

namespace GroundStation.view
{
    public partial class SessionForm : Form
    {
        OperationGroupManager operationGroupManager = new OperationGroupManager();
        SessionOperationListManager sessionOperationManager = new SessionOperationListManager();        
        public Operation_group selectedOperationGroup = new Operation_group();

        public SessionForm(long selectedOperationGroupId)
        {
           InitializeComponent();
        }

        private void DeviceForm_Load(object sender, EventArgs e)
        {
            operationGroupGrid.DataSource = operationGroupManager.getOperationGroup();
        }

        private void editBtnMenu_Click(object sender, EventArgs e)
        {
            SessionEditForm se = new SessionEditForm(operationGroupManager.getOperationGroup(Convert.ToInt16(operationGroupGrid.CurrentRow.Cells[0].Value)));
            if (se.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {             
                ConnectionManager.saveEntitiesChanges();
                operationGroupGrid.DataSource = operationGroupManager.getOperationGroup();
            }
        }

        private void addBtnMenu_Click(object sender, EventArgs e)
        {
            SessionEditForm se = new SessionEditForm(null);
            if (se.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                operationGroupManager.addOperationGroup(se.operationGroup);
                operationGroupGrid.DataSource = operationGroupManager.getOperationGroup();
            }
        }

        private void delBtnMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити сеанс зв'язку: " + (string)operationGroupGrid.CurrentRow.Cells[1].Value + "? \nОперацію не можливо буде відмінити!!", "Попередження!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                operationGroupManager.deleteOperationGroup(Convert.ToInt16(operationGroupGrid.CurrentRow.Cells[0].Value));
                operationGroupGrid.DataSource = operationGroupManager.getOperationGroup();
            }
        }

        private void modBusMapEditBtnMenu_Click(object sender, EventArgs e)
        {
            Operation_group ogObj = operationGroupManager.getOperationGroup(Convert.ToInt16(operationGroupGrid.CurrentRow.Cells[0].Value));
            SessionEditForm se = new SessionEditForm(ogObj);
            se.Text = "Копіювати сеанс зв'язку '" + ogObj.Name + "'";
            if (se.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                long newGroup_id = operationGroupManager.addOperationGroup(se.operationGroup);
                sessionOperationManager.addSessionOperationList(newGroup_id, sessionOperationManager.getSessionOperationList(se.operationGroup.Id));
                operationGroupGrid.DataSource = operationGroupManager.getOperationGroup();
            }
        }

        private void loadBtnMenu_Click(object sender, EventArgs e)
        {
            selectedOperationGroup = operationGroupManager.getOperationGroup(Convert.ToInt64(operationGroupGrid.CurrentRow.Cells["id"].Value));
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void operationGroupGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            loadBtnMenu_Click(sender, e);
        }
    }
}
