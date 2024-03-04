namespace DictionaryForms
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
            btnMakeDictionary = new Button();
            btnAdd = new Button();
            btnSearch = new Button();
            txtKey = new TextBox();
            txtValue = new TextBox();
            txtSearchKey = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblValue = new Label();
            SuspendLayout();
            // 
            // btnMakeDictionary
            // 
            btnMakeDictionary.Location = new Point(238, 55);
            btnMakeDictionary.Name = "btnMakeDictionary";
            btnMakeDictionary.Size = new Size(168, 34);
            btnMakeDictionary.TabIndex = 0;
            btnMakeDictionary.Text = "Luo Dictionary";
            btnMakeDictionary.UseVisualStyleBackColor = true;
            btnMakeDictionary.Click += btnMakeDictionary_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(455, 195);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Lisää";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(455, 291);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Hae";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtKey
            // 
            txtKey.Location = new Point(247, 138);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(150, 31);
            txtKey.TabIndex = 3;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(247, 198);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(150, 31);
            txtValue.TabIndex = 4;
            // 
            // txtSearchKey
            // 
            txtSearchKey.Location = new Point(247, 294);
            txtSearchKey.Name = "txtSearchKey";
            txtSearchKey.Size = new Size(150, 31);
            txtSearchKey.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 138);
            label1.Name = "label1";
            label1.Size = new Size(40, 25);
            label1.TabIndex = 6;
            label1.Text = "Key";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 197);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 7;
            label2.Text = "Value";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 294);
            label3.Name = "label3";
            label3.Size = new Size(40, 25);
            label3.TabIndex = 8;
            label3.Text = "Key";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(143, 378);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 9;
            label4.Text = "Value";
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Location = new Point(247, 381);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(0, 25);
            lblValue.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblValue);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSearchKey);
            Controls.Add(txtValue);
            Controls.Add(txtKey);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(btnMakeDictionary);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMakeDictionary;
        private Button btnAdd;
        private Button btnSearch;
        private TextBox txtKey;
        private TextBox txtValue;
        private TextBox txtSearchKey;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblValue;
    }
}