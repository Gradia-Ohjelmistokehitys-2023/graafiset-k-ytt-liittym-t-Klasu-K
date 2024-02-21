namespace windowsForms
{
    partial class MyForm
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
            openFileDialog1 = new OpenFileDialog();
            colorDialog1 = new ColorDialog();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            btnPoistu = new ToolStripTextBox();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripTextBox2 = new ToolStripTextBox();
            toolStripSeparator1 = new ToolStripSeparator();
            Tietoja_Info = new ToolStripTextBox();
            elokuvanTiedot = new GroupBox();
            txtElokuvanNimi = new TextBox();
            txtElokuvanID = new TextBox();
            txtElokuvanKesto = new TextBox();
            txtElokuvanJulkaisuvuosi = new TextBox();
            button2 = new Button();
            button1 = new Button();
            lblElokuvanKesto = new Label();
            lblElokuvanJulkaisuvuosi = new Label();
            lblElokuvanNimi = new Label();
            elokuvanID = new Label();
            arvio = new GroupBox();
            txtBoxElokuvanArvio = new RichTextBox();
            numArvosanaLoppu = new NumericUpDown();
            label6 = new Label();
            numArvosanaAlku = new NumericUpDown();
            label5 = new Label();
            groupBox1 = new GroupBox();
            btnPoista = new Button();
            btnTallenna = new Button();
            btnUusiTietue = new Button();
            menuStrip1.SuspendLayout();
            elokuvanTiedot.SuspendLayout();
            arvio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numArvosanaLoppu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numArvosanaAlku).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(721, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { btnPoistu });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(64, 22);
            toolStripMenuItem1.Text = "Tiedosto";
            // 
            // btnPoistu
            // 
            btnPoistu.BackColor = SystemColors.ControlLightLight;
            btnPoistu.Name = "btnPoistu";
            btnPoistu.ReadOnly = true;
            btnPoistu.Size = new Size(100, 23);
            btnPoistu.Text = "Poistu";
            btnPoistu.Click += btnPoistu_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox2, toolStripSeparator1, Tietoja_Info });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(54, 22);
            toolStripMenuItem2.Text = "Tietoja";
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.BackColor = SystemColors.ControlLightLight;
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.ReadOnly = true;
            toolStripTextBox2.Size = new Size(250, 23);
            toolStripTextBox2.Text = "Testaa tietokantayhteyttä";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(307, 6);
            // 
            // Tietoja_Info
            // 
            Tietoja_Info.BackColor = SystemColors.ControlLightLight;
            Tietoja_Info.Name = "Tietoja_Info";
            Tietoja_Info.ReadOnly = true;
            Tietoja_Info.Size = new Size(100, 23);
            Tietoja_Info.Text = "Info";
            Tietoja_Info.Click += Tietoja_Info_Click;
            // 
            // elokuvanTiedot
            // 
            elokuvanTiedot.Controls.Add(txtElokuvanNimi);
            elokuvanTiedot.Controls.Add(txtElokuvanID);
            elokuvanTiedot.Controls.Add(txtElokuvanKesto);
            elokuvanTiedot.Controls.Add(txtElokuvanJulkaisuvuosi);
            elokuvanTiedot.Controls.Add(button2);
            elokuvanTiedot.Controls.Add(button1);
            elokuvanTiedot.Controls.Add(lblElokuvanKesto);
            elokuvanTiedot.Controls.Add(lblElokuvanJulkaisuvuosi);
            elokuvanTiedot.Controls.Add(lblElokuvanNimi);
            elokuvanTiedot.Controls.Add(elokuvanID);
            elokuvanTiedot.Location = new Point(8, 22);
            elokuvanTiedot.Margin = new Padding(2, 2, 2, 2);
            elokuvanTiedot.Name = "elokuvanTiedot";
            elokuvanTiedot.Padding = new Padding(2, 2, 2, 2);
            elokuvanTiedot.Size = new Size(336, 192);
            elokuvanTiedot.TabIndex = 1;
            elokuvanTiedot.TabStop = false;
            elokuvanTiedot.Text = "Elokuvan tiedot";
            // 
            // txtElokuvanNimi
            // 
            txtElokuvanNimi.Location = new Point(125, 55);
            txtElokuvanNimi.Margin = new Padding(2, 2, 2, 2);
            txtElokuvanNimi.Name = "txtElokuvanNimi";
            txtElokuvanNimi.Size = new Size(106, 23);
            txtElokuvanNimi.TabIndex = 13;
            txtElokuvanNimi.MouseClick += txtElokuvanNimi_MouseClick;
            txtElokuvanNimi.Leave += txtElokuvanNimi_Leave;
            // 
            // txtElokuvanID
            // 
            txtElokuvanID.Location = new Point(125, 22);
            txtElokuvanID.Margin = new Padding(2, 2, 2, 2);
            txtElokuvanID.Name = "txtElokuvanID";
            txtElokuvanID.ReadOnly = true;
            txtElokuvanID.Size = new Size(106, 23);
            txtElokuvanID.TabIndex = 12;
            // 
            // txtElokuvanKesto
            // 
            txtElokuvanKesto.Location = new Point(125, 116);
            txtElokuvanKesto.Margin = new Padding(2, 2, 2, 2);
            txtElokuvanKesto.Name = "txtElokuvanKesto";
            txtElokuvanKesto.Size = new Size(106, 23);
            txtElokuvanKesto.TabIndex = 11;
            txtElokuvanKesto.MouseClick += txtElokuvanKesto_MouseClick;
            txtElokuvanKesto.Leave += txtElokuvanKesto_Leave;
            // 
            // txtElokuvanJulkaisuvuosi
            // 
            txtElokuvanJulkaisuvuosi.Location = new Point(125, 82);
            txtElokuvanJulkaisuvuosi.Margin = new Padding(2, 2, 2, 2);
            txtElokuvanJulkaisuvuosi.Name = "txtElokuvanJulkaisuvuosi";
            txtElokuvanJulkaisuvuosi.Size = new Size(106, 23);
            txtElokuvanJulkaisuvuosi.TabIndex = 10;
            txtElokuvanJulkaisuvuosi.MouseClick += txtElokuvanJulkaisuvuosi_MouseClick;
            txtElokuvanJulkaisuvuosi.Leave += txtElokuvanJulkaisuvuosi_Leave;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.Location = new Point(166, 155);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(118, 33);
            button2.TabIndex = 9;
            button2.Text = "Seuraava";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Location = new Point(30, 155);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(118, 33);
            button1.TabIndex = 8;
            button1.Text = "Edellinen";
            button1.UseVisualStyleBackColor = false;
            // 
            // lblElokuvanKesto
            // 
            lblElokuvanKesto.AutoSize = true;
            lblElokuvanKesto.Location = new Point(30, 121);
            lblElokuvanKesto.Margin = new Padding(2, 0, 2, 0);
            lblElokuvanKesto.Name = "lblElokuvanKesto";
            lblElokuvanKesto.Size = new Size(71, 15);
            lblElokuvanKesto.TabIndex = 6;
            lblElokuvanKesto.Text = "Kesto (min):";
            // 
            // lblElokuvanJulkaisuvuosi
            // 
            lblElokuvanJulkaisuvuosi.AutoSize = true;
            lblElokuvanJulkaisuvuosi.Location = new Point(30, 86);
            lblElokuvanJulkaisuvuosi.Margin = new Padding(2, 0, 2, 0);
            lblElokuvanJulkaisuvuosi.Name = "lblElokuvanJulkaisuvuosi";
            lblElokuvanJulkaisuvuosi.Size = new Size(79, 15);
            lblElokuvanJulkaisuvuosi.TabIndex = 4;
            lblElokuvanJulkaisuvuosi.Text = "Julkaisuvuosi:";
            // 
            // lblElokuvanNimi
            // 
            lblElokuvanNimi.AutoSize = true;
            lblElokuvanNimi.Location = new Point(30, 56);
            lblElokuvanNimi.Margin = new Padding(2, 0, 2, 0);
            lblElokuvanNimi.Name = "lblElokuvanNimi";
            lblElokuvanNimi.Size = new Size(36, 15);
            lblElokuvanNimi.TabIndex = 2;
            lblElokuvanNimi.Text = "Nimi:";
            // 
            // elokuvanID
            // 
            elokuvanID.AutoSize = true;
            elokuvanID.Location = new Point(30, 22);
            elokuvanID.Margin = new Padding(2, 0, 2, 0);
            elokuvanID.Name = "elokuvanID";
            elokuvanID.Size = new Size(21, 15);
            elokuvanID.TabIndex = 0;
            elokuvanID.Text = "ID:";
            // 
            // arvio
            // 
            arvio.Controls.Add(txtBoxElokuvanArvio);
            arvio.Controls.Add(numArvosanaLoppu);
            arvio.Controls.Add(label6);
            arvio.Controls.Add(numArvosanaAlku);
            arvio.Controls.Add(label5);
            arvio.Location = new Point(8, 210);
            arvio.Margin = new Padding(2, 2, 2, 2);
            arvio.Name = "arvio";
            arvio.Padding = new Padding(2, 2, 2, 2);
            arvio.Size = new Size(336, 215);
            arvio.TabIndex = 2;
            arvio.TabStop = false;
            arvio.Text = "Arvio";
            // 
            // txtBoxElokuvanArvio
            // 
            txtBoxElokuvanArvio.Location = new Point(10, 20);
            txtBoxElokuvanArvio.Margin = new Padding(2, 2, 2, 2);
            txtBoxElokuvanArvio.Name = "txtBoxElokuvanArvio";
            txtBoxElokuvanArvio.Size = new Size(304, 156);
            txtBoxElokuvanArvio.TabIndex = 5;
            txtBoxElokuvanArvio.Text = "";
            txtBoxElokuvanArvio.Leave += txtBoxElokuvanArvio_Leave;
            // 
            // numArvosanaLoppu
            // 
            numArvosanaLoppu.Location = new Point(149, 178);
            numArvosanaLoppu.Margin = new Padding(2, 2, 2, 2);
            numArvosanaLoppu.Name = "numArvosanaLoppu";
            numArvosanaLoppu.Size = new Size(47, 23);
            numArvosanaLoppu.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(132, 181);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(10, 15);
            label6.TabIndex = 3;
            label6.Text = ".";
            // 
            // numArvosanaAlku
            // 
            numArvosanaAlku.Location = new Point(74, 178);
            numArvosanaAlku.Margin = new Padding(2, 2, 2, 2);
            numArvosanaAlku.Name = "numArvosanaAlku";
            numArvosanaAlku.Size = new Size(47, 23);
            numArvosanaAlku.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 179);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 1;
            label5.Text = "Arvosana";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPoista);
            groupBox1.Controls.Add(btnTallenna);
            groupBox1.Controls.Add(btnUusiTietue);
            groupBox1.Location = new Point(372, 29);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(333, 386);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Toiminnallisuus";
            // 
            // btnPoista
            // 
            btnPoista.BackColor = Color.Firebrick;
            btnPoista.ForeColor = SystemColors.ControlLightLight;
            btnPoista.Location = new Point(45, 139);
            btnPoista.Margin = new Padding(2, 2, 2, 2);
            btnPoista.Name = "btnPoista";
            btnPoista.Size = new Size(260, 42);
            btnPoista.TabIndex = 2;
            btnPoista.Text = "Poista";
            btnPoista.UseVisualStyleBackColor = false;
            // 
            // btnTallenna
            // 
            btnTallenna.BackColor = Color.YellowGreen;
            btnTallenna.Location = new Point(45, 86);
            btnTallenna.Margin = new Padding(2, 2, 2, 2);
            btnTallenna.Name = "btnTallenna";
            btnTallenna.Size = new Size(260, 42);
            btnTallenna.TabIndex = 1;
            btnTallenna.Text = "Tallenna";
            btnTallenna.UseVisualStyleBackColor = false;
            btnTallenna.Click += btnTallenna_Click;
            // 
            // btnUusiTietue
            // 
            btnUusiTietue.BackColor = Color.Gainsboro;
            btnUusiTietue.Location = new Point(45, 31);
            btnUusiTietue.Margin = new Padding(2, 2, 2, 2);
            btnUusiTietue.Name = "btnUusiTietue";
            btnUusiTietue.Size = new Size(260, 42);
            btnUusiTietue.TabIndex = 0;
            btnUusiTietue.Text = "Uusi tietue";
            btnUusiTietue.UseVisualStyleBackColor = false;
            btnUusiTietue.Click += btnUusiTietue_Click;
            // 
            // MyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(721, 422);
            Controls.Add(groupBox1);
            Controls.Add(arvio);
            Controls.Add(elokuvanTiedot);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "MyForm";
            Text = "Tiedosto";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            elokuvanTiedot.ResumeLayout(false);
            elokuvanTiedot.PerformLayout();
            arvio.ResumeLayout(false);
            arvio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numArvosanaLoppu).EndInit();
            ((System.ComponentModel.ISupportInitialize)numArvosanaAlku).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox txtElokuvanKesto;
        public TextBox txtElokuvanID;
        public TextBox txtElokuvanNimi;
        public TextBox txtElokuvanJulkaisuvuosi;
        public RichTextBox txtBoxElokuvanArvio;

        private OpenFileDialog openFileDialog1;
        private ColorDialog colorDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripTextBox btnPoistu;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripTextBox toolStripTextBox2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripTextBox Tietoja_Info;
        private GroupBox elokuvanTiedot;
        private Label elokuvanID;
        private Label lblElokuvanKesto;
        private Label lblElokuvanJulkaisuvuosi;

        private Label lblElokuvanNimi;

        private Button button1;
        private Button button2;
        private GroupBox arvio;
        private Label label5;

        private NumericUpDown numArvosanaLoppu;
        private Label label6;
        private NumericUpDown numArvosanaAlku;
        private GroupBox groupBox1;
        private Button btnTallenna;
        private Button btnUusiTietue;
        public Button btnPoista;
    }
}