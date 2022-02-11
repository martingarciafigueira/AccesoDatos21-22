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
using System.Configuration;

namespace Actividad1
{
    public partial class Form1 : Form
    {
        SqlConnection conexion;
        //SqlConnection conexion = new SqlConnection("server = 'MARTIN-PC'; database = 'tienda'; integrated security = true");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Abrimos la conexión
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Actividad1.Properties.Settings.tiendaConnectionString1"].ConnectionString;
                conexion = new SqlConnection(connectionString);
                conexion.Open();
                MessageBox.Show("Todo foi ben");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexión: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Abrimos la conexión
            try
            {
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la conexión: " + ex.Message);
            }
        }

        private void btnInsertarFabricante_Click(object sender, EventArgs e)
        {
            int codigoFabricante;
            string nombreFabricante;

            int.TryParse(txtCodigo.Text, out codigoFabricante);
            nombreFabricante = txtNombre.Text;


            string consulta = "INSERT INTO fabricante VALUES (@CodigoFabricante, @NombreFabricante)";

            SqlCommand comando = new SqlCommand(consulta, conexion);

            comando.Parameters.AddWithValue("@CodigoFabricante", codigoFabricante);
            comando.Parameters.AddWithValue("@NombreFabricante", nombreFabricante);

            int registrosAfectados = comando.ExecuteNonQuery();

            if (registrosAfectados != 1)
            {
                MessageBox.Show("Me parece que la liamos");
            }
            else
            {
                MessageBox.Show("Show must go on");
            }
        }

        private void btnVerBDActualizada_Click(object sender, EventArgs e)
        {
            txtFabricantes.Text = "";
            //Construyo la consulta
            string consulta = "SELECT * FROM fabricante";

            //Ejecutamos la consulta
            SqlCommand comando = new SqlCommand(consulta, conexion);

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            using (adaptador)
            {
                //Creamos un DT para guardar la info
                DataTable dtFabricantes = new DataTable();
                adaptador.Fill(dtFabricantes);

                //Mostramos los datos que queramos en el listbox
                lstFabricantes.ValueMember = "Codigo";
                lstFabricantes.DisplayMember = "Nombre";
                lstFabricantes.DataSource = dtFabricantes.DefaultView;
            }



            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {
                txtFabricantes.AppendText("Codigo: " + registros["Codigo"].ToString());
                txtFabricantes.AppendText(" Nombre: " + registros["Nombre"].ToString());
                txtFabricantes.AppendText(" - ");
                txtFabricantes.AppendText(Environment.NewLine);
            }

            registros.Close();

        }
    }
}
