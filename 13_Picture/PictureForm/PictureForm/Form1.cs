using System.Drawing;
namespace PictureForm
{
    public partial class Form1 : Form
    {
        public Bitmap HessuHopo { get; } = new Bitmap(Properties.Resources.HessuHopo);
        public Point piste;
        public Form1()
        {
            HessuHopo.MakeTransparent(Color.Blue);
            DoubleBuffered = true;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics Graf = e.Graphics;
            Graf.DrawImage(HessuHopo, piste);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                piste = e.Location;
                Invalidate();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                piste = e.Location;
                Invalidate();
            }
        }
    }
}