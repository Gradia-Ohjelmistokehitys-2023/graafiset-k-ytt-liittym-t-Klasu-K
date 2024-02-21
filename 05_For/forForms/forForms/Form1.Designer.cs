namespace forForms
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
            btnStart = new Button();
            txtInput = new TextBox();
            labelNumber = new Label();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(247, 33);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(112, 34);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(48, 36);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(150, 31);
            txtInput.TabIndex = 1;
            txtInput.Text = "10";
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumber.Location = new Point(195, 160);
            labelNumber.MaximumSize = new Size(100, 0);
            labelNumber.MinimumSize = new Size(300, 100);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(300, 106);
            labelNumber.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelNumber);
            Controls.Add(txtInput);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private TextBox txtInput;
        protected internal Label labelNumber;
    }
}