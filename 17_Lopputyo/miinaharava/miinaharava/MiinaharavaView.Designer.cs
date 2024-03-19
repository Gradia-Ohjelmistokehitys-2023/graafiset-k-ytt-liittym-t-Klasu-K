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
            panelStats = new Panel();
            labelResultText = new Label();
            label3 = new Label();
            labelMinutes = new Label();
            labelSeconds = new Label();
            label2 = new Label();
            gbMainMenu.SuspendLayout();
            panelMapSizeBtns.SuspendLayout();
            panelStats.SuspendLayout();
            SuspendLayout();
            // 
            // gbMainMenu
            // 
            gbMainMenu.Controls.Add(label1);
            gbMainMenu.Controls.Add(btnStartGame);
            gbMainMenu.Location = new Point(178, 0);
            gbMainMenu.Margin = new Padding(2, 2, 2, 2);
            gbMainMenu.Name = "gbMainMenu";
            gbMainMenu.Padding = new Padding(2, 2, 2, 2);
            gbMainMenu.Size = new Size(210, 268);
            gbMainMenu.TabIndex = 0;
            gbMainMenu.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 33);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 2;
            label1.Text = "MapData size";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStartGame
            // 
            btnStartGame.Location = new Point(59, 136);
            btnStartGame.Margin = new Padding(2, 2, 2, 2);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(99, 37);
            btnStartGame.TabIndex = 0;
            btnStartGame.Text = "Start Game";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // btnMapSizeMedium
            // 
            btnMapSizeMedium.Location = new Point(77, 7);
            btnMapSizeMedium.Margin = new Padding(2, 2, 2, 2);
            btnMapSizeMedium.Name = "btnMapSizeMedium";
            btnMapSizeMedium.Size = new Size(61, 20);
            btnMapSizeMedium.TabIndex = 3;
            btnMapSizeMedium.Text = "Medium";
            btnMapSizeMedium.UseVisualStyleBackColor = true;
            btnMapSizeMedium.Click += btnMapSizeClick;
            // 
            // btnMapSizeLarge
            // 
            btnMapSizeLarge.Location = new Point(144, 7);
            btnMapSizeLarge.Margin = new Padding(2, 2, 2, 2);
            btnMapSizeLarge.Name = "btnMapSizeLarge";
            btnMapSizeLarge.Size = new Size(61, 20);
            btnMapSizeLarge.TabIndex = 4;
            btnMapSizeLarge.Text = "Large";
            btnMapSizeLarge.UseVisualStyleBackColor = true;
            btnMapSizeLarge.Click += btnMapSizeClick;
            // 
            // btnMapSizeSmall
            // 
            btnMapSizeSmall.Location = new Point(6, 7);
            btnMapSizeSmall.Margin = new Padding(2, 2, 2, 2);
            btnMapSizeSmall.Name = "btnMapSizeSmall";
            btnMapSizeSmall.Size = new Size(61, 20);
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
            panelMapSizeBtns.Location = new Point(180, 95);
            panelMapSizeBtns.Margin = new Padding(2, 2, 2, 2);
            panelMapSizeBtns.Name = "panelMapSizeBtns";
            panelMapSizeBtns.Size = new Size(205, 34);
            panelMapSizeBtns.TabIndex = 6;
            // 
            // panelStats
            // 
            panelStats.BackColor = Color.Turquoise;
            panelStats.Controls.Add(labelResultText);
            panelStats.Controls.Add(label3);
            panelStats.Controls.Add(labelMinutes);
            panelStats.Controls.Add(labelSeconds);
            panelStats.Controls.Add(label2);
            panelStats.Dock = DockStyle.Fill;
            panelStats.Location = new Point(0, 0);
            panelStats.Margin = new Padding(2, 2, 2, 2);
            panelStats.Name = "panelStats";
            panelStats.Size = new Size(614, 293);
            panelStats.TabIndex = 6;
            panelStats.Visible = false;
            // 
            // labelResultText
            // 
            labelResultText.AutoSize = true;
            labelResultText.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelResultText.Location = new Point(257, 61);
            labelResultText.Margin = new Padding(2, 0, 2, 0);
            labelResultText.Name = "labelResultText";
            labelResultText.Size = new Size(90, 37);
            labelResultText.TabIndex = 4;
            labelResultText.Text = "label4";
            labelResultText.TextAlign = ContentAlignment.MiddleCenter;
            labelResultText.Click += labelResultText_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(300, 140);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(16, 28);
            label3.TabIndex = 3;
            label3.Text = ":";
            // 
            // labelMinutes
            // 
            labelMinutes.AutoSize = true;
            labelMinutes.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelMinutes.Location = new Point(272, 141);
            labelMinutes.Margin = new Padding(2, 0, 2, 0);
            labelMinutes.Name = "labelMinutes";
            labelMinutes.Size = new Size(34, 28);
            labelMinutes.TabIndex = 0;
            labelMinutes.Text = "00";
            labelMinutes.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelSeconds
            // 
            labelSeconds.AutoSize = true;
            labelSeconds.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelSeconds.Location = new Point(312, 141);
            labelSeconds.Margin = new Padding(2, 0, 2, 0);
            labelSeconds.Name = "labelSeconds";
            labelSeconds.Size = new Size(34, 28);
            labelSeconds.TabIndex = 1;
            labelSeconds.Text = "00";
            labelSeconds.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(257, 109);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 28);
            label2.TabIndex = 0;
            label2.Text = "Your Time";
            // 
            // MiinaharavaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 293);
            Controls.Add(panelStats);
            Controls.Add(panelMapSizeBtns);
            Controls.Add(gbMainMenu);
            Margin = new Padding(2, 2, 2, 2);
            Name = "MiinaharavaView";
            Text = "Form1";
            Load += MiinaharavaView_Load;
            gbMainMenu.ResumeLayout(false);
            gbMainMenu.PerformLayout();
            panelMapSizeBtns.ResumeLayout(false);
            panelStats.ResumeLayout(false);
            panelStats.PerformLayout();
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
        private Panel panelStats;
        private Label label3;
        private Label labelMinutes;
        private Label labelSeconds;
        private Label label2;
        private Label labelResultText;
    }
}