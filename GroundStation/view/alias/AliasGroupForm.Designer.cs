namespace GroundStation.view
{
    partial class AliasForm
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
            this.editBtnMenu = new System.Windows.Forms.ToolStripButton();
            this.addBtnMenu = new System.Windows.Forms.ToolStripButton();
            this.delBtnMenu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.modBusMapEditBtnMenu = new System.Windows.Forms.ToolStripButton();
            this.aliasGroupFlexGrid = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aliasGroupFlexGrid)).BeginInit();
            this.SuspendLayout();
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
            // modBusMapEditBtnMenu
            // 
            this.modBusMapEditBtnMenu.Image = global::GroundStation.Properties.Resources.page_paintbrush;
            this.modBusMapEditBtnMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.modBusMapEditBtnMenu.Name = "modBusMapEditBtnMenu";
            this.modBusMapEditBtnMenu.Size = new System.Drawing.Size(178, 22);
            this.modBusMapEditBtnMenu.Text = "Редагувати псевдоніми групи";
            this.modBusMapEditBtnMenu.Click += new System.EventHandler(this.valueAliasEditBtnMenu_Click);
            // 
            // aliasGroupFlexGrid
            // 
            this.aliasGroupFlexGrid.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.aliasGroupFlexGrid.AllowEditing = false;
            this.aliasGroupFlexGrid.AllowFiltering = true;
            this.aliasGroupFlexGrid.AllowMergingFixed = C1.Win.C1FlexGrid.AllowMergingEnum.None;
            this.aliasGroupFlexGrid.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.aliasGroupFlexGrid.AutoResize = true;
            this.aliasGroupFlexGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
            this.aliasGroupFlexGrid.ColumnInfo = "0,0,0,0,0,85,Columns:";
            this.aliasGroupFlexGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aliasGroupFlexGrid.ExtendLastCol = true;
            this.aliasGroupFlexGrid.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None;
            this.aliasGroupFlexGrid.Location = new System.Drawing.Point(0, 25);
            this.aliasGroupFlexGrid.Name = "aliasGroupFlexGrid";
            this.aliasGroupFlexGrid.Rows.Count = 1;
            this.aliasGroupFlexGrid.Rows.DefaultSize = 17;
            this.aliasGroupFlexGrid.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible;
            this.aliasGroupFlexGrid.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.aliasGroupFlexGrid.ShowSort = false;
            this.aliasGroupFlexGrid.Size = new System.Drawing.Size(793, 281);
            this.aliasGroupFlexGrid.TabIndex = 7;
            // 
            // AliasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 306);
            this.Controls.Add(this.aliasGroupFlexGrid);
            this.Controls.Add(this.toolStrip1);
            this.Name = "AliasForm";
            this.Text = "Alias groups";
            this.Load += new System.EventHandler(this.DeviceForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aliasGroupFlexGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton editBtnMenu;
        private System.Windows.Forms.ToolStripButton addBtnMenu;
        private System.Windows.Forms.ToolStripButton delBtnMenu;
        private System.Windows.Forms.ToolStripButton modBusMapEditBtnMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private C1.Win.C1FlexGrid.C1FlexGrid aliasGroupFlexGrid;
    }
}