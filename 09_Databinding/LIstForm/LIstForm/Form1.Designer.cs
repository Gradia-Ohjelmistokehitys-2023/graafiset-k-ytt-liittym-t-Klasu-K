namespace LIstForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCreateList = new Button();
            btnAddStringToList = new Button();
            btnSearchFromList = new Button();
            cbStringList = new ComboBox();
            txtStringToBeAdded = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 30);
            label1.Name = "label1";
            label1.Size = new Size(168, 15);
            label1.TabIndex = 0;
            label1.Text = "Luodaan string-tyyppinen lista";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 136);
            label2.Name = "label2";
            label2.Size = new Size(150, 15);
            label2.TabIndex = 1;
            label2.Text = "Lisätään listaan merkkijono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 306);
            label3.Name = "label3";
            label3.Size = new Size(150, 15);
            label3.TabIndex = 2;
            label3.Text = "Lisätään listaan merkkijono";
            // 
            // btnCreateList
            // 
            btnCreateList.Location = new Point(211, 58);
            btnCreateList.Name = "btnCreateList";
            btnCreateList.Size = new Size(75, 23);
            btnCreateList.TabIndex = 3;
            btnCreateList.Text = "Luo lista";
            btnCreateList.UseVisualStyleBackColor = true;
            btnCreateList.Click += btnCreateList_Click;
            // 
            // btnAddStringToList
            // 
            btnAddStringToList.Location = new Point(346, 166);
            btnAddStringToList.Name = "btnAddStringToList";
            btnAddStringToList.Size = new Size(75, 23);
            btnAddStringToList.TabIndex = 4;
            btnAddStringToList.Text = "Lisää";
            btnAddStringToList.UseVisualStyleBackColor = true;
            btnAddStringToList.Click += btnAddStringToList_Click;
            // 
            // btnSearchFromList
            // 
            btnSearchFromList.Location = new Point(346, 345);
            btnSearchFromList.Name = "btnSearchFromList";
            btnSearchFromList.Size = new Size(75, 23);
            btnSearchFromList.TabIndex = 5;
            btnSearchFromList.Text = "Haku";
            btnSearchFromList.UseVisualStyleBackColor = true;
            btnSearchFromList.Click += btnSearchFromList_Click;
            // 
            // cbStringList
            // 
            cbStringList.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStringList.FormattingEnabled = true;
            cbStringList.Items.AddRange(new object[] { "aa", "bb", "cc" });
            cbStringList.Location = new Point(147, 345);
            cbStringList.Name = "cbStringList";
            cbStringList.Size = new Size(170, 23);
            cbStringList.TabIndex = 6;
            // 
            // txtStringToBeAdded
            // 
            txtStringToBeAdded.Location = new Point(147, 166);
            txtStringToBeAdded.Name = "txtStringToBeAdded";
            txtStringToBeAdded.Size = new Size(179, 23);
            txtStringToBeAdded.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 450);
            Controls.Add(txtStringToBeAdded);
            Controls.Add(cbStringList);
            Controls.Add(btnSearchFromList);
            Controls.Add(btnAddStringToList);
            Controls.Add(btnCreateList);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCreateList;
        private Button btnAddStringToList;
        private Button btnSearchFromList;
        private ComboBox cbStringList;
        private TextBox txtStringToBeAdded;
    }
}