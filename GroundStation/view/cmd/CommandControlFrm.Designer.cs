namespace GroundStation.view
{
    partial class CommandControlFrm
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
            this.controlCommandComboBox = new System.Windows.Forms.ComboBox();
            this.ifGroupBox = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.exprTxt = new System.Windows.Forms.TextBox();
            this.nextSessionOperationComboBox = new System.Windows.Forms.ComboBox();
            this.questionComboBox = new System.Windows.Forms.ComboBox();
            this.waitGroupBox = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.waitSwitchGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.waitSwitchGrid = new System.Windows.Forms.DataGridView();
            this.hotKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextOperationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.delWaitSwitchBtn = new System.Windows.Forms.Button();
            this.addWaitSwitchBtn = new System.Windows.Forms.Button();
            this.opDescription = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timeTxt = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ifGroupBox.SuspendLayout();
            this.waitGroupBox.SuspendLayout();
            this.waitSwitchGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waitSwitchGrid)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlCommandComboBox
            // 
            this.controlCommandComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.controlCommandComboBox.FormattingEnabled = true;
            this.controlCommandComboBox.Items.AddRange(new object[] {
            "Відсутня",
            "Умовне розгалуження",
            "Очікування підтвердження оператором",
            "Очікування підтвердження оператором c вибором переходу"});
            this.controlCommandComboBox.Location = new System.Drawing.Point(9, 43);
            this.controlCommandComboBox.Name = "controlCommandComboBox";
            this.controlCommandComboBox.Size = new System.Drawing.Size(659, 21);
            this.controlCommandComboBox.TabIndex = 0;
            this.controlCommandComboBox.SelectedIndexChanged += new System.EventHandler(this.controlCommandComboBox_SelectedIndexChanged);
            // 
            // ifGroupBox
            // 
            this.ifGroupBox.Controls.Add(this.richTextBox2);
            this.ifGroupBox.Controls.Add(this.label5);
            this.ifGroupBox.Controls.Add(this.label4);
            this.ifGroupBox.Controls.Add(this.exprTxt);
            this.ifGroupBox.Controls.Add(this.nextSessionOperationComboBox);
            this.ifGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ifGroupBox.Location = new System.Drawing.Point(3, 16);
            this.ifGroupBox.Name = "ifGroupBox";
            this.ifGroupBox.Size = new System.Drawing.Size(674, 191);
            this.ifGroupBox.TabIndex = 1;
            this.ifGroupBox.TabStop = false;
            this.ifGroupBox.Text = "Параметри";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox2.Location = new System.Drawing.Point(28, 16);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(15);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(637, 54);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "Value - вхідне значення параметру.\nДоступні операції: <, >, <=, >=, =.\nПриклад: 0" +
                ",33<=value<5,1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Якщо логіяний вираз:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Перейти на строку:";
            // 
            // exprTxt
            // 
            this.exprTxt.Location = new System.Drawing.Point(28, 104);
            this.exprTxt.Name = "exprTxt";
            this.exprTxt.Size = new System.Drawing.Size(260, 20);
            this.exprTxt.TabIndex = 1;
            this.exprTxt.Text = "value>0";
            // 
            // nextSessionOperationComboBox
            // 
            this.nextSessionOperationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nextSessionOperationComboBox.FormattingEnabled = true;
            this.nextSessionOperationComboBox.Location = new System.Drawing.Point(294, 102);
            this.nextSessionOperationComboBox.Name = "nextSessionOperationComboBox";
            this.nextSessionOperationComboBox.Size = new System.Drawing.Size(371, 21);
            this.nextSessionOperationComboBox.TabIndex = 0;
            // 
            // questionComboBox
            // 
            this.questionComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.questionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.questionComboBox.FormattingEnabled = true;
            this.questionComboBox.Items.AddRange(new object[] {
            "Виконати",
            "Запитати",
            "Запитати з таймером на підтвердження",
            "Запитати з таймером на відмову"});
            this.questionComboBox.Location = new System.Drawing.Point(3, 16);
            this.questionComboBox.Name = "questionComboBox";
            this.questionComboBox.Size = new System.Drawing.Size(288, 21);
            this.questionComboBox.TabIndex = 3;
            this.questionComboBox.SelectedIndexChanged += new System.EventHandler(this.questionComboBox_SelectedIndexChanged);
            // 
            // waitGroupBox
            // 
            this.waitGroupBox.Controls.Add(this.richTextBox1);
            this.waitGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waitGroupBox.Location = new System.Drawing.Point(3, 16);
            this.waitGroupBox.Name = "waitGroupBox";
            this.waitGroupBox.Padding = new System.Windows.Forms.Padding(15);
            this.waitGroupBox.Size = new System.Drawing.Size(674, 191);
            this.waitGroupBox.TabIndex = 4;
            this.waitGroupBox.TabStop = false;
            this.waitGroupBox.Text = "Параметри";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(15, 28);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(15);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(644, 148);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "На цьому рядку сеанс зв\'язку призупиняється і чекає команди оператора на продовже" +
                "ння сеансу зв\'язку з наступного рядка.";
            // 
            // waitSwitchGroupBox
            // 
            this.waitSwitchGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.waitSwitchGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waitSwitchGroupBox.Location = new System.Drawing.Point(3, 16);
            this.waitSwitchGroupBox.Name = "waitSwitchGroupBox";
            this.waitSwitchGroupBox.Size = new System.Drawing.Size(674, 191);
            this.waitSwitchGroupBox.TabIndex = 5;
            this.waitSwitchGroupBox.TabStop = false;
            this.waitSwitchGroupBox.Text = "Параметри";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.waitSwitchGrid, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(668, 172);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // waitSwitchGrid
            // 
            this.waitSwitchGrid.AllowUserToAddRows = false;
            this.waitSwitchGrid.AllowUserToDeleteRows = false;
            this.waitSwitchGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.waitSwitchGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.waitSwitchGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.waitSwitchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.waitSwitchGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hotKey,
            this.nextOperation,
            this.nextOperationName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.waitSwitchGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.waitSwitchGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waitSwitchGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.waitSwitchGrid.Location = new System.Drawing.Point(3, 58);
            this.waitSwitchGrid.MultiSelect = false;
            this.waitSwitchGrid.Name = "waitSwitchGrid";
            this.waitSwitchGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.waitSwitchGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.waitSwitchGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.waitSwitchGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.waitSwitchGrid.Size = new System.Drawing.Size(662, 111);
            this.waitSwitchGrid.TabIndex = 0;
            this.waitSwitchGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.waitSwitchGrid_CellDoubleClick);
            // 
            // hotKey
            // 
            this.hotKey.HeaderText = "Гаряча клавіша";
            this.hotKey.Name = "hotKey";
            this.hotKey.ReadOnly = true;
            // 
            // nextOperation
            // 
            this.nextOperation.HeaderText = "Ідентифікатор наступного рядка";
            this.nextOperation.Name = "nextOperation";
            this.nextOperation.ReadOnly = true;
            this.nextOperation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nextOperation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nextOperationName
            // 
            this.nextOperationName.HeaderText = "Назва";
            this.nextOperationName.Name = "nextOperationName";
            this.nextOperationName.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.delWaitSwitchBtn);
            this.groupBox4.Controls.Add(this.addWaitSwitchBtn);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(662, 49);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Актуалізація";
            // 
            // delWaitSwitchBtn
            // 
            this.delWaitSwitchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delWaitSwitchBtn.Image = global::GroundStation.Properties.Resources.delete;
            this.delWaitSwitchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delWaitSwitchBtn.Location = new System.Drawing.Point(87, 19);
            this.delWaitSwitchBtn.Name = "delWaitSwitchBtn";
            this.delWaitSwitchBtn.Size = new System.Drawing.Size(83, 23);
            this.delWaitSwitchBtn.TabIndex = 1;
            this.delWaitSwitchBtn.Text = "Видалити";
            this.delWaitSwitchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delWaitSwitchBtn.UseVisualStyleBackColor = true;
            this.delWaitSwitchBtn.Click += new System.EventHandler(this.delWaitSwitchBtn_Click);
            // 
            // addWaitSwitchBtn
            // 
            this.addWaitSwitchBtn.Image = global::GroundStation.Properties.Resources.add;
            this.addWaitSwitchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addWaitSwitchBtn.Location = new System.Drawing.Point(6, 19);
            this.addWaitSwitchBtn.Name = "addWaitSwitchBtn";
            this.addWaitSwitchBtn.Size = new System.Drawing.Size(75, 23);
            this.addWaitSwitchBtn.TabIndex = 0;
            this.addWaitSwitchBtn.Text = "Додати";
            this.addWaitSwitchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addWaitSwitchBtn.UseVisualStyleBackColor = true;
            this.addWaitSwitchBtn.Click += new System.EventHandler(this.addWaitSwitchBtn_Click);
            // 
            // opDescription
            // 
            this.opDescription.AutoSize = true;
            this.opDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opDescription.Location = new System.Drawing.Point(6, 18);
            this.opDescription.Name = "opDescription";
            this.opDescription.Size = new System.Drawing.Size(85, 13);
            this.opDescription.TabIndex = 6;
            this.opDescription.Text = "opDescription";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(686, 361);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.controlCommandComboBox);
            this.groupBox1.Controls.Add(this.opDescription);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип команди";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.timeTxt);
            this.groupBox3.Controls.Add(this.saveButton);
            this.groupBox3.Controls.Add(this.questionComboBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 309);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(680, 49);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "c.";
            // 
            // timeTxt
            // 
            this.timeTxt.Enabled = false;
            this.timeTxt.Location = new System.Drawing.Point(297, 16);
            this.timeTxt.Name = "timeTxt";
            this.timeTxt.Size = new System.Drawing.Size(55, 20);
            this.timeTxt.TabIndex = 4;
            this.timeTxt.Text = "3";
            // 
            // saveButton
            // 
            this.saveButton.Image = global::GroundStation.Properties.Resources.accept;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Location = new System.Drawing.Point(380, 13);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Зберегти";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.waitSwitchGroupBox);
            this.groupBox2.Controls.Add(this.waitGroupBox);
            this.groupBox2.Controls.Add(this.ifGroupBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(680, 210);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // CommandControlFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CommandControlFrm";
            this.Text = "Команда керування";
            this.Load += new System.EventHandler(this.controlCommandFrm_Load);
            this.ifGroupBox.ResumeLayout(false);
            this.ifGroupBox.PerformLayout();
            this.waitGroupBox.ResumeLayout(false);
            this.waitSwitchGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.waitSwitchGrid)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox controlCommandComboBox;
        private System.Windows.Forms.GroupBox ifGroupBox;
        private System.Windows.Forms.TextBox exprTxt;
        private System.Windows.Forms.ComboBox nextSessionOperationComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox questionComboBox;
        private System.Windows.Forms.GroupBox waitGroupBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox waitSwitchGroupBox;
        private System.Windows.Forms.DataGridView waitSwitchGrid;
        private System.Windows.Forms.Label opDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button delWaitSwitchBtn;
        private System.Windows.Forms.Button addWaitSwitchBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextOperationName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox timeTxt;
    }
}