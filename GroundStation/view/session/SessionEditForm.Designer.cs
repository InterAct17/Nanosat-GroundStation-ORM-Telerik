﻿namespace GroundStation.view
{
    partial class SessionEditForm
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
            this.SaveBtn = new System.Windows.Forms.Button();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.Image = global::GroundStation.Properties.Resources.accept;
            this.SaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveBtn.Location = new System.Drawing.Point(369, 64);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Зберегти";
            this.SaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(97, 38);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(347, 20);
            this.nameTxt.TabIndex = 2;
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(97, 12);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(347, 20);
            this.idTxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ідентифікатор:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Назва:";
            // 
            // SessionEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 96);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.SaveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SessionEditForm";
            this.Text = "OperationGroupEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}