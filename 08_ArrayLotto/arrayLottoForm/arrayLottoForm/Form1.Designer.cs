namespace arrayLottoForm
{
    partial class Form1
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
            labelNumbers = new Label();
            labelNumbersOrdered = new Label();
            labelBonusNumbers = new Label();
            label1 = new Label();
            txtUserNumbers = new TextBox();
            label2 = new Label();
            labelCorrectNumbersAmount = new Label();
            btnDrawNumbers = new Button();
            SuspendLayout();
            // 
            // labelNumbers
            // 
            labelNumbers.AutoSize = true;
            labelNumbers.BackColor = SystemColors.ButtonShadow;
            labelNumbers.Location = new Point(195, 21);
            labelNumbers.Margin = new Padding(2, 0, 2, 0);
            labelNumbers.MinimumSize = new Size(84, 6);
            labelNumbers.Name = "labelNumbers";
            labelNumbers.Size = new Size(84, 15);
            labelNumbers.TabIndex = 1;
            // 
            // labelNumbersOrdered
            // 
            labelNumbersOrdered.AutoSize = true;
            labelNumbersOrdered.BackColor = SystemColors.ButtonShadow;
            labelNumbersOrdered.Location = new Point(195, 44);
            labelNumbersOrdered.Margin = new Padding(2, 0, 2, 0);
            labelNumbersOrdered.MinimumSize = new Size(84, 6);
            labelNumbersOrdered.Name = "labelNumbersOrdered";
            labelNumbersOrdered.Size = new Size(84, 15);
            labelNumbersOrdered.TabIndex = 2;
            // 
            // labelBonusNumbers
            // 
            labelBonusNumbers.AutoSize = true;
            labelBonusNumbers.BackColor = SystemColors.ButtonShadow;
            labelBonusNumbers.Location = new Point(306, 44);
            labelBonusNumbers.Margin = new Padding(2, 0, 2, 0);
            labelBonusNumbers.MinimumSize = new Size(84, 6);
            labelBonusNumbers.Name = "labelBonusNumbers";
            labelBonusNumbers.Size = new Size(84, 15);
            labelBonusNumbers.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 123);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(218, 15);
            label1.TabIndex = 4;
            label1.Text = "Sinun numerosi(erota numerot pilkulla):";
            label1.Click += label1_Click;
            // 
            // txtUserNumbers
            // 
            txtUserNumbers.Location = new Point(154, 140);
            txtUserNumbers.Margin = new Padding(2, 2, 2, 2);
            txtUserNumbers.Name = "txtUserNumbers";
            txtUserNumbers.Size = new Size(106, 23);
            txtUserNumbers.TabIndex = 5;
            txtUserNumbers.TextChanged += txtUserNumbers_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 203);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(208, 15);
            label2.TabIndex = 6;
            label2.Text = "Oikein menneiden numeroiden määrä";
            // 
            // labelCorrectNumbersAmount
            // 
            labelCorrectNumbersAmount.AutoSize = true;
            labelCorrectNumbersAmount.BackColor = SystemColors.ButtonShadow;
            labelCorrectNumbersAmount.Location = new Point(195, 231);
            labelCorrectNumbersAmount.Margin = new Padding(2, 0, 2, 0);
            labelCorrectNumbersAmount.Name = "labelCorrectNumbersAmount";
            labelCorrectNumbersAmount.Size = new Size(13, 15);
            labelCorrectNumbersAmount.TabIndex = 7;
            labelCorrectNumbersAmount.Text = "0";
            // 
            // btnDrawNumbers
            // 
            btnDrawNumbers.Location = new Point(38, 39);
            btnDrawNumbers.Margin = new Padding(2);
            btnDrawNumbers.Name = "btnDrawNumbers";
            btnDrawNumbers.Size = new Size(110, 20);
            btnDrawNumbers.TabIndex = 0;
            btnDrawNumbers.Text = "Arvo Numerot";
            btnDrawNumbers.UseVisualStyleBackColor = true;
            btnDrawNumbers.Click += btnDrawNumbers_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 368);
            Controls.Add(labelCorrectNumbersAmount);
            Controls.Add(label2);
            Controls.Add(txtUserNumbers);
            Controls.Add(label1);
            Controls.Add(labelBonusNumbers);
            Controls.Add(labelNumbersOrdered);
            Controls.Add(labelNumbers);
            Controls.Add(btnDrawNumbers);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelNumbers;
        private Label labelNumbersOrdered;
        private Label labelBonusNumbers;
        private Label label1;
        private TextBox txtUserNumbers;
        private Label label2;
        private Label labelCorrectNumbersAmount;
        private Button btnDrawNumbers;
    }
}