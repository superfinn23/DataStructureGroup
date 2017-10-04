namespace DataStructuresGroup
{
    partial class frmMain
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
            this.lstMenuOptions = new System.Windows.Forms.ListBox();
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.lblLabel = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.mStack = new System.Windows.Forms.ToolStripMenuItem();
            this.mQueue = new System.Windows.Forms.ToolStripMenuItem();
            this.mDictionary = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lstbxDisplay = new System.Windows.Forms.ListBox();
            this.lblDelete = new System.Windows.Forms.Label();
            this.txtboxDelete = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.lblStopwatch = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMenuOptions
            // 
            this.lstMenuOptions.FormattingEnabled = true;
            this.lstMenuOptions.ItemHeight = 25;
            this.lstMenuOptions.Location = new System.Drawing.Point(35, 88);
            this.lstMenuOptions.Name = "lstMenuOptions";
            this.lstMenuOptions.Size = new System.Drawing.Size(378, 254);
            this.lstMenuOptions.TabIndex = 1;
            this.lstMenuOptions.SelectedIndexChanged += new System.EventHandler(this.lstMenuOptions_SelectedIndexChanged_1);
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.Location = new System.Drawing.Point(255, 370);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(236, 31);
            this.txtBoxUser.TabIndex = 2;
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(103, 370);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(146, 25);
            this.lblLabel.TabIndex = 3;
            this.lblLabel.Text = "Enter a name:";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mStack,
            this.mQueue,
            this.mDictionary,
            this.exitToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(90, 36);
            this.Menu.Text = "Menu";
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // mStack
            // 
            this.mStack.Name = "mStack";
            this.mStack.Size = new System.Drawing.Size(247, 38);
            this.mStack.Text = "1. Stack";
            this.mStack.Click += new System.EventHandler(this.stackToolStripMenuItem_Click);
            // 
            // mQueue
            // 
            this.mQueue.Name = "mQueue";
            this.mQueue.Size = new System.Drawing.Size(247, 38);
            this.mQueue.Text = "2. Queue";
            this.mQueue.Click += new System.EventHandler(this.queueToolStripMenuItem_Click);
            // 
            // mDictionary
            // 
            this.mDictionary.Name = "mDictionary";
            this.mDictionary.Size = new System.Drawing.Size(247, 38);
            this.mDictionary.Text = "3. Dictionary";
            this.mDictionary.Click += new System.EventHandler(this.dictionaryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(247, 38);
            this.exitToolStripMenuItem.Text = "4. Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(545, 370);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(111, 41);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lstbxDisplay
            // 
            this.lstbxDisplay.FormattingEnabled = true;
            this.lstbxDisplay.ItemHeight = 25;
            this.lstbxDisplay.Location = new System.Drawing.Point(430, 88);
            this.lstbxDisplay.Name = "lstbxDisplay";
            this.lstbxDisplay.Size = new System.Drawing.Size(404, 254);
            this.lstbxDisplay.TabIndex = 5;
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(103, 466);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(285, 25);
            this.lblDelete.TabIndex = 6;
            this.lblDelete.Text = "What do you want to delete?";
            // 
            // txtboxDelete
            // 
            this.txtboxDelete.Location = new System.Drawing.Point(394, 466);
            this.txtboxDelete.Name = "txtboxDelete";
            this.txtboxDelete.Size = new System.Drawing.Size(236, 31);
            this.txtboxDelete.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(661, 466);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 41);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(609, 591);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(80, 25);
            this.lblDisplay.TabIndex = 9;
            this.lblDisplay.Text = "Delete ";
            // 
            // lblStopwatch
            // 
            this.lblStopwatch.AutoSize = true;
            this.lblStopwatch.Location = new System.Drawing.Point(436, 591);
            this.lblStopwatch.Name = "lblStopwatch";
            this.lblStopwatch.Size = new System.Drawing.Size(80, 25);
            this.lblStopwatch.TabIndex = 10;
            this.lblStopwatch.Text = "Search";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(103, 530);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(291, 25);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "What do you want to search?";
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Location = new System.Drawing.Point(410, 530);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(236, 31);
            this.txtboxSearch.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(685, 530);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 41);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 625);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblStopwatch);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtboxDelete);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.lstbxDisplay);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.txtBoxUser);
            this.Controls.Add(this.lstMenuOptions);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Data Structures";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstMenuOptions;
        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem mStack;
        private System.Windows.Forms.ToolStripMenuItem mQueue;
        private System.Windows.Forms.ToolStripMenuItem mDictionary;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ListBox lstbxDisplay;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.TextBox txtboxDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label lblStopwatch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}

