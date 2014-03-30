namespace GroundStation.view
{
    partial class ParameterEditForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.register_address_startTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.accessCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.calculation_formulaCombo = new System.Windows.Forms.ComboBox();
            this.modBusTypesComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maxTxt = new System.Windows.Forms.TextBox();
            this.minTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.descriptionRichTxt = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.aliasGroupComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.aliasGroupBtn = new System.Windows.Forms.Button();
            this.bitsRangeGroupBox = new System.Windows.Forms.GroupBox();
            this.lowParttrackBar = new System.Windows.Forms.TrackBar();
            this.hiParttrackBar = new System.Windows.Forms.TrackBar();
            this.bitRangeTxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.bitsRangeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lowParttrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiParttrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Адреса:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Формула:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ідентифікатор:";
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(111, 10);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(347, 20);
            this.idTxt.TabIndex = 13;
            // 
            // register_address_startTxt
            // 
            this.register_address_startTxt.Location = new System.Drawing.Point(111, 88);
            this.register_address_startTxt.Name = "register_address_startTxt";
            this.register_address_startTxt.Size = new System.Drawing.Size(347, 20);
            this.register_address_startTxt.TabIndex = 12;
            this.register_address_startTxt.Text = "0";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(111, 62);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(347, 20);
            this.nameTxt.TabIndex = 11;
            this.nameTxt.Text = "параметр";
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(383, 437);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 9;
            this.SaveBtn.Text = "Зберегти";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Тип:";
            // 
            // accessCombo
            // 
            this.accessCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accessCombo.FormattingEnabled = true;
            this.accessCombo.Location = new System.Drawing.Point(111, 113);
            this.accessCombo.Name = "accessCombo";
            this.accessCombo.Size = new System.Drawing.Size(347, 21);
            this.accessCombo.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Тип доступу:";
            // 
            // calculation_formulaCombo
            // 
            this.calculation_formulaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.calculation_formulaCombo.FormattingEnabled = true;
            this.calculation_formulaCombo.Location = new System.Drawing.Point(111, 36);
            this.calculation_formulaCombo.Name = "calculation_formulaCombo";
            this.calculation_formulaCombo.Size = new System.Drawing.Size(347, 21);
            this.calculation_formulaCombo.TabIndex = 22;
            // 
            // modBusTypesComboBox
            // 
            this.modBusTypesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modBusTypesComboBox.FormattingEnabled = true;
            this.modBusTypesComboBox.Location = new System.Drawing.Point(111, 167);
            this.modBusTypesComboBox.Name = "modBusTypesComboBox";
            this.modBusTypesComboBox.Size = new System.Drawing.Size(347, 21);
            this.modBusTypesComboBox.TabIndex = 23;
            this.modBusTypesComboBox.SelectedValueChanged += new System.EventHandler(this.modBusTypesComboBox_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maxTxt);
            this.groupBox1.Controls.Add(this.minTxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(27, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 84);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Діапазон значень параметру";
            // 
            // maxTxt
            // 
            this.maxTxt.Location = new System.Drawing.Point(46, 48);
            this.maxTxt.Name = "maxTxt";
            this.maxTxt.Size = new System.Drawing.Size(379, 20);
            this.maxTxt.TabIndex = 26;
            // 
            // minTxt
            // 
            this.minTxt.Location = new System.Drawing.Point(46, 19);
            this.minTxt.Name = "minTxt";
            this.minTxt.Size = new System.Drawing.Size(379, 20);
            this.minTxt.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "MAX:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "MIN:";
            // 
            // descriptionRichTxt
            // 
            this.descriptionRichTxt.Location = new System.Drawing.Point(111, 356);
            this.descriptionRichTxt.Name = "descriptionRichTxt";
            this.descriptionRichTxt.Size = new System.Drawing.Size(347, 75);
            this.descriptionRichTxt.TabIndex = 25;
            this.descriptionRichTxt.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Назва:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Опис параметру:";
            // 
            // aliasGroupComboBox
            // 
            this.aliasGroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aliasGroupComboBox.FormattingEnabled = true;
            this.aliasGroupComboBox.Location = new System.Drawing.Point(111, 140);
            this.aliasGroupComboBox.Name = "aliasGroupComboBox";
            this.aliasGroupComboBox.Size = new System.Drawing.Size(347, 21);
            this.aliasGroupComboBox.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Alias group:";
            // 
            // aliasGroupBtn
            // 
            this.aliasGroupBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.aliasGroupBtn.Image = global::GroundStation.Properties.Resources.cog;
            this.aliasGroupBtn.Location = new System.Drawing.Point(9, 140);
            this.aliasGroupBtn.Margin = new System.Windows.Forms.Padding(0);
            this.aliasGroupBtn.Name = "aliasGroupBtn";
            this.aliasGroupBtn.Size = new System.Drawing.Size(31, 23);
            this.aliasGroupBtn.TabIndex = 29;
            this.aliasGroupBtn.UseVisualStyleBackColor = true;
            this.aliasGroupBtn.Click += new System.EventHandler(this.aliasGroupBtn_Click);
            // 
            // bitsRangeGroupBox
            // 
            this.bitsRangeGroupBox.Controls.Add(this.bitRangeTxt);
            this.bitsRangeGroupBox.Controls.Add(this.hiParttrackBar);
            this.bitsRangeGroupBox.Controls.Add(this.lowParttrackBar);
            this.bitsRangeGroupBox.Location = new System.Drawing.Point(27, 194);
            this.bitsRangeGroupBox.Name = "bitsRangeGroupBox";
            this.bitsRangeGroupBox.Size = new System.Drawing.Size(431, 66);
            this.bitsRangeGroupBox.TabIndex = 31;
            this.bitsRangeGroupBox.TabStop = false;
            this.bitsRangeGroupBox.Text = "Біти регістру";
            this.bitsRangeGroupBox.Visible = false;
            // 
            // lowParttrackBar
            // 
            this.lowParttrackBar.Location = new System.Drawing.Point(84, 19);
            this.lowParttrackBar.Maximum = 7;
            this.lowParttrackBar.Name = "lowParttrackBar";
            this.lowParttrackBar.Size = new System.Drawing.Size(170, 42);
            this.lowParttrackBar.TabIndex = 0;
            this.lowParttrackBar.ValueChanged += new System.EventHandler(this.lowParttrackBar_ValueChanged);
            // 
            // hiParttrackBar
            // 
            this.hiParttrackBar.Location = new System.Drawing.Point(255, 19);
            this.hiParttrackBar.Maximum = 15;
            this.hiParttrackBar.Minimum = 1;
            this.hiParttrackBar.Name = "hiParttrackBar";
            this.hiParttrackBar.Size = new System.Drawing.Size(170, 42);
            this.hiParttrackBar.TabIndex = 1;
            this.hiParttrackBar.Value = 15;
            this.hiParttrackBar.ValueChanged += new System.EventHandler(this.hiParttrackBar_ValueChanged);
            // 
            // bitRangeTxt
            // 
            this.bitRangeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bitRangeTxt.Location = new System.Drawing.Point(14, 19);
            this.bitRangeTxt.Name = "bitRangeTxt";
            this.bitRangeTxt.ReadOnly = true;
            this.bitRangeTxt.Size = new System.Drawing.Size(64, 21);
            this.bitRangeTxt.TabIndex = 2;
            this.bitRangeTxt.Text = "0 - 15";
            this.bitRangeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ParameterEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 467);
            this.Controls.Add(this.bitsRangeGroupBox);
            this.Controls.Add(this.aliasGroupBtn);
            this.Controls.Add(this.aliasGroupComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.descriptionRichTxt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.modBusTypesComboBox);
            this.Controls.Add(this.calculation_formulaCombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.accessCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.register_address_startTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.SaveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ParameterEditForm";
            this.Text = "Редагування параметру";
            this.Load += new System.EventHandler(this.ParameterEditForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.bitsRangeGroupBox.ResumeLayout(false);
            this.bitsRangeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lowParttrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiParttrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.TextBox register_address_startTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox accessCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox calculation_formulaCombo;
        private System.Windows.Forms.ComboBox modBusTypesComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox maxTxt;
        private System.Windows.Forms.TextBox minTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox descriptionRichTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox aliasGroupComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button aliasGroupBtn;
        private System.Windows.Forms.GroupBox bitsRangeGroupBox;
        private System.Windows.Forms.TextBox bitRangeTxt;
        private System.Windows.Forms.TrackBar hiParttrackBar;
        private System.Windows.Forms.TrackBar lowParttrackBar;
    }
}