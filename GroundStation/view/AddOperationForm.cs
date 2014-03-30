using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using log4net;
using log4net.Config;
using controller;
using GroundStation.model.entity.telerik;

namespace GroundStation.view
{
    public partial class AddOperationForm : Form
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(AddOperationForm));
        public Session_operation_list o = new Session_operation_list();
        public Parameter param = new Parameter();

        public AddOperationForm(Int16 operationGroupId_, Int16 parameterId_)
        {
            try
            {
                InitializeComponent();
                o.Parameter_id = parameterId_;
                o.Operation_group_id = operationGroupId_;
                o.Command_control_type = 0;
                param = new ParametersManager().getParameter(parameterId_);
                parameterIdTxt.Text = param.Name;
                typeOperationCombo.Items.Clear();
                typeOperationCombo.Items.Add("Читання");
                typeOperationCombo.SelectedIndex = 0;
                if (param.Access == (int)AccessType.READ_WRITE) typeOperationCombo.Items.Add("Запис");
            }
            catch (Exception ex) {
                log.Error(ex.Message + " public AddOperationForm(Int16 operationGroupId_, Int16 parameterId_)", ex);
            }
        }

        public AddOperationForm(Session_operation_list o)
        {
            InitializeComponent();
            this.o = o;
                        
            param = new ParametersManager().getParameter(o.Parameter_id);
            parameterIdTxt.Text = param.Name;
            valueTxt.Text = o.Value.ToString();

            typeOperationCombo.Items.Clear();
            typeOperationCombo.Items.Add("Читання");            
            if (param.Access == (int)AccessType.READ_WRITE) typeOperationCombo.Items.Add("Запис");

            typeOperationCombo.SelectedIndex = (short)o.Type;
            isNotArragment.Checked = (Boolean)o.Is_not_arragment;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {               
                o.Value = Convert.ToInt16(valueTxt.Text);
                o.Type = typeOperationCombo.SelectedIndex;
                o.Is_not_arragment = isNotArragment.Checked;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }

        private void typeOperationCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeOperationCombo.SelectedIndex == (int)AccessType.READ)
            {
                valueTxt.Enabled = false;
                valueTxt.Text = "0";
            } else if (typeOperationCombo.SelectedIndex == (int)AccessType.READ_WRITE)
            {
                valueTxt.Enabled = true;
            }
        }

        private void AddOperationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
