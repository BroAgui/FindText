namespace FindText
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxWrap = new System.Windows.Forms.CheckBox();
            this.checkBoxCaps = new System.Windows.Forms.CheckBox();
            this.numericUpDownLenth = new System.Windows.Forms.NumericUpDown();
            this.checkBoxNoResult = new System.Windows.Forms.CheckBox();
            this.checkBoxShowWord = new System.Windows.Forms.CheckBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.checkBoxSonParh = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKeyWord = new System.Windows.Forms.TextBox();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelResult = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLenth)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxWrap);
            this.groupBox1.Controls.Add(this.checkBoxCaps);
            this.groupBox1.Controls.Add(this.numericUpDownLenth);
            this.groupBox1.Controls.Add(this.checkBoxNoResult);
            this.groupBox1.Controls.Add(this.checkBoxShowWord);
            this.groupBox1.Controls.Add(this.buttonCopy);
            this.groupBox1.Controls.Add(this.buttonStart);
            this.groupBox1.Controls.Add(this.comboBoxFilter);
            this.groupBox1.Controls.Add(this.checkBoxSonParh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonFolder);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxKeyWord);
            this.groupBox1.Controls.Add(this.textBoxFolder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxWrap
            // 
            this.checkBoxWrap.AutoSize = true;
            this.checkBoxWrap.Checked = true;
            this.checkBoxWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWrap.Location = new System.Drawing.Point(595, 42);
            this.checkBoxWrap.Name = "checkBoxWrap";
            this.checkBoxWrap.Size = new System.Drawing.Size(72, 16);
            this.checkBoxWrap.TabIndex = 13;
            this.checkBoxWrap.Text = "自動換行";
            this.checkBoxWrap.UseVisualStyleBackColor = true;
            // 
            // checkBoxCaps
            // 
            this.checkBoxCaps.AutoSize = true;
            this.checkBoxCaps.Location = new System.Drawing.Point(238, 44);
            this.checkBoxCaps.Name = "checkBoxCaps";
            this.checkBoxCaps.Size = new System.Drawing.Size(84, 16);
            this.checkBoxCaps.TabIndex = 12;
            this.checkBoxCaps.Text = "匹配大小寫";
            this.checkBoxCaps.UseVisualStyleBackColor = true;
            // 
            // numericUpDownLenth
            // 
            this.numericUpDownLenth.Location = new System.Drawing.Point(420, 41);
            this.numericUpDownLenth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownLenth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLenth.Name = "numericUpDownLenth";
            this.numericUpDownLenth.Size = new System.Drawing.Size(59, 21);
            this.numericUpDownLenth.TabIndex = 11;
            this.numericUpDownLenth.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // checkBoxNoResult
            // 
            this.checkBoxNoResult.AutoSize = true;
            this.checkBoxNoResult.Checked = true;
            this.checkBoxNoResult.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNoResult.Location = new System.Drawing.Point(487, 43);
            this.checkBoxNoResult.Name = "checkBoxNoResult";
            this.checkBoxNoResult.Size = new System.Drawing.Size(108, 16);
            this.checkBoxNoResult.TabIndex = 10;
            this.checkBoxNoResult.Text = "顯示無結果內容";
            this.checkBoxNoResult.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowWord
            // 
            this.checkBoxShowWord.AutoSize = true;
            this.checkBoxShowWord.Checked = true;
            this.checkBoxShowWord.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowWord.Location = new System.Drawing.Point(324, 44);
            this.checkBoxShowWord.Name = "checkBoxShowWord";
            this.checkBoxShowWord.Size = new System.Drawing.Size(96, 16);
            this.checkBoxShowWord.TabIndex = 9;
            this.checkBoxShowWord.Text = "顯示內容字數";
            this.checkBoxShowWord.UseVisualStyleBackColor = true;
            // 
            // buttonCopy
            // 
            this.buttonCopy.AutoSize = true;
            this.buttonCopy.Location = new System.Drawing.Point(666, 37);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(64, 23);
            this.buttonCopy.TabIndex = 7;
            this.buttonCopy.Text = "複製結果";
            this.buttonCopy.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(666, 10);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(63, 23);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "開始";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            ".txt",
            ".html",
            ".xml",
            "*"});
            this.comboBoxFilter.Location = new System.Drawing.Point(534, 14);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(104, 20);
            this.comboBoxFilter.TabIndex = 5;
            this.comboBoxFilter.Text = ".txt";
            // 
            // checkBoxSonParh
            // 
            this.checkBoxSonParh.AutoSize = true;
            this.checkBoxSonParh.Checked = true;
            this.checkBoxSonParh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSonParh.Location = new System.Drawing.Point(420, 17);
            this.checkBoxSonParh.Name = "checkBoxSonParh";
            this.checkBoxSonParh.Size = new System.Drawing.Size(84, 16);
            this.checkBoxSonParh.TabIndex = 1;
            this.checkBoxSonParh.Text = "包含子目錄";
            this.checkBoxSonParh.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "過濾";
            // 
            // buttonFolder
            // 
            this.buttonFolder.Location = new System.Drawing.Point(362, 13);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(52, 23);
            this.buttonFolder.TabIndex = 4;
            this.buttonFolder.Text = "瀏覽";
            this.buttonFolder.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "正則表達";
            // 
            // textBoxKeyWord
            // 
            this.textBoxKeyWord.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxKeyWord.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxKeyWord.Location = new System.Drawing.Point(58, 41);
            this.textBoxKeyWord.Name = "textBoxKeyWord";
            this.textBoxKeyWord.Size = new System.Drawing.Size(169, 21);
            this.textBoxKeyWord.TabIndex = 2;
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.Location = new System.Drawing.Point(58, 14);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(294, 21);
            this.textBoxFolder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "路徑";
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxResult.Location = new System.Drawing.Point(3, 3);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResult.Size = new System.Drawing.Size(735, 449);
            this.textBoxResult.TabIndex = 1;
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(125, 175);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxResult, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(741, 475);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelResult});
            this.statusStrip1.Location = new System.Drawing.Point(0, 455);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(741, 20);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelResult
            // 
            this.toolStripStatusLabelResult.Name = "toolStripStatusLabelResult";
            this.toolStripStatusLabelResult.Size = new System.Drawing.Size(32, 15);
            this.toolStripStatusLabelResult.Text = "就緒";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 545);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "文本搜索";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLenth)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.CheckBox checkBoxSonParh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKeyWord;
        private System.Windows.Forms.TextBox textBoxFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.CheckBox checkBoxNoResult;
        private System.Windows.Forms.CheckBox checkBoxShowWord;
        private System.Windows.Forms.NumericUpDown numericUpDownLenth;
        private System.Windows.Forms.CheckBox checkBoxCaps;
        private System.Windows.Forms.CheckBox checkBoxWrap;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelResult;
    }
}

