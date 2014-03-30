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
    public partial class EditWaitSwitchCommandControlFrm : Form
    {
        public int nextSessionOp;
        public string hotKey;
        SessionOperationListManager dsol = new SessionOperationListManager();

        public EditWaitSwitchCommandControlFrm(long? selectedOperationGroupId, int nextSessionOp, string hotKey_)
        {
            InitializeComponent();

            nextSessionOpComboBox.DisplayMember = "name";
            nextSessionOpComboBox.ValueMember = "id";
            nextSessionOpComboBox.DataSource = dsol.getVSessionOperationComboBoxDataTable((int)selectedOperationGroupId);

            if (nextSessionOp != -1)
            {
                hotKeyTxt.Text = hotKey_;
                nextSessionOpComboBox.SelectedValue = nextSessionOp;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            hotKey = hotKeyTxt.Text;
            nextSessionOp = Convert.ToInt16(nextSessionOpComboBox.SelectedValue);
            
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void hotKeyTxt_KeyDown(object sender, KeyEventArgs e)
        {
            hotKeyTxt.Text = e.KeyCode.ToString();            
        }
    }
}
