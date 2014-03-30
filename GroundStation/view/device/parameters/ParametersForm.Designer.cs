namespace GroundStation.view
{
    partial class ParametersForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addParamBtn = new System.Windows.Forms.ToolStripButton();
            this.delParamBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editParamBtn = new System.Windows.Forms.ToolStripButton();
            this.parametersGrid = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parametersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addParamBtn,
            this.delParamBtn,
            this.toolStripSeparator1,
            this.editParamBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(789, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addParamBtn
            // 
            this.addParamBtn.Image = global::GroundStation.Properties.Resources.add;
            this.addParamBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addParamBtn.Name = "addParamBtn";
            this.addParamBtn.Size = new System.Drawing.Size(66, 22);
            this.addParamBtn.Text = "Додати";
            this.addParamBtn.Click += new System.EventHandler(this.addParamBtn_Click_1);
            // 
            // delParamBtn
            // 
            this.delParamBtn.Image = global::GroundStation.Properties.Resources.delete;
            this.delParamBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delParamBtn.Name = "delParamBtn";
            this.delParamBtn.Size = new System.Drawing.Size(76, 22);
            this.delParamBtn.Text = "Видалити";
            this.delParamBtn.Click += new System.EventHandler(this.delParamBtn_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // editParamBtn
            // 
            this.editParamBtn.Image = global::GroundStation.Properties.Resources.cog;
            this.editParamBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editParamBtn.Name = "editParamBtn";
            this.editParamBtn.Size = new System.Drawing.Size(144, 22);
            this.editParamBtn.Text = "Редагувати параметер";
            this.editParamBtn.Click += new System.EventHandler(this.editParamBtn_Click);
            // 
            // parametersGrid
            // 
            this.parametersGrid.AllowUserToAddRows = false;
            this.parametersGrid.AllowUserToDeleteRows = false;
            this.parametersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.parametersGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.parametersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parametersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parametersGrid.Location = new System.Drawing.Point(0, 25);
            this.parametersGrid.MultiSelect = false;
            this.parametersGrid.Name = "parametersGrid";
            this.parametersGrid.ReadOnly = true;
            this.parametersGrid.RowHeadersVisible = false;
            this.parametersGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.parametersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.parametersGrid.Size = new System.Drawing.Size(789, 248);
            this.parametersGrid.TabIndex = 0;
            this.parametersGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.parametersGrid_CellDoubleClick);
            // 
            // ParametersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 273);
            this.Controls.Add(this.parametersGrid);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ParametersForm";
            this.Text = "Параметри системи: ";
            this.Load += new System.EventHandler(this.ParametersForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parametersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView parametersGrid;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton editParamBtn;
        private System.Windows.Forms.ToolStripButton addParamBtn;
        private System.Windows.Forms.ToolStripButton delParamBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}