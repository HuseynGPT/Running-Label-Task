namespace Tom_And_Jerry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.Location = new Point(Random.Shared.Next(0, 350), Random.Shared.Next(0, 350));
        }
    }
}