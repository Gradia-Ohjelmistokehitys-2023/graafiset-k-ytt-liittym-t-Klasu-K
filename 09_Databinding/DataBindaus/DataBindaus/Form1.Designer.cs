namespace DataBindaus
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
            txtFirstname = new TextBox();
            txtLastname = new TextBox();
            btnAdd = new Button();
            cbPersons = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 52);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 0;
            label1.Text = "Etunimi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 122);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 1;
            label2.Text = "Sukunimi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 235);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 2;
            label3.Text = "Henkilöt";
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(250, 46);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(150, 31);
            txtFirstname.TabIndex = 3;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(250, 116);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(150, 31);
            txtLastname.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(454, 117);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Lisää";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbPersons
            // 
            cbPersons.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPersons.FormattingEnabled = true;
            cbPersons.Location = new Point(250, 235);
            cbPersons.Name = "cbPersons";
            cbPersons.Size = new Size(182, 33);
            cbPersons.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbPersons);
            Controls.Add(btnAdd);
            Controls.Add(txtLastname);
            Controls.Add(txtFirstname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtFirstname;
        private TextBox txtLastname;
        private Button btnAdd;
        private ComboBox cbPersons;
    }
}