namespace SwitchForm
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
            valinta1 = new Button();
            valinta2 = new Button();
            valinta3 = new Button();
            valinta4 = new Button();
            valid = new Button();
            SuspendLayout();
            // 
            // valinta1
            // 
            valinta1.Location = new Point(59, 48);
            valinta1.Name = "valinta1";
            valinta1.Size = new Size(112, 34);
            valinta1.TabIndex = 0;
            valinta1.Text = "valinta1";
            valinta1.UseVisualStyleBackColor = true;
            valinta1.MouseClick += MouseClick;
            // 
            // valinta2
            // 
            valinta2.Location = new Point(59, 100);
            valinta2.Name = "valinta2";
            valinta2.Size = new Size(112, 34);
            valinta2.TabIndex = 1;
            valinta2.Text = "valinta2";
            valinta2.UseVisualStyleBackColor = true;
            valinta2.MouseClick += MouseClick;
            // 
            // valinta3
            // 
            valinta3.Location = new Point(59, 162);
            valinta3.Name = "valinta3";
            valinta3.Size = new Size(112, 34);
            valinta3.TabIndex = 2;
            valinta3.Text = "valinta3";
            valinta3.UseVisualStyleBackColor = true;
            valinta3.MouseClick += MouseClick;
            // 
            // valinta4
            // 
            valinta4.Location = new Point(58, 222);
            valinta4.Name = "valinta4";
            valinta4.Size = new Size(112, 34);
            valinta4.TabIndex = 3;
            valinta4.Text = "valinta4";
            valinta4.UseVisualStyleBackColor = true;
            valinta4.MouseClick += MouseClick;
            // 
            // valid
            // 
            valid.Location = new Point(62, 279);
            valid.Name = "valid";
            valid.Size = new Size(112, 34);
            valid.TabIndex = 4;
            valid.Text = "default";
            valid.UseVisualStyleBackColor = true;
            valid.MouseClick += MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(valid);
            Controls.Add(valinta4);
            Controls.Add(valinta3);
            Controls.Add(valinta2);
            Controls.Add(valinta1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button valinta1;
        private Button valinta2;
        private Button valinta3;
        private Button valinta4;
        private Button valid;
    }
}