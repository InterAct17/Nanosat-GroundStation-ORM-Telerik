namespace GroundStation.view
{
    partial class SessionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SessionForm));
            this.operationGroupGrid = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.editBtnMenu = new System.Windows.Forms.ToolStripButton();
            this.addBtnMenu = new System.Windows.Forms.ToolStripButton();
            this.copyBtnMenu = new System.Windows.Forms.ToolStripButton();
            this.delBtnMenu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loadBtnMenu = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.operationGroupGrid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // operationGroupGrid
            // 
            this.operationGroupGrid.AllowUserToAddRows = false;
            this.operationGroupGrid.AllowUserToDeleteRows = false;
            this.operationGroupGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.operationGroupGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.operationGroupGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.operationGroupGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.operationGroupGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operationGroupGrid.Location = new System.Drawing.Point(0, 25);
            this.operationGroupGrid.MultiSelect = false;
            this.operationGroupGrid.Name = "operationGroupGrid";
            this.operationGroupGrid.ReadOnly = true;
            this.operationGroupGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.operationGroupGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.operationGroupGrid.RowHeadersVisible = false;
            this.operationGroupGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.operationGroupGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.operationGroupGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.operationGroupGrid.Size = new System.Drawing.Size(793, 281);
            this.operationGroupGrid.TabIndex = 0;
            this.operationGroupGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.operationGroupGrid_CellDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editBtnMenu,
            this.addBtnMenu,
            this.copyBtnMenu,
            this.delBtnMenu,
            this.toolStripSeparator1,
            this.loadBtnMenu});
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
            this.editBtnMenu.Size = new System.Drawing.Size(87, 22);
            this.editBtnMenu.Text = "Редагувати";
            this.editBtnMenu.Click += new System.EventHandler(this.editBtnMenu_Click);
            // 
            // addBtnMenu
            // 
            this.addBtnMenu.Image = global::GroundStation.Properties.Resources.add;
            this.addBtnMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addBtnMenu.Name = "addBtnMenu";
            this.addBtnMenu.Size = new System.Drawing.Size(66, 22);
            this.addBtnMenu.Text = "Додати";
            this.addBtnMenu.Click += new System.EventHandler(this.addBtnMenu_Click);
            // 
            // copyBtnMenu
            // 
            this.copyBtnMenu.Image = global::GroundStation.Properties.Resources.page_paintbrush;
            this.copyBtnMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyBtnMenu.Name = "copyBtnMenu";
            this.copyBtnMenu.Size = new System.Drawing.Size(81, 22);
            this.copyBtnMenu.Text = "Копіювати";
            this.copyBtnMenu.Click += new System.EventHandler(this.modBusMapEditBtnMenu_Click);
            // 
            // delBtnMenu
            // 
            this.delBtnMenu.Image = global::GroundStation.Properties.Resources.delete;
            this.delBtnMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delBtnMenu.Name = "delBtnMenu";
            this.delBtnMenu.Size = new System.Drawing.Size(76, 22);
            this.delBtnMenu.Text = "Видалити";
            this.delBtnMenu.Click += new System.EventHandler(this.delBtnMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // loadBtnMenu
            // 
            this.loadBtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("loadBtnMenu.Image")));
            this.loadBtnMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadBtnMenu.Name = "loadBtnMenu";
            this.loadBtnMenu.Size = new System.Drawing.Size(95, 22);
            this.loadBtnMenu.Text = "Завантажити";
            this.loadBtnMenu.Click += new System.EventHandler(this.loadBtnMenu_Click);
            // 
            // SessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 306);
            this.Controls.Add(this.operationGroupGrid);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SessionForm";
            this.Text = "Сеанси зв\'язку наносупутника PolyITAN 1";
            this.Load += new System.EventHandler(this.DeviceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.operationGroupGrid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView operationGroupGrid;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton editBtnMenu;
        private System.Windows.Forms.ToolStripButton addBtnMenu;
        private System.Windows.Forms.ToolStripButton delBtnMenu;
        private System.Windows.Forms.ToolStripButton copyBtnMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton loadBtnMenu;
    }
}