using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*GRUPO D*/
namespace PROYECTO_TELESHOPPING
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.Show();
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
