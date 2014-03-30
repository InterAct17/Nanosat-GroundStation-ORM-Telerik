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
    public partial class SessionEditForm : Form
    {
        public Operation_group operationGroup;        
        public static readonly ILog log = LogManager.GetLogger(typeof(SessionEditForm));    

        public SessionEditForm(Operation_group og)
        {
            InitializeComponent();            
            if (og != null)
            {
                this.operationGroup = og;
                idTxt.ReadOnly = true;
                this.Text = "Редагування: " + og.Name;
                idTxt.Text = og.Id.ToString();
                nameTxt.Text = og.Name;
            }
            else if (og == null)
            {
                operationGroup = new Operation_group(); 
                idTxt.ReadOnly = true;
                this.Text = "Додати групу сеансу зв'яку";
                idTxt.Text = "0";
                nameTxt.Text = "Назва групи";
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                operationGroup.Id = Convert.ToInt16(idTxt.Text);
                operationGroup.Name = nameTxt.Text;
                operationGroup.Created_at = DateTime.Now;
               
                DialogResult = System.Windows.Forms.DialogResult.OK;                
            }
            catch (Exception ex) {
                log.Error(ex.Message, ex);
            }
        }
    }
}
