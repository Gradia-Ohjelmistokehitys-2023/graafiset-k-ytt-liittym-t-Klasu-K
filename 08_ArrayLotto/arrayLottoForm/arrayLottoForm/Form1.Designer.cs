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
            btnDrawNumbers = new Button();
            labelNumbers = new Label();
            labelNumbersOrdered = new Label();
            labelBonusNumbers = new Label();
            label1 = new Label();
            txtUserNumbers = new TextBox();
            label2 = new Label();
            labelCorrectNumbersAmount = new Label();
            SuspendLayout();
            // 
            // btnDrawNumbers
            // 
            btnDrawNumbers.Location = new Point(54, 65);
            btnDrawNumbers.Name = "btnDrawNumbers";
            btnDrawNumbers.Size = new Size(157, 34);
            btnDrawNumbers.TabIndex = 0;
            btnDrawNumbers.Text = "Arvo Numerot";
            btnDrawNumbers.UseVisualStyleBackColor = true;
            btnDrawNumbers.Click += btnDrawNumbers_Click;
            // 
            // labelNumbers
            // 
            labelNumbers.AutoSize = true;
            labelNumbers.BackColor = SystemColors.ButtonShadow;
            labelNumbers.Location = new Point(278, 35);
            labelNumbers.MinimumSize = new Size(120, 10);
            labelNumbers.Name = "labelNumbers";
            labelNumbers.Size = new Size(120, 25);
            labelNumbers.TabIndex = 1;
            // 
            // labelNumbersOrdered
            // 
            labelNumbersOrdered.AutoSize = true;
            labelNumbersOrdered.BackColor = SystemColors.ButtonShadow;
            labelNumbersOrdered.Location = new Point(278, 74);
            labelNumbersOrdered.MinimumSize = new Size(120, 10);
            labelNumbersOrdered.Name = "labelNumbersOrdered";
            labelNumbersOrdered.Size = new Size(120, 25);
            labelNumbersOrdered.TabIndex = 2;
            // 
            // labelBonusNumbers
            // 
            labelBonusNumbers.AutoSize = true;
            labelBonusNumbers.BackColor = SystemColors.ButtonShadow;
            labelBonusNumbers.Location = new Point(437, 74);
            labelBonusNumbers.MinimumSize = new Size(120, 10);
            labelBonusNumbers.Name = "labelBonusNumbers";
            labelBonusNumbers.Size = new Size(120, 25);
            labelBonusNumbers.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 208);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 4;
            label1.Text = "Sinun numerosi";
            // 
            // txtUserNumbers
            // 
            txtUserNumbers.Location = new Point(260, 211);
            txtUserNumbers.Name = "txtUserNumbers";
            txtUserNumbers.Size = new Size(150, 31);
            txtUserNumbers.TabIndex = 5;
            txtUserNumbers.TextChanged += txtUserNumbers_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 332);
            label2.Name = "label2";
            label2.Size = new Size(310, 25);
            label2.TabIndex = 6;
            label2.Text = "Oikein menneiden numeroiden määrä";
            // 
            // labelCorrectNumbersAmount
            // 
            labelCorrectNumbersAmount.AutoSize = true;
            labelCorrectNumbersAmount.BackColor = SystemColors.ButtonShadow;
            labelCorrectNumbersAmount.Location = new Point(278, 385);
            labelCorrectNumbersAmount.Name = "labelCorrectNumbersAmount";
            labelCorrectNumbersAmount.Size = new Size(22, 25);
            labelCorrectNumbersAmount.TabIndex = 7;
            labelCorrectNumbersAmount.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 614);
            Controls.Add(labelCorrectNumbersAmount);
            Controls.Add(label2);
            Controls.Add(txtUserNumbers);
            Controls.Add(label1);
            Controls.Add(labelBonusNumbers);
            Controls.Add(labelNumbersOrdered);
            Controls.Add(labelNumbers);
            Controls.Add(btnDrawNumbers);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDrawNumbers;
        private Label labelNumbers;
        private Label labelNumbersOrdered;
        private Label labelBonusNumbers;
        private Label label1;
        private TextBox txtUserNumbers;
        private Label label2;
        private Label labelCorrectNumbersAmount;
    }
}