namespace miinaharava
{
    partial class MiinaharavaView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbMainMenu = new GroupBox();
            label1 = new Label();
            btnStartGame = new Button();
            btnMapSizeMedium = new Button();
            btnMapSizeLarge = new Button();
            btnMapSizeSmall = new Button();
            panelMapSizeBtns = new Panel();
            gbMainMenu.SuspendLayout();
            panelMapSizeBtns.SuspendLayout();
            SuspendLayout();
            // 
            // gbMainMenu
            // 
            gbMainMenu.Controls.Add(label1);
            gbMainMenu.Controls.Add(btnStartGame);
            gbMainMenu.Location = new Point(254, 0);
            gbMainMenu.Name = "gbMainMenu";
            gbMainMenu.Size = new Size(300, 447);
            gbMainMenu.TabIndex = 0;
            gbMainMenu.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 55);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 2;
            label1.Text = "Map size";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStartGame
            // 
            btnStartGame.Location = new Point(84, 226);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(141, 61);
            btnStartGame.TabIndex = 0;
            btnStartGame.Text = "Start Game";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // btnMapSizeMedium
            // 
            btnMapSizeMedium.Location = new Point(110, 12);
            btnMapSizeMedium.Name = "btnMapSizeMedium";
            btnMapSizeMedium.Size = new Size(87, 33);
            btnMapSizeMedium.TabIndex = 3;
            btnMapSizeMedium.Text = "Medium";
            btnMapSizeMedium.UseVisualStyleBackColor = true;
            btnMapSizeMedium.Click += btnMapSizeClick;
            // 
            // btnMapSizeLarge
            // 
            btnMapSizeLarge.Location = new Point(205, 11);
            btnMapSizeLarge.Name = "btnMapSizeLarge";
            btnMapSizeLarge.Size = new Size(87, 33);
            btnMapSizeLarge.TabIndex = 4;
            btnMapSizeLarge.Text = "Large";
            btnMapSizeLarge.UseVisualStyleBackColor = true;
            btnMapSizeLarge.Click += btnMapSizeClick;
            // 
            // btnMapSizeSmall
            // 
            btnMapSizeSmall.Location = new Point(8, 11);
            btnMapSizeSmall.Name = "btnMapSizeSmall";
            btnMapSizeSmall.Size = new Size(87, 33);
            btnMapSizeSmall.TabIndex = 1;
            btnMapSizeSmall.Text = "Small";
            btnMapSizeSmall.UseVisualStyleBackColor = true;
            btnMapSizeSmall.Click += btnMapSizeClick;
            // 
            // panelMapSizeBtns
            // 
            panelMapSizeBtns.BackgroundImageLayout = ImageLayout.None;
            panelMapSizeBtns.Controls.Add(btnMapSizeMedium);
            panelMapSizeBtns.Controls.Add(btnMapSizeLarge);
            panelMapSizeBtns.Controls.Add(btnMapSizeSmall);
            panelMapSizeBtns.Location = new Point(257, 159);
            panelMapSizeBtns.Name = "panelMapSizeBtns";
            panelMapSizeBtns.Size = new Size(293, 56);
            panelMapSizeBtns.TabIndex = 6;
            // 
            // MiinaharavaView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 488);
            Controls.Add(panelMapSizeBtns);
            Controls.Add(gbMainMenu);
            Name = "MiinaharavaView";
            Text = "Form1";
            Load += MiinaharavaView_Load;
            gbMainMenu.ResumeLayout(false);
            gbMainMenu.PerformLayout();
            panelMapSizeBtns.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbMainMenu;
        private Button btnMapSizeLarge;
        private Button btnMapSizeMedium;
        private Label label1;
        private Button btnMapSizeSmall;
        private Button btnStartGame;
        private Panel panelMapSizeBtns;
    }
}