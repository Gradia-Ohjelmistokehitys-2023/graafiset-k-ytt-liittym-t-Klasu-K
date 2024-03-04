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
            label1.Location = new Point(239, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(252, 25);
            label1.TabIndex = 0;
            label1.Text = "Luodaan string-tyyppinen lista";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 227);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(224, 25);
            label2.TabIndex = 1;
            label2.Text = "Lisätään listaan merkkijono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 528);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 2;
            label3.Text = "Hae listasta";
            // 
            // btnCreateList
            // 
            btnCreateList.Location = new Point(301, 97);
            btnCreateList.Margin = new Padding(4, 5, 4, 5);
            btnCreateList.Name = "btnCreateList";
            btnCreateList.Size = new Size(107, 38);
            btnCreateList.TabIndex = 3;
            btnCreateList.Text = "Luo lista";
            btnCreateList.UseVisualStyleBackColor = true;
            btnCreateList.Click += btnCreateList_Click;
            // 
            // btnAddStringToList
            // 
            btnAddStringToList.Location = new Point(494, 277);
            btnAddStringToList.Margin = new Padding(4, 5, 4, 5);
            btnAddStringToList.Name = "btnAddStringToList";
            btnAddStringToList.Size = new Size(107, 38);
            btnAddStringToList.TabIndex = 4;
            btnAddStringToList.Text = "Lisää";
            btnAddStringToList.UseVisualStyleBackColor = true;
            btnAddStringToList.Click += btnAddStringToList_Click;
            // 
            // btnSearchFromList
            // 
            btnSearchFromList.Location = new Point(494, 575);
            btnSearchFromList.Margin = new Padding(4, 5, 4, 5);
            btnSearchFromList.Name = "btnSearchFromList";
            btnSearchFromList.Size = new Size(107, 38);
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
            cbStringList.Location = new Point(210, 575);
            cbStringList.Margin = new Padding(4, 5, 4, 5);
            cbStringList.Name = "cbStringList";
            cbStringList.Size = new Size(241, 33);
            cbStringList.TabIndex = 6;
            // 
            // txtStringToBeAdded
            // 
            txtStringToBeAdded.Location = new Point(210, 277);
            txtStringToBeAdded.Margin = new Padding(4, 5, 4, 5);
            txtStringToBeAdded.Name = "txtStringToBeAdded";
            txtStringToBeAdded.Size = new Size(254, 31);
            txtStringToBeAdded.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 750);
            Controls.Add(txtStringToBeAdded);
            Controls.Add(cbStringList);
            Controls.Add(btnSearchFromList);
            Controls.Add(btnAddStringToList);
            Controls.Add(btnCreateList);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
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