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
    public enum DialogType
    {
        OK,
        ASK,
        OK_TIMER,
        CANCEL_TIMER
    }


    public partial class QuestionFrm : Form
    {
        long? timeOut;
        DialogType dialogType;
        public long? selectedNextSessionOperationId = -1;
        CommandControlType cmdType = CommandControlType.NONE;
        List<Command_control> ccl;

        public QuestionFrm(String desc, String errorDesc, int time)
        {
            InitializeComponent();
            timeOut = time;
            this.Text = "Помилка";
            questionTxt.Visible = true;
            questionTxt.SelectionFont = new Font(questionTxt.Font, FontStyle.Bold);
            questionTxt.AppendText("При: ");
            questionTxt.SelectionFont = new Font(questionTxt.Font, FontStyle.Regular);
            questionTxt.AppendText(desc);

            questionTxt.SelectionFont = new Font(questionTxt.Font, FontStyle.Bold);
            questionTxt.AppendText("\n\nОпис помилки: ");
            questionTxt.SelectionFont = new Font(questionTxt.Font, FontStyle.Regular);
            questionTxt.AppendText(errorDesc + "\n");


            questionTxt.SelectionFont = new Font(questionTxt.Font, FontStyle.Bold);
            questionTxt.SelectionAlignment = HorizontalAlignment.Center;
            questionTxt.AppendText("\n\nСпробувати ще раз?");
            dialogType = DialogType.CANCEL_TIMER;
            configDialogResult();
        }

        public QuestionFrm()
        {
            InitializeComponent();
        }

        public DialogResult showLogicCommand(String desc, String nextSessionOperation, DialogType type, long? time)
        {
            questionTxt.Visible = true;
            questionTxt.Text = "";
            timeOut = time;
            this.Text = "Команда переходу";
            dialogType = type;

            questionTxt.SelectionFont = new Font(questionTxt.Font, FontStyle.Bold);
            questionTxt.AppendText("При: ");
            questionTxt.SelectionFont = new Font(questionTxt.Font, FontStyle.Regular);
            questionTxt.AppendText(desc);

            questionTxt.SelectionFont = new Font(questionTxt.Font, FontStyle.Bold);
            questionTxt.AppendText("\n\nЗапланований перехід на: ");
            questionTxt.SelectionFont = new Font(questionTxt.Font, FontStyle.Regular);
            questionTxt.AppendText(nextSessionOperation + "\n");


            questionTxt.SelectionFont = new Font(questionTxt.Font, FontStyle.Bold);
            questionTxt.SelectionAlignment = HorizontalAlignment.Center;
            questionTxt.AppendText("\n\nПерейти на обрану операцію?");

            configDialogResult();

            return this.DialogResult;
        }

        public DialogResult showWaitSwitchCommand(String desc, List<Command_control> ccl_, List<V_session_operation_list> vsol)
        {
            cmdType = CommandControlType.WAIT_SWITCH_CMD;
            ccl = ccl_;
            waitSwitchGrid.Visible = true;
            waitSwitchGrid.Columns[1].Visible = false;

            timeOut = ccl[0].Show_dialog_time;
            this.Text = "Команда переходу";
            dialogType = (DialogType)ccl[0].Show_dialog_type;
            String nextOpName = "";
            for (int i = 0; i < ccl.Count; i++)
            {
                foreach (V_session_operation_list vso in vsol)
                {
                    if (vso.Id == ccl[i].Next_session_operation_id) { nextOpName = vso.Device_name + " " + vso.Parameter_name; break; }
                }

                waitSwitchGrid.Rows.Add(ccl[i].Hot_key, ccl[i].Next_session_operation_id, nextOpName);
            }

            foreach (DataGridViewColumn column in waitSwitchGrid.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            configDialogResult();
            return this.DialogResult;
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {            
            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
        }

        private void configDialogResult()
        {
            if (dialogType == DialogType.CANCEL_TIMER)
            {
                timer.Interval = 1000;
                timer.Start();
                noBtn.Text = "Ні ESC (" + timeOut + ")";
            }

            if (dialogType == DialogType.OK_TIMER)
            {
                timer.Interval = 1000;
                timer.Start();
                yesBtn.Text = "Так ENTER (" + timeOut + ")";
            }
         
            if (dialogType == DialogType.OK)
            {
                if (cmdType == CommandControlType.WAIT_SWITCH_CMD)
                    this.selectedNextSessionOperationId = ccl[0].Next_session_operation_id;

                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            }
            else
            {
                this.ShowDialog();
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeOut--;
            if (timeOut > 0)
            {
                if (dialogType == DialogType.CANCEL_TIMER)
                    noBtn.Text = "Ні ESC (" + timeOut + ")";
                if (dialogType == DialogType.OK_TIMER)
                    yesBtn.Text = "Так ENTER (" + timeOut + ")";
            }
            else
            {
                if (dialogType == DialogType.CANCEL_TIMER)
                    this.DialogResult = System.Windows.Forms.DialogResult.No;

                if (dialogType == DialogType.OK_TIMER)
                    this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            }
        }
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (ccl != null)
            {
                for(int i=0; i<ccl.Count; i++)
                {
                    if (keyData.ToString().Equals(ccl[i].Hot_key))
                    {
                        waitSwitchGrid.Rows[i].Selected = true;                        
                        this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    }
                }
            }

            if (keyData == Keys.Enter) this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            if (keyData == Keys.Escape) this.DialogResult = System.Windows.Forms.DialogResult.No;

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void QuestionFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                if(cmdType == CommandControlType.WAIT_SWITCH_CMD)
                this.selectedNextSessionOperationId = ccl[waitSwitchGrid.SelectedRows[0].Index].Next_session_operation_id;
            }
        }

        private void waitSwitchGrid_DoubleClick(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
        }

        private void QuestionFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
