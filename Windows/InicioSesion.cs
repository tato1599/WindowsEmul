using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            lbdorn_nombre.Left = (this.ClientSize.Width - lbdorn_nombre.Width) / 2;
            lbdorn_nombre.Top = ((this.ClientSize.Height - lbdorn_nombre.Height) / 2) - 100;
            pbdorn_imgUser.Left = (this.ClientSize.Width - pbdorn_imgUser.Width) / 2;
            pbdorn_imgUser.Top = ((this.ClientSize.Height - pbdorn_imgUser.Height) / 2) - 200;
            tbdorn_pin.Left = (this.ClientSize.Width - tbdorn_pin.Width) / 2;
            tbdorn_pin.Top = ((this.ClientSize.Height - tbdorn_pin.Height) / 2);
            lbdorn_nombre.Text = Environment.UserName;
        }

        private void tbdorn_pin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                if (tbdorn_pin.Text == "1234")
                {
                    Program.f3 = new Principalcs();
                    Program.f3.Show();
                    this.Hide();
                   
                }
                else
                {
                    tbdorn_pin.Text = "";
                    MessageBox.Show("PIN incorrecto");
                }
            }
        }
    }
}
