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

namespace lab06
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        DataSet ds = new DataSet();
        DataTable tablePerson = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String str = "Server= DESKTOP-R6BLKUN\\LOCAL;DataBase=School;Integrated Security = true;";
            con = new SqlConnection(str);
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            String sql = "select * from Person";
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            ds.Clear();

            //llenamos el dataset con una tabla llamada Person
            adapter.Fill(ds, "Person");

            //Asignamos esa tabla del dataset a un objeto Tabla
            //para trabajar directamente con el
            tablePerson = ds.Tables["Person"];

            dgvListado.DataSource = tablePerson;
            dgvListado.Update();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
           
            SqlCommand cmd = new SqlCommand("InsertPerson", con);      

            cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50 , "LastName");
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50, "FirstName");
            cmd.Parameters.Add("@HireDate", SqlDbType.Date).SourceColumn = "HireDate";
            cmd.Parameters.Add("@EnrollmentDate", SqlDbType.Date).SourceColumn = "EnrollmentDate";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = cmd;
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;

            //crearemos una fila nueva la cual insertaremos en la DB
            //esta fila debe tener la estructura correspondiente
            DataRow fila = tablePerson.NewRow();
            fila["LastName"] = txtLastName.Text;
            fila["FirstName"] = txtFirstName.Text;
            fila["HireDate"] = txtHireDate.Value;
            fila["EnrollmentDate"] = txtEnrollmentDate.Value;

            //Una vez tenemos la fila, la agregamos a la tabla Person del dataset
            tablePerson.Rows.Add(fila);

            //Actualizamos el dataset conla tabla Person
            adapter.Update(tablePerson);

            MessageBox.Show("Registro insertado");
          
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("UpdatePerson", con);

            cmd.Parameters.Add("@PersonID", SqlDbType.VarChar).SourceColumn = "PersonID";
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar).SourceColumn = "LastName";
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).SourceColumn = "FirstName";
            cmd.Parameters.Add("@HireDate", SqlDbType.Date).SourceColumn = "HireDate";
            cmd.Parameters.Add("@EnrollmentDate", SqlDbType.Date).SourceColumn = "EnrollmentDate";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand = cmd;
            adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;

            DataRow[] fila = tablePerson.Select("PersonID = '" + txtPersonID.Text + "'");
            fila[0]["LastName"] = txtLastName.Text;
            fila[0]["FirstName"] = txtFirstName.Text;
            fila[0]["HireDate"] = txtHireDate.Value;
            fila[0]["EnrollmentDate"] = txtEnrollmentDate.Value;

            adapter.Update(tablePerson);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DeletePerson", con);
            cmd.Parameters.Add("@PersonID", SqlDbType.VarChar).SourceColumn = "PersonID";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.DeleteCommand = cmd;
            adapter.DeleteCommand.CommandType = CommandType.StoredProcedure;

            DataRow[] fila = tablePerson.Select("PersonID = '" + txtPersonID.Text + "'");

            //tablePerson.Rows.Remove(file[0]);
            fila[0].Delete();

            adapter.Update(tablePerson);
        }

        private void dgvListado_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count > 0)
            {
                txtPersonID.Text = dgvListado.SelectedRows[0].Cells[0].Value.ToString();
                txtLastName.Text = dgvListado.SelectedRows[0].Cells[1].Value.ToString();
                txtFirstName.Text = dgvListado.SelectedRows[0].Cells[2].Value.ToString();

                String hideDate = dgvListado.SelectedRows[0].Cells[3].Value.ToString();
                if (String.IsNullOrEmpty(hideDate))
                {
                    txtHireDate.Checked = false;
                }
                else
                {
                    txtHireDate.Text = hideDate;
                }
                String enrollmentDate = dgvListado.SelectedRows[0].Cells[4].Value.ToString();
                if (String.IsNullOrEmpty(enrollmentDate))
                {
                    txtEnrollmentDate.Checked = false;
                }
                else
                {
                    txtEnrollmentDate.Text = enrollmentDate;
                }
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(tablePerson);
            dv.Sort = "LastName ASC";
            dgvListado.DataSource = dv;
            dgvListado.Update();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtPersonID.Text.Trim().Length > 0)
            {
                DataView dv = new DataView(tablePerson);
                dv.RowFilter = "PersonID = '" + txtPersonID.Text + "'";
                dgvListado.DataSource = dv;
                dgvListado.Update();
            }
            if (txtFirstName.Text.Trim().Length > 0)
            {
                DataView dv = new DataView(tablePerson);
                dv.RowFilter = "FirstName = '" + txtFirstName.Text + "'";
                dgvListado.DataSource = dv;
                dgvListado.Update();
            }
            if (txtLastName.Text.Trim().Length > 0)
            {
                DataView dv = new DataView(tablePerson);
                dv.RowFilter = "LastName = '" + txtLastName.Text + "'";
                dgvListado.DataSource = dv;
                dgvListado.Update();
            }
            if (txtLastName.Text.Trim().Length == 0 && txtFirstName.Text.Trim().Length == 0 && txtPersonID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese los valores segun el campo que quiere buscar.");
            }       
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPersonID.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtHireDate.Value = new DateTime(1999,01,01);
            txtEnrollmentDate.Value = new DateTime(1999,01,01); 
        }
    }
}
