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
    public partial class ParameterEditForm : Form
    {
        public Parameter p = new Parameter();
        public static readonly ILog log = LogManager.GetLogger(typeof(ParameterEditForm));

        public ParameterEditForm(int devId)
        {
            InitializeComponent();
            initComboBox();
            p.Device_id = devId;
        }

        public ParameterEditForm(Parameter _p)
        {
            InitializeComponent();
            initComboBox();
            this.p = _p;
            initFields();
        }

        public void initFields()
        {
            try
            {
                idTxt.Text = p.Id.ToString();
                accessCombo.SelectedIndex = (int)p.Access;
                nameTxt.Text = p.Name;
                register_address_startTxt.Text = p.Register_address_start.ToString();
                modBusTypesComboBox.SelectedIndex = (int)p.Modbus_type_id;
                aliasGroupComboBox.SelectedIndex = (int)p.Alias_group_id;
                calculation_formulaCombo.SelectedIndex = (int)p.Calculation_formula_id;
                minTxt.Text = p.Min_value.ToString();
                maxTxt.Text = p.Max_value.ToString();
                descriptionRichTxt.Text = p.Description;
                lowParttrackBar.Value = (int)p.Start_bit;
                hiParttrackBar.Value = (int)p.End_bit;

                if (modBusTypesComboBox.SelectedIndex == 8)
                    bitsRangeGroupBox.Visible = true;
                else
                    bitsRangeGroupBox.Visible = false;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                p.Access = (short)accessCombo.SelectedIndex;
                p.Name = nameTxt.Text;
                p.Register_address_start = Convert.ToInt16(register_address_startTxt.Text);
                p.Modbus_type_id = modBusTypesComboBox.SelectedIndex;
                p.Calculation_formula_id = calculation_formulaCombo.SelectedIndex;
                p.Description = descriptionRichTxt.Text;
                p.Min_value = Convert.ToDouble(minTxt.Text);
                p.Max_value = Convert.ToDouble(maxTxt.Text);
                p.Alias_group_id = aliasGroupComboBox.SelectedIndex;
                p.Start_bit = (short)lowParttrackBar.Value;
                p.End_bit = (short)hiParttrackBar.Value;

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }

        private void initComboBox()
        {
            accessCombo.Items.Add("Читання");
            accessCombo.Items.Add("Запис / Читання");
            accessCombo.SelectedIndex = 0;

            modBusTypesComboBox.DisplayMember = "name";
            modBusTypesComboBox.ValueMember = "id";
            modBusTypesComboBox.DataSource = (new ModBusTypesManager()).getModBusTypes();

            aliasGroupComboBox.DisplayMember = "name";
            aliasGroupComboBox.ValueMember = "id";
            aliasGroupComboBox.DataSource = (new AliasManager()).getAliasGroup();
        }
        private void ParameterEditForm_Load(object sender, EventArgs e)
        {
            idTxt.Enabled = false;
        }

        private void modBusTypesComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (modBusTypesComboBox.Text.Replace(" ", "").ToLower())
            {
                case "int16": minTxt.Text = "-32768"; maxTxt.Text = "32767"; break;
                case "int32": minTxt.Text = "-2147483648"; maxTxt.Text = "2147483647"; break;
                case "int64": minTxt.Text = "-9223372036854775808"; maxTxt.Text = "9223372036854775807"; break;

                case "uint16": minTxt.Text = "0"; maxTxt.Text = "65535"; break;
                case "uint32": minTxt.Text = "0"; maxTxt.Text = "4294967295"; break;
                case "uint64": minTxt.Text = "0"; maxTxt.Text = "18446744073709551615"; break;

                case "float": minTxt.Text = float.MinValue.ToString(); maxTxt.Text = float.MaxValue.ToString(); break;
                case "double": minTxt.Text = Double.MinValue.ToString(); maxTxt.Text = Double.MaxValue.ToString(); break;

                default: minTxt.Text = "-1"; maxTxt.Text = "1"; break;
            }

            if (modBusTypesComboBox.SelectedIndex == 8)
                bitsRangeGroupBox.Visible = true;
            else
                bitsRangeGroupBox.Visible = false;

        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {
            if (idTxt.Text.Length < 1)
            {
                descriptionRichTxt.Text = nameTxt.Text;
            }
        }

        private void aliasGroupBtn_Click(object sender, EventArgs e)
        {
            (new AliasForm()).ShowDialog();
        }

        private void lowParttrackBar_ValueChanged(object sender, EventArgs e)
        {
            bitRangeTxt.Text = lowParttrackBar.Value + " - " + hiParttrackBar.Value;
            hiParttrackBar.Minimum = lowParttrackBar.Value + 1;
        }

        private void hiParttrackBar_ValueChanged(object sender, EventArgs e)
        {
            bitRangeTxt.Text = lowParttrackBar.Value + " - " + hiParttrackBar.Value;
            lowParttrackBar.Maximum = hiParttrackBar.Value - 1;
        }

    }
}
