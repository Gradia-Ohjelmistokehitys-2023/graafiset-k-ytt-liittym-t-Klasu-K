using System.Diagnostics;

namespace PointAndMouse
{
    public partial class Form1 : Form
    {
        Point piste = new Point(150, 60);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics Graf = e.Graphics;

            // - Pää 

            Graf.FillEllipse(Brushes.IndianRed, piste.X - 4, piste.Y - 8, 49, 49);

            Graf.DrawEllipse(Pens.Black, piste.X - 4, piste.Y - 8, 49, 49);

            // - Selkä 

            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 41,

            piste.X + 21, piste.Y + 131);

            // - Kädet 

            Graf.DrawLine(Pens.Black, piste.X - 30, piste.Y + 60,

            piste.X + 70, piste.Y + 60);

            // - Jalat 

            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131,

            piste.X - 30, piste.Y + 181);

            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131,

            piste.X + 70, piste.Y + 181);



            // Kutsutaan DrawCoordinates()-metodia. 

            DrawCordinates(Graf);
        }
        private void DrawCordinates(Graphics Graf)

        {

            // Piirretään piirtokoordinaattien arvot näytölle. 

            Graf.DrawString("(" + piste.X + " ," + piste.Y + ")",

                            new Font("Arial", 14, System.Drawing.FontStyle.Regular),

                            new SolidBrush(Color.Black), 8, 30);

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                piste = e.Location;
                Invalidate();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                piste = e.Location;
                Invalidate();
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                piste.Y += -1;
            }
            if (e.KeyCode == Keys.S)
            {
                piste.Y += 1;
            }
            if (e.KeyCode == Keys.D)
            {
                piste.X += 1;
            }
            if (e.KeyCode == Keys.A)
            {
                piste.X += -1;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Invalidate();
        }
    }
}