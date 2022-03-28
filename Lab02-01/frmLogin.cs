using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class frmLogin : Form
    {
        int attempt = 0;

        PrincipalMDI Empresa = new PrincipalMDI();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            String[] Usuarios = { "reynaldo", "reymar","capitanazo" };
            String[] Claves = { "123456", "123", "123456789" };

            if (Usuarios.Contains(txtUsuario.Text) && Claves.Contains(txtPassword.Text) &&
                Array.IndexOf(Usuarios, txtUsuario.Text) == Array.IndexOf(Claves, txtPassword.Text))            
            {
                Empresa.Show();
                this.Hide();
                txtUsuario.Text = "";
                txtPassword.Text = "";            
            }
            else
            {
                txtUsuario.Clear();
                txtPassword.Text = "";
                txtUsuario.Focus();
                attempt += 1;

                if(attempt == 3)
                {
                    Application.Exit();
                }
            }

            //PrincipalMDI principal = new PrincipalMDI();
            //principal.Show();
            //this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
      
    }
}
