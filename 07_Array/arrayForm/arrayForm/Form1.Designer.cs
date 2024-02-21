namespace arrayForm
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
            label4 = new Label();
            label5 = new Label();
            txtTaulukonKoko = new TextBox();
            txtTalletettavaNumero = new TextBox();
            txtTalletettavanIndeksi = new TextBox();
            txtTalletuspaikanHakuIndeksi = new TextBox();
            labelLadattuNumero = new Label();
            btnLuoTaulukko = new Button();
            btnTalleta = new Button();
            btnHae = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 29);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 0;
            label1.Text = "Taulukon luonti";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 96);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 1;
            label2.Text = "taulukon koko:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 188);
            label3.Name = "label3";
            label3.Size = new Size(183, 25);
            label3.TabIndex = 2;
            label3.Text = "tallennettava numero:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 230);
            label4.Name = "label4";
            label4.Size = new Size(180, 25);
            label4.TabIndex = 3;
            label4.Text = "talletuspaikan indeksi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 345);
            label5.Name = "label5";
            label5.Size = new Size(180, 25);
            label5.TabIndex = 4;
            label5.Text = "talletuspaikan indeksi";
            // 
            // txtTaulukonKoko
            // 
            txtTaulukonKoko.Location = new Point(238, 97);
            txtTaulukonKoko.Name = "txtTaulukonKoko";
            txtTaulukonKoko.Size = new Size(59, 31);
            txtTaulukonKoko.TabIndex = 5;
            // 
            // txtTalletettavaNumero
            // 
            txtTalletettavaNumero.Location = new Point(262, 193);
            txtTalletettavaNumero.Name = "txtTalletettavaNumero";
            txtTalletettavaNumero.Size = new Size(76, 31);
            txtTalletettavaNumero.TabIndex = 6;
            // 
            // txtTalletettavanIndeksi
            // 
            txtTalletettavanIndeksi.Location = new Point(260, 237);
            txtTalletettavanIndeksi.Name = "txtTalletettavanIndeksi";
            txtTalletettavanIndeksi.Size = new Size(78, 31);
            txtTalletettavanIndeksi.TabIndex = 7;
            // 
            // txtTalletuspaikanHakuIndeksi
            // 
            txtTalletuspaikanHakuIndeksi.Location = new Point(260, 345);
            txtTalletuspaikanHakuIndeksi.Name = "txtTalletuspaikanHakuIndeksi";
            txtTalletuspaikanHakuIndeksi.Size = new Size(78, 31);
            txtTalletuspaikanHakuIndeksi.TabIndex = 8;
            // 
            // labelLadattuNumero
            // 
            labelLadattuNumero.AutoSize = true;
            labelLadattuNumero.BackColor = SystemColors.ActiveBorder;
            labelLadattuNumero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLadattuNumero.Location = new Point(249, 397);
            labelLadattuNumero.MinimumSize = new Size(100, 10);
            labelLadattuNumero.Name = "labelLadattuNumero";
            labelLadattuNumero.Size = new Size(100, 32);
            labelLadattuNumero.TabIndex = 9;
            // 
            // btnLuoTaulukko
            // 
            btnLuoTaulukko.Location = new Point(350, 97);
            btnLuoTaulukko.Name = "btnLuoTaulukko";
            btnLuoTaulukko.Size = new Size(139, 34);
            btnLuoTaulukko.TabIndex = 10;
            btnLuoTaulukko.Text = "Luo Taulukko";
            btnLuoTaulukko.UseVisualStyleBackColor = true;
            btnLuoTaulukko.Click += btnLuoTaulukko_Click;
            // 
            // btnTalleta
            // 
            btnTalleta.Location = new Point(377, 244);
            btnTalleta.Name = "btnTalleta";
            btnTalleta.Size = new Size(112, 34);
            btnTalleta.TabIndex = 11;
            btnTalleta.Text = "Talleta";
            btnTalleta.UseVisualStyleBackColor = true;
            btnTalleta.Click += btnTalleta_Click;
            // 
            // btnHae
            // 
            btnHae.Location = new Point(377, 345);
            btnHae.Name = "btnHae";
            btnHae.Size = new Size(112, 34);
            btnHae.TabIndex = 12;
            btnHae.Text = "Hae";
            btnHae.UseVisualStyleBackColor = true;
            btnHae.Click += btnHae_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 450);
            Controls.Add(btnHae);
            Controls.Add(btnTalleta);
            Controls.Add(btnLuoTaulukko);
            Controls.Add(labelLadattuNumero);
            Controls.Add(txtTalletuspaikanHakuIndeksi);
            Controls.Add(txtTalletettavanIndeksi);
            Controls.Add(txtTalletettavaNumero);
            Controls.Add(txtTaulukonKoko);
            Controls.Add(label5);
            Controls.Add(label4);
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
        private Label label4;
        private Label label5;
        private TextBox txtTaulukonKoko;
        private TextBox txtTalletettavaNumero;
        private TextBox txtTalletettavanIndeksi;
        private TextBox txtTalletuspaikanHakuIndeksi;
        private Label labelLadattuNumero;
        private Button btnLuoTaulukko;
        private Button btnTalleta;
        private Button btnHae;
    }
}