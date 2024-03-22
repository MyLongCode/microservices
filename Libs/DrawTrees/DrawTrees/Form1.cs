namespace DrawTrees
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            int xStart = 300;
            int yStart = 30;
            int d_x = 0;
            g.DrawLine(Pens.Black, new Point(xStart, yStart), new Point(xStart, yStart+10));
            for(int i = 0; i < 10; i++)
            {
                g.DrawLine(Pens.Black, new Point(xStart + d_x, yStart), new Point(xStart+ d_x + 10, yStart+10));
                g.DrawLine(Pens.Black, new Point(xStart - d_x, yStart), new Point(xStart - d_x + 10, yStart + 10));
                g.DrawLine(Pens.Black, new Point(xStart + d_x, yStart), new Point(xStart + d_x - 10, yStart + 10));
                g.DrawLine(Pens.Black, new Point(xStart - d_x, yStart), new Point(xStart - d_x - 10, yStart + 10));
                d_x += 10;
                yStart += 10;
            }
        }
    }
}