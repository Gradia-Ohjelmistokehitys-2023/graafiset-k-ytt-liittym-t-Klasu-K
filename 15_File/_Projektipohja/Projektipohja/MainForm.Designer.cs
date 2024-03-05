namespace Projektipohja
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.rtxtFileData = new System.Windows.Forms.RichTextBox();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(284, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFileNew,
            this.btnFileOpen,
            this.toolStripSeparator1,
            this.btnFileSave,
            this.btnFileSaveAs,
            this.toolStripSeparator2,
            this.btnFileExit});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(37, 20);
            this.MenuFile.Text = "&File";
            // 
            // btnFileNew
            // 
            this.btnFileNew.Image = global::Projektipohja.Properties.Resources.StickmanMenu;
            this.btnFileNew.Name = "btnFileNew";
            this.btnFileNew.Size = new System.Drawing.Size(180, 22);
            this.btnFileNew.Text = "New...";
            this.btnFileNew.Click += new System.EventHandler(this.btnFileNew_Click);
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.Image = global::Projektipohja.Properties.Resources.StickmanMenu;
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(180, 22);
            this.btnFileOpen.Text = "Open...";
            this.btnFileOpen.Click += new System.EventHandler(this.btnFileOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // btnFileSave
            // 
            this.btnFileSave.Image = global::Projektipohja.Properties.Resources.StickmanMenu;
            this.btnFileSave.Name = "btnFileSave";
            this.btnFileSave.Size = new System.Drawing.Size(180, 22);
            this.btnFileSave.Text = "Save";
            this.btnFileSave.Click += new System.EventHandler(this.btnFileSave_Click);
            // 
            // btnFileSaveAs
            // 
            this.btnFileSaveAs.Image = global::Projektipohja.Properties.Resources.StickmanMenu;
            this.btnFileSaveAs.Name = "btnFileSaveAs";
            this.btnFileSaveAs.Size = new System.Drawing.Size(180, 22);
            this.btnFileSaveAs.Text = "Save as...";
            this.btnFileSaveAs.Click += new System.EventHandler(this.btnFileSaveAs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // btnFileExit
            // 
            this.btnFileExit.Image = global::Projektipohja.Properties.Resources.StickmanMenu;
            this.btnFileExit.Name = "btnFileExit";
            this.btnFileExit.Size = new System.Drawing.Size(180, 22);
            this.btnFileExit.Text = "&Exit";
            this.btnFileExit.Click += new System.EventHandler(this.btnFileExit_Click);
            // 
            // rtxtFileData
            // 
            this.rtxtFileData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtFileData.Location = new System.Drawing.Point(0, 24);
            this.rtxtFileData.Name = "rtxtFileData";
            this.rtxtFileData.Size = new System.Drawing.Size(284, 237);
            this.rtxtFileData.TabIndex = 1;
            this.rtxtFileData.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rtxtFileData);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "Pääformi";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem btnFileExit;
        private System.Windows.Forms.ToolStripMenuItem btnFileNew;
        private System.Windows.Forms.ToolStripMenuItem btnFileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.RichTextBox rtxtFileData;
        private System.Windows.Forms.ToolStripMenuItem btnFileSave;
        private System.Windows.Forms.ToolStripMenuItem btnFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

