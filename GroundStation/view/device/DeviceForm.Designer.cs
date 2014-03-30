namespace GroundStation.view
{
    partial class DeviceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.deviceGrid = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.editBtnMenu = new System.Windows.Forms.ToolStripButton();
            this.addBtnMenu = new System.Windows.Forms.ToolStripButton();
            this.delBtnMenu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.modBusMapEditBtnMenu = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.deviceGrid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deviceGrid
            // 
            this.deviceGrid.AllowUserToAddRows = false;
            this.deviceGrid.AllowUserToDeleteRows = false;
            this.deviceGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deviceGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.deviceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.deviceGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.deviceGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceGrid.Location = new System.Drawing.Point(0, 25);
            this.deviceGrid.MultiSelect = false;
            this.deviceGrid.Name = "deviceGrid";
            this.deviceGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deviceGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.deviceGrid.RowHeadersVisible = false;
            this.deviceGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.deviceGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deviceGrid.Size = new System.Drawing.Size(793, 281);
            this.deviceGrid.TabIndex = 0;            
            this.deviceGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deviceGrid_CellDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editBtnMenu,
            this.addBtnMenu,
            this.delBtnMenu,
            this.toolStripSeparator1,
            this.modBusMapEditBtnMenu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(793, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // editBtnMenu
            // 
            this.editBtnMenu.Image = global::GroundStation.Properties.Resources.cog;
            this.editBtnMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editBtnMenu.Name = "editBtnMenu";
            this.editBtnMenu.Size = new System.Drawing.Size(130, 22);
            this.editBtnMenu.Text = "Редагувати систему";
            this.editBtnMenu.Click += new System.EventHandler(this.editBtnMenu_Click);
            // 
            // addBtnMenu
            // 
            this.addBtnMenu.Image = global::GroundStation.Properties.Resources.add;
            this.addBtnMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addBtnMenu.Name = "addBtnMenu";
            this.addBtnMenu.Size = new System.Drawing.Size(109, 22);
            this.addBtnMenu.Text = "Додати систему";
            this.addBtnMenu.Click += new System.EventHandler(this.addBtnMenu_Click);
            // 
            // delBtnMenu
            // 
            this.delBtnMenu.Image = global::GroundStation.Properties.Resources.delete;
            this.delBtnMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delBtnMenu.Name = "delBtnMenu";
            this.delBtnMenu.Size = new System.Drawing.Size(119, 22);
            this.delBtnMenu.Text = "Видалити систему";
            this.delBtnMenu.Click += new System.EventHandler(this.delBtnMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // modBusMapEditBtnMenu
            // 
            this.modBusMapEditBtnMenu.Image = global::GroundStation.Properties.Resources.page_paintbrush;
            this.modBusMapEditBtnMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.modBusMapEditBtnMenu.Name = "modBusMapEditBtnMenu";
            this.modBusMapEditBtnMenu.Size = new System.Drawing.Size(187, 22);
            this.modBusMapEditBtnMenu.Text = "Редагувати параметри системи";
            this.modBusMapEditBtnMenu.Click += new System.EventHandler(this.modBusMapEditBtnMenu_Click);
            // 
            // DeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 306);
            this.Controls.Add(this.deviceGrid);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DeviceForm";
            this.Text = "Системи наносупутника PolyITAN 1";
            this.Load += new System.EventHandler(this.DeviceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deviceGrid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView deviceGrid;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton editBtnMenu;
        private System.Windows.Forms.ToolStripButton addBtnMenu;
        private System.Windows.Forms.ToolStripButton delBtnMenu;
        private System.Windows.Forms.ToolStripButton modBusMapEditBtnMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}