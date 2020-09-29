namespace UniqueWebSite_XML {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.chklstList = new System.Windows.Forms.CheckedListBox();
            this.btnUncheckAll = new System.Windows.Forms.Button();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSortByValue = new System.Windows.Forms.Button();
            this.btnSortByName = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tsmiExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(492, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.tsmiSave,
            this.closeFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(124, 22);
            this.tsmiOpen.Text = "&Open";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(124, 22);
            this.tsmiSave.Text = "&Save";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // closeFileToolStripMenuItem
            // 
            this.closeFileToolStripMenuItem.Name = "closeFileToolStripMenuItem";
            this.closeFileToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.closeFileToolStripMenuItem.Text = "Close &File";
            this.closeFileToolStripMenuItem.Click += new System.EventHandler(this.closeFileToolStripMenuItem_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(37, 20);
            this.tsmiExit.Text = "&Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // chklstList
            // 
            this.chklstList.CheckOnClick = true;
            this.chklstList.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::UniqueWebSite_XML.Properties.Settings.Default, "DefTextboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chklstList.Font = global::UniqueWebSite_XML.Properties.Settings.Default.DefTextboxFont;
            this.chklstList.FormattingEnabled = true;
            this.chklstList.Location = new System.Drawing.Point(12, 148);
            this.chklstList.Name = "chklstList";
            this.chklstList.Size = new System.Drawing.Size(327, 174);
            this.chklstList.TabIndex = 10;
            // 
            // btnUncheckAll
            // 
            this.btnUncheckAll.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::UniqueWebSite_XML.Properties.Settings.Default, "DefLabelFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnUncheckAll.Font = global::UniqueWebSite_XML.Properties.Settings.Default.DefLabelFont;
            this.btnUncheckAll.Location = new System.Drawing.Point(119, 338);
            this.btnUncheckAll.Name = "btnUncheckAll";
            this.btnUncheckAll.Size = new System.Drawing.Size(101, 34);
            this.btnUncheckAll.TabIndex = 9;
            this.btnUncheckAll.Text = "&Uncheck All";
            this.btnUncheckAll.UseVisualStyleBackColor = true;
            this.btnUncheckAll.Click += new System.EventHandler(this.btnUncheckAll_Click);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::UniqueWebSite_XML.Properties.Settings.Default, "DefLabelFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnCheckAll.Font = global::UniqueWebSite_XML.Properties.Settings.Default.DefLabelFont;
            this.btnCheckAll.Location = new System.Drawing.Point(12, 338);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(101, 34);
            this.btnCheckAll.TabIndex = 8;
            this.btnCheckAll.Text = "&Check All";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::UniqueWebSite_XML.Properties.Settings.Default, "DefLabelFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnDelete.Font = global::UniqueWebSite_XML.Properties.Settings.Default.DefLabelFont;
            this.btnDelete.Location = new System.Drawing.Point(345, 242);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 34);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "&Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSortByValue
            // 
            this.btnSortByValue.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::UniqueWebSite_XML.Properties.Settings.Default, "DefLabelFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnSortByValue.Font = global::UniqueWebSite_XML.Properties.Settings.Default.DefLabelFont;
            this.btnSortByValue.Location = new System.Drawing.Point(345, 188);
            this.btnSortByValue.Name = "btnSortByValue";
            this.btnSortByValue.Size = new System.Drawing.Size(135, 34);
            this.btnSortByValue.TabIndex = 6;
            this.btnSortByValue.Text = "Sort By &Value";
            this.btnSortByValue.UseVisualStyleBackColor = true;
            this.btnSortByValue.Click += new System.EventHandler(this.btnSortByValue_Click);
            // 
            // btnSortByName
            // 
            this.btnSortByName.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::UniqueWebSite_XML.Properties.Settings.Default, "DefLabelFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnSortByName.Font = global::UniqueWebSite_XML.Properties.Settings.Default.DefLabelFont;
            this.btnSortByName.Location = new System.Drawing.Point(345, 148);
            this.btnSortByName.Name = "btnSortByName";
            this.btnSortByName.Size = new System.Drawing.Size(135, 34);
            this.btnSortByName.TabIndex = 5;
            this.btnSortByName.Text = "Sort By &Key";
            this.btnSortByName.UseVisualStyleBackColor = true;
            this.btnSortByName.Click += new System.EventHandler(this.btnSortByName_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::UniqueWebSite_XML.Properties.Settings.Default, "DefLabelFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnAdd.Font = global::UniqueWebSite_XML.Properties.Settings.Default.DefLabelFont;
            this.btnAdd.Location = new System.Drawing.Point(345, 73);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 34);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "&Add To List";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::UniqueWebSite_XML.Properties.Settings.Default, "DefLabelFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.Font = global::UniqueWebSite_XML.Properties.Settings.Default.DefLabelFont;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name/Value List";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInput
            // 
            this.txtInput.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::UniqueWebSite_XML.Properties.Settings.Default, "DefTextboxFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtInput.Font = global::UniqueWebSite_XML.Properties.Settings.Default.DefTextboxFont;
            this.txtInput.Location = new System.Drawing.Point(12, 73);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(327, 22);
            this.txtInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::UniqueWebSite_XML.Properties.Settings.Default, "DefLabelFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Font = global::UniqueWebSite_XML.Properties.Settings.Default.DefLabelFont;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name/Value Pair";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 390);
            this.Controls.Add(this.chklstList);
            this.Controls.Add(this.btnUncheckAll);
            this.Controls.Add(this.btnCheckAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSortByValue);
            this.Controls.Add(this.btnSortByName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Key-Value Pair Entry Program";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSortByName;
        private System.Windows.Forms.Button btnSortByValue;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.Button btnUncheckAll;
        private System.Windows.Forms.CheckedListBox chklstList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem closeFileToolStripMenuItem;
    }
}

