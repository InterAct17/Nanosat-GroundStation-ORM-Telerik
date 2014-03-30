using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using log4net;
using controller;
using GroundStation.model.entity.telerik;

namespace GroundStation.view
{

    public partial class CommandControlFrm : Form
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(mainForm));
        Session_operation_list so;
        Parameter param;
        Device dev;
        CommandControlManager dcc = new CommandControlManager();
        SessionOperationListManager dsol = new SessionOperationListManager();
        List<V_session_operation_list> vsol;

        List<Command_control> commandControlListToAdd;

        public CommandControlFrm(Session_operation_list so_, Parameter p, Device d)
        {
            so = so_;
            param = p;
            dev = d;
            InitializeComponent();
        }

        private void controlCommandFrm_Load(object sender, EventArgs e)
        {
            opDescription.Text = "Пріорітет: " + so.Priority.ToString() + "; Cистема: " + dev.Name + "; Параметр: " + param.Name + ".";
            questionComboBox.SelectedIndex = 0;
            controlCommandComboBox.SelectedIndex = 0;
            ifGroupBox.Visible = false;
            waitGroupBox.Visible = false;
            waitSwitchGroupBox.Visible = false;

            nextSessionOperationComboBox.DisplayMember = "name";
            nextSessionOperationComboBox.ValueMember = "id";
            nextSessionOperationComboBox.DataSource = dsol.getVSessionOperationComboBoxDataTable(so.Operation_group_id);

            vsol = dsol.getVSessionOperationList(so.Operation_group_id);


            if (so.Command_control_type != 0)
            {
                commandControlListToAdd = dcc.getCommandControlList(so.Id);
                if (commandControlListToAdd.Count > 0)
                {
                    questionComboBox.SelectedIndex = (int)commandControlListToAdd[0].Show_dialog_type;
                    switch (so.Command_control_type)
                    {
                        case 0: commandControlListToAdd = null; break;
                        case 1:
                            nextSessionOperationComboBox.SelectedValue = commandControlListToAdd[0].Next_session_operation_id;
                            exprTxt.Text = commandControlListToAdd[0].Expression;
                            break;
                        case 2:
                            break;
                        case 3:
                            setWaitSwitchCommandControlList();
                            break;
                    }
                }
                controlCommandComboBox.SelectedIndex = (short)so.Command_control_type;
            }
        }

        private void controlCommandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ifGroupBox.Visible = false;
            waitGroupBox.Visible = false;
            waitSwitchGroupBox.Visible = false;

            switch (controlCommandComboBox.SelectedIndex)
            {
                case 1: ifGroupBox.Visible = true; break;
                case 2: waitGroupBox.Visible = true; break;
                case 3: waitSwitchGroupBox.Visible = true; break;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Command_control com = new Command_control();
            commandControlListToAdd = new List<Command_control>();

            try
            {
                switch (controlCommandComboBox.SelectedIndex)
                {
                    case 0: commandControlListToAdd = null; break;
                    case 1:
                        com.Session_operation_id = so.Id;
                        com.Next_session_operation_id = Convert.ToInt16(nextSessionOperationComboBox.SelectedValue);
                        com.Expression = exprTxt.Text;
                        com.Show_dialog_type = (short)questionComboBox.SelectedIndex;
                        com.Show_dialog_time = Convert.ToInt16(timeTxt.Text);
                        commandControlListToAdd.Add(com);
                        break;
                    case 2:
                        com.Session_operation_id = so.Id;
                        com.Show_dialog_type = (short)questionComboBox.SelectedIndex;
                        com.Show_dialog_time = Convert.ToInt16(timeTxt.Text);
                        commandControlListToAdd.Add(com);
                        break;
                    case 3:
                        com.Session_operation_id = so.Id;
                        commandControlListToAdd = getWaitSwitchCommandControlList();
                        break;
                }

                if (so.Command_control_type != 0)
                {
                    dcc.deleteCommandControl(so.Id);

                    if (commandControlListToAdd != null)
                    {
                        dcc.addCommandControlList(commandControlListToAdd);
                    }
                    else // Видалити всі команди
                    {
                        so.Command_control_type = (short)controlCommandComboBox.SelectedIndex;
                    }
                }
                else
                {
                    if (commandControlListToAdd != null)
                    {
                        dcc.addCommandControlList(commandControlListToAdd);
                    }
                }

                so.Command_control_type = (short)controlCommandComboBox.SelectedIndex;
                ConnectionManager.saveEntitiesChanges();

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }

        private void addWaitSwitchBtn_Click(object sender, EventArgs e)
        {
            EditWaitSwitchCommandControlFrm addWSCCF = new EditWaitSwitchCommandControlFrm(so.Operation_group_id, - 1, "");
            if (addWSCCF.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                waitSwitchGrid.Rows.Add(addWSCCF.hotKey, addWSCCF.nextSessionOp, getSessionOperationName(addWSCCF.nextSessionOp));
            }
        }

        private void delWaitSwitchBtn_Click(object sender, EventArgs e)
        {
            if (waitSwitchGrid.CurrentRow != null)
            {
                if (MessageBox.Show(Convert.ToString(waitSwitchGrid.CurrentRow.Cells[1].Value), "Видалити строку переходу?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    waitSwitchGrid.Rows.RemoveAt(waitSwitchGrid.CurrentRow.Index);
                }
            }
            else
            {
                MessageBox.Show("Оберіть строку.");
            }
        }

        private void waitSwitchGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            EditWaitSwitchCommandControlFrm addWSCCF = new EditWaitSwitchCommandControlFrm(so.Operation_group_id, Convert.ToUInt16(waitSwitchGrid.CurrentRow.Cells[1].Value), Convert.ToString(waitSwitchGrid.CurrentRow.Cells[0].Value));
            if (addWSCCF.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                waitSwitchGrid.CurrentRow.Cells[0].Value = addWSCCF.hotKey;
                waitSwitchGrid.CurrentRow.Cells[1].Value = addWSCCF.nextSessionOp;
                waitSwitchGrid.CurrentRow.Cells[2].Value = getSessionOperationName(addWSCCF.nextSessionOp);
            }
        }

        private List<Command_control> getWaitSwitchCommandControlList()
        {
            List<Command_control> ccl = new List<Command_control>();
            for (int i = 0; i < waitSwitchGrid.RowCount; i++)
            {
                Command_control com = new Command_control();
                com.Show_dialog_type = (short)questionComboBox.SelectedIndex;
                com.Session_operation_id = so.Id;
                com.Show_dialog_time = Convert.ToInt16(timeTxt.Text);
                com.Hot_key = Convert.ToString(waitSwitchGrid[0, i].Value);
                com.Next_session_operation_id = Convert.ToInt16(waitSwitchGrid[1, i].Value);
                ccl.Add(com);
            }

            return ccl;
        }

        private void setWaitSwitchCommandControlList()
        {
            for (int i = 0; i < commandControlListToAdd.Count; i++)
            {
                waitSwitchGrid.Rows.Add(commandControlListToAdd[i].Hot_key, commandControlListToAdd[i].Next_session_operation_id, getSessionOperationName(commandControlListToAdd[i].Next_session_operation_id));
            }
        }

        private string getSessionOperationName(long? id)
        {
            foreach (V_session_operation_list vso in vsol)
            {
                if (vso.Id == id) return vso.Device_name + " " + vso.Parameter_name;
            }
            return "Помилка!!";
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void questionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (questionComboBox.SelectedIndex == 2 || questionComboBox.SelectedIndex == 3) timeTxt.Enabled = true;
            else timeTxt.Enabled = false;
        }
    }
}
