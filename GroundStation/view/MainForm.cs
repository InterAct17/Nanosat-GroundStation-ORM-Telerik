using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using log4net;
using log4net.Config;
using log4net.Appender;
using controller;
using C1.Win.C1FlexGrid;
using GroundStation.model.entity.telerik;

namespace GroundStation.view
{
    public partial class mainForm : Form
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(mainForm));
        readonly string configFileName = "SerialPort.config";

        Thread trd;

        SessionOperationListManager sessionOperationManager = new SessionOperationListManager();
        CommandControlManager dcc = new CommandControlManager();
        CommandLine commandLine = new CommandLine();

        bool isThreadStart = false;
        bool arrangementSession = false;
        LogEventAppender myAppender;
        long selectedOperationGroupId = -1;
        SessionTransfer st;
        long ts; //Для відліку тривалості сеансу звязку.
        SessionOperationListArragment sola; // Компонований сеанс зв'язку

        public mainForm()
        {
            InitializeComponent();            
            log4net.Config.XmlConfigurator.Configure();
            log4net.Repository.Hierarchy.Logger root = ((log4net.Repository.Hierarchy.Hierarchy)log4net.LogManager.GetRepository()).Root;
            myAppender = new LogEventAppender(log4netRichTextBox);
            root.AddAppender(myAppender);
            myAppender.isDebugMode = isDebugModeBtn.Checked;
            log.Info("Ініціалізація GUI виконана...");
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            devicesComboBox.DisplayMember = "name";
            devicesComboBox.ValueMember = "id";
            refresh();
        }

        private void refresh()
        {
            devicesComboBox.DataSource = (new DevicesManager()).getDivicesSimple();
            FillGrid.fillSessionOperationGrid(sessionFlexGrid1, sessionOperationManager.getVSessionOperationList(selectedOperationGroupId), transferInfoLabel);
            sessionFlexGrid1.Cols[0].Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                parameterFlexGrid.DataSource = (new controller.ParametersManager()).getParametersSimple(Convert.ToInt16(devicesComboBox.SelectedValue));              
                parameterFlexGrid.AutoSizeCols();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }

        private void deleteSessionOperationFromGroupBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Ідентифікатор параметру: " + Convert.ToInt16(sessionFlexGrid1[sessionFlexGrid1.RowSel, "id"]), "Видалити параметр?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    sessionOperationManager.deleteSessionOperationById(Convert.ToInt16(sessionFlexGrid1[sessionFlexGrid1.RowSel, "id"]));
                    refresh();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }

        private void threadDemoSession()
        {

            int sessionCount = 0;
            int nextRow = 0;
            if (!arrangementSession)
            {
                sessionCount = sessionFlexGrid1.Rows.Count;
                transferProgressBar.Maximum = sessionCount;
            }
            else
            {
                sessionCount = sessionArrangemendataFlexGrid.Rows.Count;
                transferProgressBar.Maximum = sessionCount;
            }

            try
            {
                st = new SessionTransfer(isRecordTelemetryBtn.Checked);
                st.modbus.connectDevice();

                while (st.modbus.isOpen())
                {
                    if (nextRow < sessionCount && isThreadStart)
                    {
                        if (!arrangementSession)
                        {
                            nextRow = st.transferSessionNotArragment(sessionFlexGrid1);
                            transferProgressBar.Value = nextRow;
                        }
                        else
                        {
                            nextRow = st.transferSessionArragment(sessionArrangemendataFlexGrid, sola.getSessionOperationListArragment());
                            transferProgressBar.Value = nextRow;
                        }
                    }
                    else break;
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
            finally
            {
                playSessionBtn.Text = "Провести сеанс";
                myAppender.isThreadStart = false;
                sessionFlexGrid1.Enabled = true;
                sessionArrangemendataFlexGrid.Enabled = true;

                st.modbus.disconnectDevice();
                log.Info("Сеансу зв'язку закінчився. Тривалість: " + new DateTime(DateTime.Now.Ticks - ts));
            }
        }

        private void upBtn_Click(object sender, EventArgs e)
        {
            if (isSessionGridRow())
            {
                int selectedRowIndex = sessionFlexGrid1.RowSel;
                changePriority(selectedRowIndex, selectedRowIndex > 1 ? selectedRowIndex - 1 : sessionFlexGrid1.Rows.Count - 1);
            }
        }

        private void downBtn_Click(object sender, EventArgs e)
        {
            if (isSessionGridRow())
            {
                int selectedRowIndex = sessionFlexGrid1.RowSel;
                changePriority(selectedRowIndex, selectedRowIndex > sessionFlexGrid1.Rows.Count - 2 ? 1 : selectedRowIndex + 1);
            }
        }

        private void changePriority(int selectedRowIndex, int newSelectedRowIndex)
        {
            int op1_id = Convert.ToInt16(sessionFlexGrid1[selectedRowIndex, "id"]);
            Session_operation_list op1 = sessionOperationManager.getSessionOperationById(op1_id);

            int op2_id = Convert.ToInt16(sessionFlexGrid1[newSelectedRowIndex, "id"]);
            Session_operation_list op2 = sessionOperationManager.getSessionOperationById(op2_id);
            sessionOperationManager.replaceSessionOperation(op1, op2);

            FillGrid.fillSessionOperationGrid(sessionFlexGrid1, sessionOperationManager.getVSessionOperationList(selectedOperationGroupId), transferInfoLabel);
            sessionFlexGrid1.Select(newSelectedRowIndex, 0);
        }

        private void sessionGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editCommandControl();
        }

        private void editCommandControl()
        {

            if (isSessionGridRow())
            {
                //sessionFlexGrid1[
                int op_id = Convert.ToInt16(sessionFlexGrid1[sessionFlexGrid1.RowSel, "id"]);
                Session_operation_list so = sessionOperationManager.getSessionOperationById(op_id);
                Parameter p = (new ParametersManager()).getParameter(so.Parameter_id);
                Device d = (new DevicesManager()).getDivice(p.Device_id);

                (new CommandControlFrm(so, p, d)).ShowDialog();
                refresh();
            }
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (trd != null && trd.IsAlive)
            {
                if (MessageBox.Show("Працює потік обміну. Ви дійсно хочете зупинити потік?", "Попередження!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    isThreadStart = false;
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void playSessionBtn_Click(object sender, EventArgs e)
        {
            if (trd == null || !trd.IsAlive)
            {
                //Для доступу до елементів форми з інших потоків
                System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
                trd = new Thread(new ThreadStart(this.threadDemoSession));
                trd.IsBackground = true;
                trd.Start();
                isThreadStart = true;

                log.Info("Початок сеансу зв'язку");
                ts = DateTime.Now.Ticks;
                playSessionBtn.Text = "Закінчити сеанс";
                myAppender.isThreadStart = true;

                sessionFlexGrid1.Enabled = false;
                sessionArrangemendataFlexGrid.Enabled = false;
            }
            else
            {
                isThreadStart = false;
            }
        }

        private void arrangementButton_Click(object sender, EventArgs e)
        {
            if (!arrangementSession)
            {

                arrangementSession = true;
                arrangementButton.Text = "Розкомпонувати";
                mainSplitContainer.Visible = false;
                arrangemenGroupBox.Visible = true;
                sola = new SessionOperationListArragment(sessionOperationManager.getVSessionOperationArragmentList(selectedOperationGroupId));
                sola.fillSessionOperationGrid(sessionArrangemendataFlexGrid);

            }
            else
            {
                if (MessageBox.Show("Розкомпонувати зі зберереженням пріоритету? Must fix!!", "Розкомпоновка?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    //int i = 0;
                    //foreach (DataGridViewRow r in sessionArrangemendataGridView.Rows)
                    //{
                    //    int p = Convert.ToInt16(r.Cells["priority"].Value);
                    //    if (p != i)
                    //    {
                    //        SessionOperation op1 = sessionOperationManager.getSessionOperationById(Convert.ToInt16(r.Cells["id"].Value));
                    //        op1.priority = i;
                    //        sessionOperationManager.updateSessionOperation(op1);

                    //    }
                    //    i++;
                    //}
                    refresh();
                }
                arrangementSession = false;
                arrangementButton.Text = "Компонувати";
                mainSplitContainer.Visible = true;
                arrangemenGroupBox.Visible = false;
            }
        }

        private void devicesBtn_Click(object sender, EventArgs e)
        {
            (new DeviceForm()).ShowDialog();
        }

        private void isDebugModeBtn_Click(object sender, EventArgs e)
        {
            myAppender.isDebugMode = isDebugModeBtn.Checked;
        }

        private void btnShowSessinons_Click(object sender, EventArgs e)
        {
            SessionForm s = new SessionForm(selectedOperationGroupId);
            if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                selectedOperationGroupId = s.selectedOperationGroup.Id;
                sessionEdittoolStripLabel.Text = "Сеанс зв'язку: " + s.selectedOperationGroup.Name;
                refresh();
            }
        }

        private void editSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isSessionGridRow())
            {
                AddOperationForm aof = new AddOperationForm(sessionOperationManager.getSessionOperationById(Convert.ToInt16(sessionFlexGrid1[sessionFlexGrid1.RowSel, "id"])));
                if (aof.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ConnectionManager.saveEntitiesChanges();
                    refresh();
                }
            }
            else
            {
                MessageBox.Show("Оберіть параметр");
            }
        }

        private void deleteSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (isSessionGridRow())
                {
                    if (MessageBox.Show("Ідентифікатор параметру: " + Convert.ToInt16(sessionFlexGrid1[sessionFlexGrid1.RowSel, "id"]), "Видалити параметр?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        sessionOperationManager.deleteSessionOperationById(Convert.ToInt16(sessionFlexGrid1[sessionFlexGrid1.RowSel, "id"]));
                        refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }

        private void редагуватиСтрокуКеруванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editCommandControl();
        }

        private void connectionPropertyForm_Click(object sender, EventArgs e)
        {
            (new ConnectionPropertyForm(configFileName)).ShowDialog();
        }

        private void isDebugModeBtn_Click_1(object sender, EventArgs e)
        {
            myAppender.isDebugMode = isDebugModeBtn.Checked;
            if (isDebugModeBtn.Checked)
            {
                for (int i = 0; i < sessionArrangemendataFlexGrid.Cols.Count; i++) sessionArrangemendataFlexGrid.Cols[i].Visible = true;
                for (int i = 0; i < sessionFlexGrid1.Cols.Count; i++) sessionFlexGrid1.Cols[i].Visible = true;
            }
        }

        private void sessionFlexGrid1_DoubleClick(object sender, EventArgs e)
        {
            editCommandControl();
        }

        private void sessionFlexGrid1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = sessionFlexGrid1.HitTest(e.X, e.Y);
                if (hti.Row > 0 && sessionFlexGrid1[hti.Row, "id"] != null)
                {
                    sessionFlexGrid1.Select(hti.Row, 0);
                    sessionGridContextMenuStrip.Enabled = true;
                }
                else
                {
                    sessionGridContextMenuStrip.Enabled = false;
                }
            }
        }
        private bool isSessionGridRow()
        {
            return sessionFlexGrid1.RowSel > 0 && sessionFlexGrid1[sessionFlexGrid1.RowSel, "id"] != null;
        }

        private void sessionFlexGrid1_KeyUp(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
            switch (e.KeyCode.ToString().ToUpper())
            {
                case "DELETE": deleteSessionToolStripMenuItem_Click(sender, e); break;
            }
        }

        private void sessionArrangemendataFlexGrid_MouseClick(object sender, MouseEventArgs e)
        {
            int r = sessionArrangemendataFlexGrid.RowSel;
            if (r > -1)
            {
                object groupId = sessionArrangemendataFlexGrid[r, "group_id"];
                for (int i = 1; i < sessionArrangemendataFlexGrid.Rows.Count; i++)
                {
                    if (sessionArrangemendataFlexGrid[i, "group_id"].Equals(groupId))
                    {
                        sessionArrangemendataFlexGrid.Rows[i].Selected = true;
                    }
                    else
                    {
                        sessionArrangemendataFlexGrid.Rows[i].Selected = false;
                    }
                }
                log.Info(sola.getGroupExchangeTime(Convert.ToInt16(groupId)));
            }
        }

        private void aliasBtn_Click(object sender, EventArgs e)
        {
            (new AliasForm()).ShowDialog();
        }

        private void додатиПараметриВСеансЗвязкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Row r in parameterFlexGrid.Rows.Selected)
            {
                AddOperationForm aof = new AddOperationForm(Convert.ToInt16(selectedOperationGroupId), Convert.ToInt16(r[0]));
                if (aof.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    sessionOperationManager.addSessionOperation(aof.o);
                }
            }
            refresh();
        }
    }

}



