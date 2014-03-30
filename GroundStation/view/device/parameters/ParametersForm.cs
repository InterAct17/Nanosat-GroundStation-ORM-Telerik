using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using controller;
using log4net;
using log4net.Config;

namespace GroundStation.view
{
    public partial class ParametersForm : Form
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(ParametersForm));
        ParametersManager p = new ParametersManager();
        private int deviceId;

        public ParametersForm(int id_)
        {
            InitializeComponent();
            deviceId = id_;
        }

        private void ParametersForm_Load(object sender, EventArgs e)
        {
            FillParametersGrid.fillSessionOperationGrid(parametersGrid, p.getVParametersList(deviceId));
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show((string)parametersGrid.CurrentRow.Cells["Назва"].Value, "Видалити параметр?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    p.deleteParameter(Convert.ToInt16(parametersGrid.CurrentRow.Cells[0].Value));
                    FillParametersGrid.fillSessionOperationGrid(parametersGrid, p.getVParametersList(deviceId));
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }

        private void editParamBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (parametersGrid.CurrentRow != null)
                {
                    ParameterEditForm pef = new ParameterEditForm(p.getParameter(Convert.ToInt16(parametersGrid.CurrentRow.Cells["id"].Value)));
                    if (pef.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        ConnectionManager.saveEntitiesChanges();
                        FillParametersGrid.fillSessionOperationGrid(parametersGrid, p.getVParametersList(deviceId));
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }

        private void addParamBtn_Click_1(object sender, EventArgs e)
        {
            ParameterEditForm pef = new ParameterEditForm(deviceId);
            if (pef.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                p.addParameter(pef.p);
                FillParametersGrid.fillSessionOperationGrid(parametersGrid, p.getVParametersList(deviceId));
            }
        }

        private void delParamBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show((string)parametersGrid.CurrentRow.Cells["Назва"].Value, "Видалити параметр?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    p.deleteParameter(Convert.ToInt16(parametersGrid.CurrentRow.Cells[0].Value));
                    FillParametersGrid.fillSessionOperationGrid(parametersGrid, p.getVParametersList(deviceId));
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }

        private void parametersGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editParamBtn_Click(sender, e);
        }
    }
}
