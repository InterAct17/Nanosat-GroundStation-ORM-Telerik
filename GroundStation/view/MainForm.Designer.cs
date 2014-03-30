namespace GroundStation.view
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.systemGroupBox = new System.Windows.Forms.GroupBox();
            this.devicesComboBox = new System.Windows.Forms.ComboBox();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.debugModeBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionPropertyForm = new System.Windows.Forms.ToolStripMenuItem();
            this.зєднанняЗБазоюДаннихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isRecordTelemetryBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devicesBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.aliasBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.formulsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangementButton = new System.Windows.Forms.ToolStripMenuItem();
            this.playSessionBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionGroupBox = new System.Windows.Forms.GroupBox();
            this.sessionFlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.sessionGridContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.editSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиСтрокуКеруванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.sysParamAddBtnTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sysParamTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.paramGroupBox = new System.Windows.Forms.GroupBox();
            this.parameterFlexGrid = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.sessionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sessionToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.upBtn = new System.Windows.Forms.ToolStripButton();
            this.downBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnShowSessinons = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.sessionEdittoolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.mainHorizontalSplitContainer = new System.Windows.Forms.SplitContainer();
            this.arrangemenGroupBox = new System.Windows.Forms.GroupBox();
            this.sessionArrangemendataFlexGrid = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.log4netRichTextBox = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.isDebugModeBtn = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.transferProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.transferInfoLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.parameterGridMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.додатиПараметриВСеансЗвязкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemGroupBox.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.sessionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionFlexGrid1)).BeginInit();
            this.sessionGridContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.sysParamAddBtnTableLayoutPanel.SuspendLayout();
            this.sysParamTableLayoutPanel.SuspendLayout();
            this.paramGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parameterFlexGrid)).BeginInit();
            this.sessionTableLayoutPanel.SuspendLayout();
            this.sessionToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainHorizontalSplitContainer)).BeginInit();
            this.mainHorizontalSplitContainer.Panel1.SuspendLayout();
            this.mainHorizontalSplitContainer.Panel2.SuspendLayout();
            this.mainHorizontalSplitContainer.SuspendLayout();
            this.arrangemenGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionArrangemendataFlexGrid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.parameterGridMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // systemGroupBox
            // 
            this.systemGroupBox.Controls.Add(this.devicesComboBox);
            this.systemGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.systemGroupBox.Location = new System.Drawing.Point(3, 3);
            this.systemGroupBox.Name = "systemGroupBox";
            this.systemGroupBox.Size = new System.Drawing.Size(250, 49);
            this.systemGroupBox.TabIndex = 3;
            this.systemGroupBox.TabStop = false;
            this.systemGroupBox.Text = "Система:";
            // 
            // devicesComboBox
            // 
            this.devicesComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devicesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.devicesComboBox.FormattingEnabled = true;
            this.devicesComboBox.Location = new System.Drawing.Point(3, 16);
            this.devicesComboBox.Name = "devicesComboBox";
            this.devicesComboBox.Size = new System.Drawing.Size(244, 21);
            this.devicesComboBox.TabIndex = 0;
            this.devicesComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debugModeBtn,
            this.редагуватиToolStripMenuItem,
            this.arrangementButton,
            this.playSessionBtn});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(967, 24);
            this.mainMenu.TabIndex = 4;
            this.mainMenu.Text = "menuStrip1";
            // 
            // debugModeBtn
            // 
            this.debugModeBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionPropertyForm,
            this.зєднанняЗБазоюДаннихToolStripMenuItem,
            this.isRecordTelemetryBtn});
            this.debugModeBtn.Name = "debugModeBtn";
            this.debugModeBtn.Size = new System.Drawing.Size(94, 20);
            this.debugModeBtn.Text = "Налаштування";
            // 
            // connectionPropertyForm
            // 
            this.connectionPropertyForm.Name = "connectionPropertyForm";
            this.connectionPropertyForm.Size = new System.Drawing.Size(207, 22);
            this.connectionPropertyForm.Text = "Інтерфейс з\'єднання";
            this.connectionPropertyForm.Click += new System.EventHandler(this.connectionPropertyForm_Click);
            // 
            // зєднанняЗБазоюДаннихToolStripMenuItem
            // 
            this.зєднанняЗБазоюДаннихToolStripMenuItem.Name = "зєднанняЗБазоюДаннихToolStripMenuItem";
            this.зєднанняЗБазоюДаннихToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.зєднанняЗБазоюДаннихToolStripMenuItem.Text = "З\'єднання з базою данних";
            // 
            // isRecordTelemetryBtn
            // 
            this.isRecordTelemetryBtn.CheckOnClick = true;
            this.isRecordTelemetryBtn.Name = "isRecordTelemetryBtn";
            this.isRecordTelemetryBtn.Size = new System.Drawing.Size(207, 22);
            this.isRecordTelemetryBtn.Text = "Запис телеметрії";
            // 
            // редагуватиToolStripMenuItem
            // 
            this.редагуватиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devicesBtn,
            this.aliasBtn,
            this.formulsBtn});
            this.редагуватиToolStripMenuItem.Name = "редагуватиToolStripMenuItem";
            this.редагуватиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.редагуватиToolStripMenuItem.Text = "Редагувати";
            // 
            // devicesBtn
            // 
            this.devicesBtn.Name = "devicesBtn";
            this.devicesBtn.Size = new System.Drawing.Size(148, 22);
            this.devicesBtn.Text = "Системи";
            this.devicesBtn.Click += new System.EventHandler(this.devicesBtn_Click);
            // 
            // aliasBtn
            // 
            this.aliasBtn.Name = "aliasBtn";
            this.aliasBtn.Size = new System.Drawing.Size(148, 22);
            this.aliasBtn.Text = "Parameter alias";
            this.aliasBtn.Click += new System.EventHandler(this.aliasBtn_Click);
            // 
            // formulsBtn
            // 
            this.formulsBtn.Name = "formulsBtn";
            this.formulsBtn.Size = new System.Drawing.Size(148, 22);
            this.formulsBtn.Text = "Формули";
            // 
            // arrangementButton
            // 
            this.arrangementButton.Image = global::GroundStation.Properties.Resources.arrow_in;
            this.arrangementButton.Name = "arrangementButton";
            this.arrangementButton.Size = new System.Drawing.Size(102, 20);
            this.arrangementButton.Text = "Компонувати";
            this.arrangementButton.Click += new System.EventHandler(this.arrangementButton_Click);
            // 
            // playSessionBtn
            // 
            this.playSessionBtn.Image = global::GroundStation.Properties.Resources.world_go;
            this.playSessionBtn.Name = "playSessionBtn";
            this.playSessionBtn.Size = new System.Drawing.Size(153, 20);
            this.playSessionBtn.Text = "Провести сеанс зв\'язку";
            this.playSessionBtn.Click += new System.EventHandler(this.playSessionBtn_Click);
            // 
            // sessionGroupBox
            // 
            this.sessionGroupBox.Controls.Add(this.sessionFlexGrid1);
            this.sessionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sessionGroupBox.Location = new System.Drawing.Point(3, 33);
            this.sessionGroupBox.Name = "sessionGroupBox";
            this.sessionGroupBox.Size = new System.Drawing.Size(695, 295);
            this.sessionGroupBox.TabIndex = 2;
            this.sessionGroupBox.TabStop = false;
            this.sessionGroupBox.Text = "Сеанс зв\'язку";
            // 
            // sessionFlexGrid1
            // 
            this.sessionFlexGrid1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.sessionFlexGrid1.AllowEditing = false;
            this.sessionFlexGrid1.AllowFiltering = true;
            this.sessionFlexGrid1.AllowMergingFixed = C1.Win.C1FlexGrid.AllowMergingEnum.None;
            this.sessionFlexGrid1.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.sessionFlexGrid1.AutoResize = true;
            this.sessionFlexGrid1.BackColor = System.Drawing.Color.White;
            this.sessionFlexGrid1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
            this.sessionFlexGrid1.ColumnInfo = resources.GetString("sessionFlexGrid1.ColumnInfo");
            this.sessionFlexGrid1.ContextMenuStrip = this.sessionGridContextMenuStrip;
            this.sessionFlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sessionFlexGrid1.ExtendLastCol = true;
            this.sessionFlexGrid1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None;
            this.sessionFlexGrid1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.sessionFlexGrid1.Location = new System.Drawing.Point(3, 16);
            this.sessionFlexGrid1.Name = "sessionFlexGrid1";
            this.sessionFlexGrid1.Rows.Count = 1;
            this.sessionFlexGrid1.Rows.DefaultSize = 17;
            this.sessionFlexGrid1.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible;
            this.sessionFlexGrid1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.sessionFlexGrid1.ShowSort = false;
            this.sessionFlexGrid1.Size = new System.Drawing.Size(689, 276);
            this.sessionFlexGrid1.StyleInfo = resources.GetString("sessionFlexGrid1.StyleInfo");
            this.sessionFlexGrid1.TabIndex = 1;
            this.sessionFlexGrid1.DoubleClick += new System.EventHandler(this.sessionFlexGrid1_DoubleClick);
            this.sessionFlexGrid1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.sessionFlexGrid1_KeyUp);
            this.sessionFlexGrid1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sessionFlexGrid1_MouseDown);
            // 
            // sessionGridContextMenuStrip
            // 
            this.sessionGridContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.editSessionToolStripMenuItem,
            this.deleteSessionToolStripMenuItem,
            this.редагуватиСтрокуКеруванняToolStripMenuItem});
            this.sessionGridContextMenuStrip.Name = "sessionGridContextMenuStrip";
            this.sessionGridContextMenuStrip.Size = new System.Drawing.Size(230, 76);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(226, 6);
            // 
            // editSessionToolStripMenuItem
            // 
            this.editSessionToolStripMenuItem.Image = global::GroundStation.Properties.Resources.cog;
            this.editSessionToolStripMenuItem.Name = "editSessionToolStripMenuItem";
            this.editSessionToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.editSessionToolStripMenuItem.Text = "Редагувати";
            this.editSessionToolStripMenuItem.Click += new System.EventHandler(this.editSessionToolStripMenuItem_Click);
            // 
            // deleteSessionToolStripMenuItem
            // 
            this.deleteSessionToolStripMenuItem.Image = global::GroundStation.Properties.Resources.delete;
            this.deleteSessionToolStripMenuItem.Name = "deleteSessionToolStripMenuItem";
            this.deleteSessionToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.deleteSessionToolStripMenuItem.Text = "Видалити";
            this.deleteSessionToolStripMenuItem.Click += new System.EventHandler(this.deleteSessionToolStripMenuItem_Click);
            // 
            // редагуватиСтрокуКеруванняToolStripMenuItem
            // 
            this.редагуватиСтрокуКеруванняToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("редагуватиСтрокуКеруванняToolStripMenuItem.Image")));
            this.редагуватиСтрокуКеруванняToolStripMenuItem.Name = "редагуватиСтрокуКеруванняToolStripMenuItem";
            this.редагуватиСтрокуКеруванняToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.редагуватиСтрокуКеруванняToolStripMenuItem.Text = "Редагувати строку керування";
            this.редагуватиСтрокуКеруванняToolStripMenuItem.Click += new System.EventHandler(this.редагуватиСтрокуКеруванняToolStripMenuItem_Click);
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.sysParamAddBtnTableLayoutPanel);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.sessionTableLayoutPanel);
            this.mainSplitContainer.Size = new System.Drawing.Size(967, 331);
            this.mainSplitContainer.SplitterDistance = 262;
            this.mainSplitContainer.TabIndex = 1;
            // 
            // sysParamAddBtnTableLayoutPanel
            // 
            this.sysParamAddBtnTableLayoutPanel.ColumnCount = 1;
            this.sysParamAddBtnTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sysParamAddBtnTableLayoutPanel.Controls.Add(this.sysParamTableLayoutPanel, 0, 0);
            this.sysParamAddBtnTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sysParamAddBtnTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.sysParamAddBtnTableLayoutPanel.Name = "sysParamAddBtnTableLayoutPanel";
            this.sysParamAddBtnTableLayoutPanel.RowCount = 1;
            this.sysParamAddBtnTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sysParamAddBtnTableLayoutPanel.Size = new System.Drawing.Size(262, 331);
            this.sysParamAddBtnTableLayoutPanel.TabIndex = 1;
            // 
            // sysParamTableLayoutPanel
            // 
            this.sysParamTableLayoutPanel.ColumnCount = 1;
            this.sysParamTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sysParamTableLayoutPanel.Controls.Add(this.paramGroupBox, 0, 1);
            this.sysParamTableLayoutPanel.Controls.Add(this.systemGroupBox, 0, 0);
            this.sysParamTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sysParamTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.sysParamTableLayoutPanel.Name = "sysParamTableLayoutPanel";
            this.sysParamTableLayoutPanel.RowCount = 2;
            this.sysParamTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.sysParamTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sysParamTableLayoutPanel.Size = new System.Drawing.Size(256, 325);
            this.sysParamTableLayoutPanel.TabIndex = 6;
            // 
            // paramGroupBox
            // 
            this.paramGroupBox.Controls.Add(this.parameterFlexGrid);
            this.paramGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paramGroupBox.Location = new System.Drawing.Point(3, 58);
            this.paramGroupBox.Name = "paramGroupBox";
            this.paramGroupBox.Size = new System.Drawing.Size(250, 264);
            this.paramGroupBox.TabIndex = 4;
            this.paramGroupBox.TabStop = false;
            this.paramGroupBox.Text = "Параметри системи";
            // 
            // parameterFlexGrid
            // 
            this.parameterFlexGrid.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.parameterFlexGrid.AllowEditing = false;
            this.parameterFlexGrid.AllowMergingFixed = C1.Win.C1FlexGrid.AllowMergingEnum.None;
            this.parameterFlexGrid.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.parameterFlexGrid.AutoResize = true;
            this.parameterFlexGrid.BackColor = System.Drawing.Color.White;
            this.parameterFlexGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
            this.parameterFlexGrid.ColumnInfo = "0,0,0,0,0,85,Columns:";
            this.parameterFlexGrid.ContextMenuStrip = this.parameterGridMenuStrip;
            this.parameterFlexGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parameterFlexGrid.ExtendLastCol = true;
            this.parameterFlexGrid.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None;
            this.parameterFlexGrid.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.parameterFlexGrid.Location = new System.Drawing.Point(3, 16);
            this.parameterFlexGrid.Name = "parameterFlexGrid";
            this.parameterFlexGrid.Rows.Count = 13;
            this.parameterFlexGrid.Rows.DefaultSize = 17;
            this.parameterFlexGrid.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible;
            this.parameterFlexGrid.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox;
            this.parameterFlexGrid.ShowSort = false;
            this.parameterFlexGrid.Size = new System.Drawing.Size(244, 245);
            this.parameterFlexGrid.StyleInfo = resources.GetString("parameterFlexGrid.StyleInfo");
            this.parameterFlexGrid.TabIndex = 2;            
            // 
            // sessionTableLayoutPanel
            // 
            this.sessionTableLayoutPanel.ColumnCount = 1;
            this.sessionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sessionTableLayoutPanel.Controls.Add(this.sessionGroupBox, 0, 1);
            this.sessionTableLayoutPanel.Controls.Add(this.sessionToolStrip, 0, 0);
            this.sessionTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sessionTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.sessionTableLayoutPanel.Name = "sessionTableLayoutPanel";
            this.sessionTableLayoutPanel.RowCount = 2;
            this.sessionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.sessionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sessionTableLayoutPanel.Size = new System.Drawing.Size(701, 331);
            this.sessionTableLayoutPanel.TabIndex = 1;
            // 
            // sessionToolStrip
            // 
            this.sessionToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sessionToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sessionToolStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.sessionToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.sessionToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.upBtn,
            this.downBtn,
            this.toolStripSeparator4,
            this.btnShowSessinons,
            this.toolStripSeparator5,
            this.sessionEdittoolStripLabel});
            this.sessionToolStrip.Location = new System.Drawing.Point(0, 0);
            this.sessionToolStrip.MaximumSize = new System.Drawing.Size(0, 27);
            this.sessionToolStrip.MinimumSize = new System.Drawing.Size(0, 27);
            this.sessionToolStrip.Name = "sessionToolStrip";
            this.sessionToolStrip.Padding = new System.Windows.Forms.Padding(2);
            this.sessionToolStrip.Size = new System.Drawing.Size(701, 27);
            this.sessionToolStrip.TabIndex = 6;
            this.sessionToolStrip.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // upBtn
            // 
            this.upBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.upBtn.BackColor = System.Drawing.SystemColors.Control;
            this.upBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.upBtn.Image = ((System.Drawing.Image)(resources.GetObject("upBtn.Image")));
            this.upBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.upBtn.Name = "upBtn";
            this.upBtn.Size = new System.Drawing.Size(23, 20);
            this.upBtn.Text = "Up";
            this.upBtn.Click += new System.EventHandler(this.upBtn_Click);
            // 
            // downBtn
            // 
            this.downBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.downBtn.BackColor = System.Drawing.SystemColors.Control;
            this.downBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.downBtn.Image = global::GroundStation.Properties.Resources.arrow_down;
            this.downBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.downBtn.Name = "downBtn";
            this.downBtn.Size = new System.Drawing.Size(23, 20);
            this.downBtn.Text = "Down";
            this.downBtn.Click += new System.EventHandler(this.downBtn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // btnShowSessinons
            // 
            this.btnShowSessinons.Image = ((System.Drawing.Image)(resources.GetObject("btnShowSessinons.Image")));
            this.btnShowSessinons.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowSessinons.Name = "btnShowSessinons";
            this.btnShowSessinons.Size = new System.Drawing.Size(135, 20);
            this.btnShowSessinons.Text = "Групи сеансів зв\'язку";
            this.btnShowSessinons.Click += new System.EventHandler(this.btnShowSessinons_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 23);
            // 
            // sessionEdittoolStripLabel
            // 
            this.sessionEdittoolStripLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sessionEdittoolStripLabel.Name = "sessionEdittoolStripLabel";
            this.sessionEdittoolStripLabel.Size = new System.Drawing.Size(94, 20);
            this.sessionEdittoolStripLabel.Text = "Сеанс зв\'язку:";
            // 
            // mainHorizontalSplitContainer
            // 
            this.mainHorizontalSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainHorizontalSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.mainHorizontalSplitContainer.Name = "mainHorizontalSplitContainer";
            this.mainHorizontalSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainHorizontalSplitContainer.Panel1
            // 
            this.mainHorizontalSplitContainer.Panel1.Controls.Add(this.mainSplitContainer);
            this.mainHorizontalSplitContainer.Panel1.Controls.Add(this.arrangemenGroupBox);
            // 
            // mainHorizontalSplitContainer.Panel2
            // 
            this.mainHorizontalSplitContainer.Panel2.Controls.Add(this.log4netRichTextBox);
            this.mainHorizontalSplitContainer.Panel2.Controls.Add(this.toolStrip1);
            this.mainHorizontalSplitContainer.Size = new System.Drawing.Size(967, 446);
            this.mainHorizontalSplitContainer.SplitterDistance = 331;
            this.mainHorizontalSplitContainer.TabIndex = 5;
            // 
            // arrangemenGroupBox
            // 
            this.arrangemenGroupBox.Controls.Add(this.sessionArrangemendataFlexGrid);
            this.arrangemenGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arrangemenGroupBox.Location = new System.Drawing.Point(0, 0);
            this.arrangemenGroupBox.Name = "arrangemenGroupBox";
            this.arrangemenGroupBox.Size = new System.Drawing.Size(967, 331);
            this.arrangemenGroupBox.TabIndex = 1;
            this.arrangemenGroupBox.TabStop = false;
            this.arrangemenGroupBox.Text = "Зкомпонований сеанс зв\'язку";
            this.arrangemenGroupBox.Visible = false;
            // 
            // sessionArrangemendataFlexGrid
            // 
            this.sessionArrangemendataFlexGrid.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.sessionArrangemendataFlexGrid.AllowEditing = false;
            this.sessionArrangemendataFlexGrid.AllowFiltering = true;
            this.sessionArrangemendataFlexGrid.AllowMergingFixed = C1.Win.C1FlexGrid.AllowMergingEnum.None;
            this.sessionArrangemendataFlexGrid.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.sessionArrangemendataFlexGrid.AutoResize = true;
            this.sessionArrangemendataFlexGrid.BackColor = System.Drawing.Color.White;
            this.sessionArrangemendataFlexGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
            this.sessionArrangemendataFlexGrid.ColumnInfo = resources.GetString("sessionArrangemendataFlexGrid.ColumnInfo");
            this.sessionArrangemendataFlexGrid.ContextMenuStrip = this.sessionGridContextMenuStrip;
            this.sessionArrangemendataFlexGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sessionArrangemendataFlexGrid.ExtendLastCol = true;
            this.sessionArrangemendataFlexGrid.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None;
            this.sessionArrangemendataFlexGrid.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.sessionArrangemendataFlexGrid.Location = new System.Drawing.Point(3, 16);
            this.sessionArrangemendataFlexGrid.Name = "sessionArrangemendataFlexGrid";
            this.sessionArrangemendataFlexGrid.Rows.Count = 1;
            this.sessionArrangemendataFlexGrid.Rows.DefaultSize = 17;
            this.sessionArrangemendataFlexGrid.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible;
            this.sessionArrangemendataFlexGrid.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.sessionArrangemendataFlexGrid.ShowSort = false;
            this.sessionArrangemendataFlexGrid.Size = new System.Drawing.Size(961, 312);
            this.sessionArrangemendataFlexGrid.StyleInfo = resources.GetString("sessionArrangemendataFlexGrid.StyleInfo");
            this.sessionArrangemendataFlexGrid.TabIndex = 2;
            this.sessionArrangemendataFlexGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sessionArrangemendataFlexGrid_MouseClick);
            // 
            // log4netRichTextBox
            // 
            this.log4netRichTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.log4netRichTextBox.CausesValidation = false;
            this.log4netRichTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.log4netRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log4netRichTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log4netRichTextBox.Location = new System.Drawing.Point(0, 27);
            this.log4netRichTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.log4netRichTextBox.Name = "log4netRichTextBox";
            this.log4netRichTextBox.ReadOnly = true;
            this.log4netRichTextBox.ShortcutsEnabled = false;
            this.log4netRichTextBox.Size = new System.Drawing.Size(967, 84);
            this.log4netRichTextBox.TabIndex = 0;
            this.log4netRichTextBox.Text = "";
            this.log4netRichTextBox.WordWrap = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.isDebugModeBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.MaximumSize = new System.Drawing.Size(0, 27);
            this.toolStrip1.MinimumSize = new System.Drawing.Size(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(2);
            this.toolStrip1.Size = new System.Drawing.Size(967, 27);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // isDebugModeBtn
            // 
            this.isDebugModeBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.isDebugModeBtn.CheckOnClick = true;
            this.isDebugModeBtn.Image = ((System.Drawing.Image)(resources.GetObject("isDebugModeBtn.Image")));
            this.isDebugModeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.isDebugModeBtn.Name = "isDebugModeBtn";
            this.isDebugModeBtn.Size = new System.Drawing.Size(58, 20);
            this.isDebugModeBtn.Text = "Debug";
            this.isDebugModeBtn.Click += new System.EventHandler(this.isDebugModeBtn_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transferProgressBar,
            this.transferInfoLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 470);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(967, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // transferProgressBar
            // 
            this.transferProgressBar.Name = "transferProgressBar";
            this.transferProgressBar.Size = new System.Drawing.Size(400, 16);
            this.transferProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // transferInfoLabel
            // 
            this.transferInfoLabel.Name = "transferInfoLabel";
            this.transferInfoLabel.Size = new System.Drawing.Size(11, 17);
            this.transferInfoLabel.Text = "-";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "application_side_expand.png");
            // 
            // bindingSource1
            //             
            // 
            // parameterGridMenuStrip
            // 
            this.parameterGridMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиПараметриВСеансЗвязкуToolStripMenuItem});
            this.parameterGridMenuStrip.Name = "parameterGridMenuStrip";
            this.parameterGridMenuStrip.Size = new System.Drawing.Size(250, 48);
            // 
            // додатиПараметриВСеансЗвязкуToolStripMenuItem
            // 
            this.додатиПараметриВСеансЗвязкуToolStripMenuItem.Image = global::GroundStation.Properties.Resources.add;
            this.додатиПараметриВСеансЗвязкуToolStripMenuItem.Name = "додатиПараметриВСеансЗвязкуToolStripMenuItem";
            this.додатиПараметриВСеансЗвязкуToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.додатиПараметриВСеансЗвязкуToolStripMenuItem.Text = "Додати параметри в сеанс зв\'язку";
            this.додатиПараметриВСеансЗвязкуToolStripMenuItem.Click += new System.EventHandler(this.додатиПараметриВСеансЗвязкуToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 492);
            this.Controls.Add(this.mainHorizontalSplitContainer);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "mainForm";
            this.Text = "Центр керування PolyITAN 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.systemGroupBox.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.sessionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sessionFlexGrid1)).EndInit();
            this.sessionGridContextMenuStrip.ResumeLayout(false);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.sysParamAddBtnTableLayoutPanel.ResumeLayout(false);
            this.sysParamTableLayoutPanel.ResumeLayout(false);
            this.paramGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.parameterFlexGrid)).EndInit();
            this.sessionTableLayoutPanel.ResumeLayout(false);
            this.sessionTableLayoutPanel.PerformLayout();
            this.sessionToolStrip.ResumeLayout(false);
            this.sessionToolStrip.PerformLayout();
            this.mainHorizontalSplitContainer.Panel1.ResumeLayout(false);
            this.mainHorizontalSplitContainer.Panel2.ResumeLayout(false);
            this.mainHorizontalSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainHorizontalSplitContainer)).EndInit();
            this.mainHorizontalSplitContainer.ResumeLayout(false);
            this.arrangemenGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sessionArrangemendataFlexGrid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.parameterGridMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox systemGroupBox;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.GroupBox sessionGroupBox;
        private System.Windows.Forms.ComboBox devicesComboBox;
        private System.Windows.Forms.GroupBox paramGroupBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.SplitContainer mainHorizontalSplitContainer;
        private System.Windows.Forms.RichTextBox log4netRichTextBox;
        private System.Windows.Forms.ToolStrip sessionToolStrip;
        private System.Windows.Forms.ToolStripButton upBtn;
        private System.Windows.Forms.ToolStripButton downBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar transferProgressBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem arrangementButton;
        private System.Windows.Forms.ToolStripMenuItem playSessionBtn;
        private System.Windows.Forms.TableLayoutPanel sysParamAddBtnTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel sysParamTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel sessionTableLayoutPanel;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.GroupBox arrangemenGroupBox;
        private System.Windows.Forms.ToolStripMenuItem debugModeBtn;
        private System.Windows.Forms.ToolStripMenuItem isRecordTelemetryBtn;
        private System.Windows.Forms.ToolStripMenuItem connectionPropertyForm;
        private System.Windows.Forms.ToolStripMenuItem зєднанняЗБазоюДаннихToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devicesBtn;
        private System.Windows.Forms.ToolStripMenuItem formulsBtn;
        private System.Windows.Forms.ToolStripStatusLabel transferInfoLabel;
        private System.Windows.Forms.ToolStripButton btnShowSessinons;
        private System.Windows.Forms.ContextMenuStrip sessionGridContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem deleteSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem редагуватиСтрокуКеруванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel sessionEdittoolStripLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton isDebugModeBtn;
        private C1.Win.C1FlexGrid.C1FlexGrid sessionFlexGrid1;
        private C1.Win.C1FlexGrid.C1FlexGrid sessionArrangemendataFlexGrid;
        private System.Windows.Forms.ToolStripMenuItem aliasBtn;
        private C1.Win.C1FlexGrid.C1FlexGrid parameterFlexGrid;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ContextMenuStrip parameterGridMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem додатиПараметриВСеансЗвязкуToolStripMenuItem;
    }
}

