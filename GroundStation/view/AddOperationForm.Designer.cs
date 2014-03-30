namespace GroundStation.view
{
    partial class AddOperationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valueTxt = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.parameterIdTxt = new System.Windows.Forms.TextBox();
            this.typeOperationCombo = new System.Windows.Forms.ComboBox();
            this.isNotArragment = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Значення:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Тип операції:";
            // 
            // valueTxt
            // 
            this.valueTxt.Location = new System.Drawing.Point(92, 64);
            this.valueTxt.Name = "valueTxt";
            this.valueTxt.Size = new System.Drawing.Size(347, 20);
            this.valueTxt.TabIndex = 11;
            this.valueTxt.Text = "0";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Image = global::GroundStation.Properties.Resources.accept;
            this.SaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveBtn.Location = new System.Drawing.Point(364, 111);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 9;
            this.SaveBtn.Text = "Зберегти";
            this.SaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Параметр:";
            // 
            // parameterIdTxt
            // 
            this.parameterIdTxt.Enabled = false;
            this.parameterIdTxt.Location = new System.Drawing.Point(92, 12);
            this.parameterIdTxt.Name = "parameterIdTxt";
            this.parameterIdTxt.Size = new System.Drawing.Size(347, 20);
            this.parameterIdTxt.TabIndex = 13;
            // 
            // typeOperationCombo
            // 
            this.typeOperationCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeOperationCombo.FormattingEnabled = true;
            this.typeOperationCombo.Items.AddRange(new object[] {
            "Читаня",
            "Запис"});
            this.typeOperationCombo.Location = new System.Drawing.Point(92, 38);
            this.typeOperationCombo.Name = "typeOperationCombo";
            this.typeOperationCombo.Size = new System.Drawing.Size(347, 21);
            this.typeOperationCombo.TabIndex = 17;
            this.typeOperationCombo.SelectedIndexChanged += new System.EventHandler(this.typeOperationCombo_SelectedIndexChanged);
            // 
            // isNotArragment
            // 
            this.isNotArragment.AutoSize = true;
            this.isNotArragment.Location = new System.Drawing.Point(92, 90);
            this.isNotArragment.Name = "isNotArragment";
            this.isNotArragment.Size = new System.Drawing.Size(109, 17);
            this.isNotArragment.TabIndex = 18;
            this.isNotArragment.Text = "Не компонувати";
            this.isNotArragment.UseVisualStyleBackColor = true;
            // 
            // AddOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 146);
            this.Controls.Add(this.isNotArragment);
            this.Controls.Add(this.typeOperationCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parameterIdTxt);
            this.Controls.Add(this.valueTxt);
            this.Controls.Add(this.SaveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOperationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Додати / Редагувати операцію в сеанс з\'вязку";
            this.Load += new System.EventHandler(this.AddOperationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valueTxt;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox parameterIdTxt;
        private System.Windows.Forms.ComboBox typeOperationCombo;
        private System.Windows.Forms.CheckBox isNotArragment;

    }
}