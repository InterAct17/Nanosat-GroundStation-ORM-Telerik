namespace GroundStation.view
{
    partial class QuestionFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.questionTxt = new System.Windows.Forms.RichTextBox();
            this.yesBtn = new System.Windows.Forms.Button();
            this.noBtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.waitSwitchGrid = new System.Windows.Forms.DataGridView();
            this.hotKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextOperationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waitSwitchGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionTxt
            // 
            this.questionTxt.BackColor = System.Drawing.SystemColors.Control;
            this.questionTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.questionTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionTxt.Location = new System.Drawing.Point(3, 16);
            this.questionTxt.Margin = new System.Windows.Forms.Padding(7);
            this.questionTxt.Name = "questionTxt";
            this.questionTxt.ReadOnly = true;
            this.questionTxt.Size = new System.Drawing.Size(565, 165);
            this.questionTxt.TabIndex = 0;
            this.questionTxt.Text = "";
            this.questionTxt.Visible = false;
            // 
            // yesBtn
            // 
            this.yesBtn.Image = global::GroundStation.Properties.Resources.accept;
            this.yesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yesBtn.Location = new System.Drawing.Point(6, 18);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(120, 23);
            this.yesBtn.TabIndex = 1;
            this.yesBtn.Text = "Так (ENTER)";
            this.yesBtn.UseVisualStyleBackColor = true;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // noBtn
            // 
            this.noBtn.Image = global::GroundStation.Properties.Resources.delete;
            this.noBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.noBtn.Location = new System.Drawing.Point(442, 18);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(120, 23);
            this.noBtn.TabIndex = 2;
            this.noBtn.Text = "Ні (ESC)";
            this.noBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.noBtn.UseVisualStyleBackColor = true;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.waitSwitchGrid);
            this.groupBox1.Controls.Add(this.questionTxt);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 184);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Команда";
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
            this.waitSwitchGrid.Location = new System.Drawing.Point(3, 16);
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
            this.waitSwitchGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.waitSwitchGrid.Size = new System.Drawing.Size(565, 165);
            this.waitSwitchGrid.TabIndex = 1;
            this.waitSwitchGrid.Visible = false;
            this.waitSwitchGrid.DoubleClick += new System.EventHandler(this.waitSwitchGrid_DoubleClick);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.56904F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.43096F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(577, 249);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.noBtn);
            this.groupBox2.Controls.Add(this.yesBtn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(571, 53);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // QuestionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 249);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuestionFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QuestionFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuestionFrm_FormClosing);
            this.Load += new System.EventHandler(this.QuestionFrm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.waitSwitchGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox questionTxt;
        private System.Windows.Forms.Button yesBtn;
        private System.Windows.Forms.Button noBtn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView waitSwitchGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextOperationName;
    }
}