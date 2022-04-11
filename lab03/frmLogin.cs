using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lab03
{
    public partial class frmLogin : Form
    {
        //SQLConnection nos permite manejar el acceso al servidor
        SqlConnection conn;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            String servidor = "DESKTOP-R6BLKUN\\LOCAL";
            String bd = "School";
            String user = txtUsuario.Text;
            String pws = txtPassword.Text;

            String str = "Server=" + servidor + ";DataBase=" +
                          bd + ";Integrated Security = true";


            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                Console.WriteLine("Conectado con exito");

                try
                {
                    if (conn.State == ConnectionState.Open)
                    {


                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "LoginUsuario";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conn;

                        SqlParameter param1 = new SqlParameter();
                        param1.ParameterName = "@usuario_nombre";
                        param1.Value = user;
                        SqlParameter param2 = new SqlParameter();
                        param2.ParameterName = "@usuario_password";
                        param2.Value = pws;

                        cmd.Parameters.Add(param1);
                        cmd.Parameters.Add(param2);

                        SqlDataReader reader = cmd.ExecuteReader();

                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        int Nusuario = dt.Rows.Count;
                        Console.WriteLine(Nusuario);

                        if (Nusuario == 1)
                        {
                            Persona persona = new Persona(conn);
                            persona.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o Contraseña son incorrectas");
                        }


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al encontrar el usuario : \n" + ex.ToString());

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con el servidor : \n" + ex.ToString());
            }


        }
    }

}
