namespace GroundStation.view
{
    partial class ConnectionPropertyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionPropertyForm));
            this.ComboBoxPortName = new System.Windows.Forms.ComboBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxBoudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtReadTimeout = new System.Windows.Forms.MaskedTextBox();
            this.TxtWriteTimeout = new System.Windows.Forms.MaskedTextBox();
            this.TxtBufferReadSize = new System.Windows.Forms.MaskedTextBox();
            this.TxtBufferWriteSize = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBoxPortName
            // 
            this.ComboBoxPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPortName.FormattingEnabled = true;
            resources.ApplyResources(this.ComboBoxPortName, "ComboBoxPortName");
            this.ComboBoxPortName.Name = "ComboBoxPortName";
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.BtnOK, "BtnOK");
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ComboBoxBoudRate
            // 
            this.ComboBoxBoudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxBoudRate.FormattingEnabled = true;
            resources.ApplyResources(this.ComboBoxBoudRate, "ComboBoxBoudRate");
            this.ComboBoxBoudRate.Name = "ComboBoxBoudRate";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // TxtReadTimeout
            // 
            resources.ApplyResources(this.TxtReadTimeout, "TxtReadTimeout");
            this.TxtReadTimeout.Name = "TxtReadTimeout";
            // 
            // TxtWriteTimeout
            // 
            resources.ApplyResources(this.TxtWriteTimeout, "TxtWriteTimeout");
            this.TxtWriteTimeout.Name = "TxtWriteTimeout";
            this.TxtWriteTimeout.ValidatingType = typeof(int);
            // 
            // TxtBufferReadSize
            // 
            resources.ApplyResources(this.TxtBufferReadSize, "TxtBufferReadSize");
            this.TxtBufferReadSize.Name = "TxtBufferReadSize";
            this.TxtBufferReadSize.ValidatingType = typeof(int);
            // 
            // TxtBufferWriteSize
            // 
            resources.ApplyResources(this.TxtBufferWriteSize, "TxtBufferWriteSize");
            this.TxtBufferWriteSize.Name = "TxtBufferWriteSize";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtWriteTimeout);
            this.groupBox1.Controls.Add(this.TxtBufferWriteSize);
            this.groupBox1.Controls.Add(this.ComboBoxPortName);
            this.groupBox1.Controls.Add(this.TxtBufferReadSize);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtReadTimeout);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ComboBoxBoudRate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // ConnectionPropertyForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionPropertyForm";
            this.Shown += new System.EventHandler(this.FrmProperty_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxPortName;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxBoudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox TxtReadTimeout;
        private System.Windows.Forms.MaskedTextBox TxtWriteTimeout;
        private System.Windows.Forms.MaskedTextBox TxtBufferReadSize;
        private System.Windows.Forms.MaskedTextBox TxtBufferWriteSize;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}