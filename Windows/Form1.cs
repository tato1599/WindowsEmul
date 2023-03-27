namespace Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbdorn_hora.Left = (this.ClientSize.Width - lbdorn_hora.Width) / 2;
            lbdorn_hora.Top = ((this.ClientSize.Height - lbdorn_hora.Height) / 2)-200;
            lbdorn_hora.Text = DateTime.Now.ToString("hh:mm");
            lbdorn_fecha.Text = DateTime.Now.ToString("dddd dd 'de' MMMM");
            lbdorn_fecha.Left = (this.ClientSize.Width - lbdorn_fecha.Width) / 2;
            lbdorn_fecha.Top = ((this.ClientSize.Height - lbdorn_fecha.Height) / 2)-110;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbdorn_hora.Text = DateTime.Now.ToString("hh:mm");
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Program.f2 = new InicioSesion();
            Program.f2.Show();
            this.Hide();

        }
    }
}