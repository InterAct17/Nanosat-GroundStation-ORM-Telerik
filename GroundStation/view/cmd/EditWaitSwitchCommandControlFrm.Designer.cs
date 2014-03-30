namespace GroundStation.view
{
    partial class EditWaitSwitchCommandControlFrm
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nextSessionOpComboBox = new System.Windows.Forms.ComboBox();
            this.hotKeyTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Image = global::GroundStation.Properties.Resources.accept;
            this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.Location = new System.Drawing.Point(437, 60);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Гаряча клавіша:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Строка переходу:";
            // 
            // nextSessionOpComboBox
            // 
            this.nextSessionOpComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nextSessionOpComboBox.FormattingEnabled = true;
            this.nextSessionOpComboBox.Location = new System.Drawing.Point(113, 32);
            this.nextSessionOpComboBox.Name = "nextSessionOpComboBox";
            this.nextSessionOpComboBox.Size = new System.Drawing.Size(399, 21);
            this.nextSessionOpComboBox.TabIndex = 4;
            // 
            // hotKeyTxt
            // 
            this.hotKeyTxt.Location = new System.Drawing.Point(113, 6);
            this.hotKeyTxt.Name = "hotKeyTxt";
            this.hotKeyTxt.ReadOnly = true;
            this.hotKeyTxt.Size = new System.Drawing.Size(399, 20);
            this.hotKeyTxt.TabIndex = 5;
            this.hotKeyTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hotKeyTxt_KeyDown);           
            // 
            // EditWaitSwitchCommandControlFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 95);
            this.Controls.Add(this.hotKeyTxt);
            this.Controls.Add(this.nextSessionOpComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditWaitSwitchCommandControlFrm";
            this.Text = "Редагувати строку переходу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox nextSessionOpComboBox;
        private System.Windows.Forms.TextBox hotKeyTxt;
    }
}