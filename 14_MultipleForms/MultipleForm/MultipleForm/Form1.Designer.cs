namespace MultipleForm
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
            txtSecondaryformDataInput = new TextBox();
            btnNewForm = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtSecondaryformDataInput
            // 
            txtSecondaryformDataInput.Location = new Point(347, 87);
            txtSecondaryformDataInput.Name = "txtSecondaryformDataInput";
            txtSecondaryformDataInput.Size = new Size(150, 31);
            txtSecondaryformDataInput.TabIndex = 0;
            // 
            // btnNewForm
            // 
            btnNewForm.Location = new Point(526, 84);
            btnNewForm.Name = "btnNewForm";
            btnNewForm.Size = new Size(174, 34);
            btnNewForm.TabIndex = 1;
            btnNewForm.Text = "Create new form";
            btnNewForm.UseVisualStyleBackColor = true;
            btnNewForm.Click += btnNewForm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 87);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 2;
            label1.Text = "Data to new form:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnNewForm);
            Controls.Add(txtSecondaryformDataInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSecondaryformDataInput;
        private Button btnNewForm;
        private Label label1;
    }
}