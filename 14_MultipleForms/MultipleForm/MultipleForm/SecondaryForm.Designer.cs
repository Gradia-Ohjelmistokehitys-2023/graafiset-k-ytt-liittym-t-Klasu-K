namespace MultipleForm
{
    partial class SecondaryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelThisFormDataDisplay = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // labelThisFormDataDisplay
            // 
            labelThisFormDataDisplay.AutoSize = true;
            labelThisFormDataDisplay.Location = new Point(411, 82);
            labelThisFormDataDisplay.Name = "labelThisFormDataDisplay";
            labelThisFormDataDisplay.Size = new Size(0, 25);
            labelThisFormDataDisplay.TabIndex = 0;
            labelThisFormDataDisplay.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 82);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 1;
            label2.Text = "This form Data:";
            // 
            // SecondaryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(labelThisFormDataDisplay);
            Name = "SecondaryForm";
            Text = "SecondaryForm";
            Load += SecondaryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelThisFormDataDisplay;
        private Label label2;
    }
}