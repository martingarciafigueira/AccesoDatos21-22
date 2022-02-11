using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad7
{
    public partial class Form1 : Form
    {
        string miConexion = ConfigurationManager.ConnectionStrings["Actividad7.Properties.Settings.tiendaConnectionString"].ConnectionString;
        SqlConnection miconexionSQL;
        string consultaSELECTProductos = "SELECT * FROM producto";
        string consultaSELECTFabricantes = "SELECT * FROM fabricante";
        string consultaSELECTProductosDeFabricante = "SELECT codigo FROM producto WHERE Codigo_Fabricante = @Codigo_Fabricante";
        string consultaSELECTCodigoMaxFabricantes = "SELECT MAX(codigo) as codigo FROM fabricante";
        string consultaSELECTCodigoMaxProductos = "SELECT MAX(codigo) as codigo FROM producto";
        string consultaINSERTFabricantes = "INSERT INTO fabricante VALUES (@Codigo, @Nombre);";
        string consultaINSERTProductos = "INSERT INTO producto VALUES (@Codigo, @Nombre, @Precio, @Codigo_Fabricante)";
        string consultaUPDATEFabricantes = "UPDATE fabricante SET nombre = @Nombre WHERE codigo = @Codigo_Fabricante";
        string consultaUPDATEProductos = "UPDATE producto SET nombre = @Nombre, precio = @Precio WHERE codigo = @Codigo";
        string consultaDELETEProductos = "DELETE producto WHERE codigo = @Codigo";
        string consultaDELETEProductosDeFabricante = "DELETE producto WHERE codigo_fabricante = @codigo_fabricante";
        string consultaDELETEFabricantes = "DELETE fabricante WHERE codigo=@Codigo";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEstablecerConexion_Click(object sender, EventArgs e)
        {
            miconexionSQL = new SqlConnection(miConexion);
            miconexionSQL.Open();
            MessageBox.Show("Conexión establecida correctamente");
        }

        private void btnMostrarProductosFabricantes_Click(object sender, EventArgs e)
        {
            actualizarProductosYFabricantes();
        }

        private void btnInsertarFabricante_Click(object sender, EventArgs e)
        {
            int codigoMaximo = -1;
            string nombreFabricante = txtNombreFabricante.Text;

            //Hacemos la consulta del codigo maximo para fabricantes
            SqlCommand sqlComando = new SqlCommand(consultaSELECTCodigoMaxFabricantes, miconexionSQL);
            SqlDataReader registros = sqlComando.ExecuteReader();
            registros.Read();

            int.TryParse(registros["codigo"].ToString(), out codigoMaximo);

            registros.Close();

            //Hacemos la consulta INSERT para fabricantes
            sqlComando = new SqlCommand(consultaINSERTFabricantes, miconexionSQL);

            sqlComando.Parameters.AddWithValue("Codigo", codigoMaximo + 1);
            sqlComando.Parameters.AddWithValue("Nombre", nombreFabricante);

            int filasAfectadas = sqlComando.ExecuteNonQuery();

            if (filasAfectadas != 1)
            {
                MessageBox.Show("Algo foi mal");
            }

            actualizarListaFabricantes();
            borrarCampos();
        }

        private void btnInsertarProducto_Click(object sender, EventArgs e)
        {
            int codigoMaximo = -1;
            string nombreProducto = txtNombreProducto.Text;
            float precioProducto;
            float.TryParse(txtPrecioProducto.Text, out precioProducto);
            int codigoFabricante;

            int.TryParse(lstFabricantes.SelectedValue.ToString(), out codigoFabricante);

            //Hacemos la consulta del codigo maximo para fabricantes
            SqlCommand sqlComando = new SqlCommand(consultaSELECTCodigoMaxProductos, miconexionSQL);
            SqlDataReader registros = sqlComando.ExecuteReader();
            registros.Read();

            int.TryParse(registros["codigo"].ToString(), out codigoMaximo);

            registros.Close();

            //Hacemos la consulta INSERT para producto
            sqlComando = new SqlCommand(consultaINSERTProductos, miconexionSQL);

            sqlComando.Parameters.AddWithValue("Codigo", codigoMaximo + 1);
            sqlComando.Parameters.AddWithValue("Nombre", nombreProducto);
            sqlComando.Parameters.AddWithValue("Precio", precioProducto);
            sqlComando.Parameters.AddWithValue("Codigo_Fabricante", codigoFabricante);

            int filasAfectadas = sqlComando.ExecuteNonQuery();

            if (filasAfectadas != 1)
            {
                MessageBox.Show("Algo foi mal");
            }

            actualizarListaProductos();
            borrarCampos();
        }

        private void btnBorrarProductos_Click(object sender, EventArgs e)
        {
            int codigoProducto;
            int.TryParse(lstProductos.SelectedValue.ToString(), out codigoProducto);

            //Hacemos la consulta DELETE para producto
            SqlCommand sqlComando = new SqlCommand(consultaDELETEProductos, miconexionSQL);

            sqlComando.Parameters.AddWithValue("Codigo", codigoProducto);

            int filasAfectadas = sqlComando.ExecuteNonQuery();

            if (filasAfectadas != 1)
            {
                MessageBox.Show("Algo foi mal");
            }

            actualizarListaProductos();
        }

        private void btnBorrarFabricantes_Click(object sender, EventArgs e)
        {
            int codigoFabricante;
            int.TryParse(lstFabricantes.SelectedValue.ToString(), out codigoFabricante);

            if (comprobarFabricanteProductosAsociados(codigoFabricante))
            {
                DialogResult result = MessageBox.Show("El fabricante tiene productos asociados. Borrarlos?", "AVISO", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //Hacemos algo
                    borrarProductosDeFabricante(codigoFabricante);
                    borrarFabricante(codigoFabricante);
                    actualizarProductosYFabricantes();
                }
            }
            else
            {
                borrarFabricante(codigoFabricante);
                actualizarProductosYFabricantes();
            }
        }

        private void lstFabricantes_DoubleClick(object sender, EventArgs e)
        {
            DataRowView fabricanteSeleccionado = (DataRowView)lstFabricantes.SelectedItem;
            txtNombreFabricante.Text = fabricanteSeleccionado.Row[1].ToString();
        }

        private void btnActualizarFabricante_Click(object sender, EventArgs e)
        {
            int codigoFabricante;
            int.TryParse(lstFabricantes.SelectedValue.ToString(), out codigoFabricante);
            actualizarFabricante(codigoFabricante);
            actualizarListaFabricantes();
            borrarCampos();
        }

        public bool comprobarFabricanteProductosAsociados(int codigoFabricante)
        {
            bool tieneProductosAsociados = false;
            //Hacemos la consulta SELECT para productos
            SqlCommand sqlComando = new SqlCommand(consultaSELECTProductosDeFabricante, miconexionSQL);
            sqlComando.Parameters.AddWithValue("codigo_fabricante", codigoFabricante);
            SqlDataReader registros = sqlComando.ExecuteReader();

            tieneProductosAsociados = registros.HasRows;

            registros.Close();

            return tieneProductosAsociados;
        }

        public bool borrarFabricante(int codigoFabricante)
        {
            //Hacemos la consulta DELETE para fabricante
            SqlCommand sqlComando = new SqlCommand(consultaDELETEFabricantes, miconexionSQL);

            sqlComando.Parameters.AddWithValue("Codigo", codigoFabricante);

            int filasAfectadas = sqlComando.ExecuteNonQuery();

            if (filasAfectadas != 1) return false;
            else return true;
        }
        public void borrarProductosDeFabricante(int codigoFabricante)
        {
            //Hacemos la consulta DELETE para producto
            SqlCommand sqlComando = new SqlCommand(consultaDELETEProductosDeFabricante, miconexionSQL);

            sqlComando.Parameters.AddWithValue("codigo_fabricante", codigoFabricante);

            int filasAfectadas = sqlComando.ExecuteNonQuery();
        }

        public void actualizarListaFabricantes()
        {
            //Hacemos la consulta SELECT para fabricantes
            SqlCommand sqlComando = new SqlCommand(consultaSELECTFabricantes, miconexionSQL);
            SqlDataAdapter adaptador = new SqlDataAdapter(sqlComando);
            using (adaptador)
            {
                DataTable dtFabricantes = new DataTable();
                adaptador.Fill(dtFabricantes);

                lstFabricantes.ValueMember = "codigo";
                lstFabricantes.DisplayMember = "Nombre";
                lstFabricantes.DataSource = dtFabricantes.DefaultView;
            }
        }

        public void actualizarListaProductos()
        {
            //Hacemos la consulta SELECT para productos
            SqlCommand sqlComando = new SqlCommand(consultaSELECTProductos, miconexionSQL);
            SqlDataAdapter adaptador = new SqlDataAdapter(sqlComando);
            using (adaptador)
            {
                DataTable dtProductos = new DataTable();
                adaptador.Fill(dtProductos);

                lstProductos.ValueMember = "codigo";
                lstProductos.DisplayMember = "Nombre";
                lstProductos.DataSource = dtProductos.DefaultView;
            }
        }

        public void actualizarProductosYFabricantes()
        {
            actualizarListaFabricantes();
            actualizarListaProductos();
        }

        public bool actualizarFabricante(int codigoFabricante)
        {
            string nuevoFabricante = txtNombreFabricante.Text;

            //Hacemos la consulta INSERT para fabricantes
            SqlCommand sqlComando = new SqlCommand(consultaUPDATEFabricantes, miconexionSQL);

            sqlComando.Parameters.AddWithValue("Nombre", txtNombreFabricante.Text);
            sqlComando.Parameters.AddWithValue("Codigo_Fabricante", codigoFabricante);

            int filasAfectadas = sqlComando.ExecuteNonQuery();

            if (filasAfectadas != 1) return false;
            else return true;
        }

        public bool actualizarProducto(int codigoProducto)
        {
            string nombreProducto = txtNombreProducto.Text;
            float precioProducto;
            float.TryParse(txtPrecioProducto.Text, out precioProducto);

            //Hacemos la consulta INSERT para productos
            SqlCommand sqlComando = new SqlCommand(consultaUPDATEProductos, miconexionSQL);

            sqlComando.Parameters.AddWithValue("Nombre", nombreProducto);
            sqlComando.Parameters.AddWithValue("Precio", precioProducto);
            sqlComando.Parameters.AddWithValue("Codigo", codigoProducto);

            int filasAfectadas = sqlComando.ExecuteNonQuery();

            if (filasAfectadas != 1) return false;
            else return true;
        }

        private void lstProductos_DoubleClick(object sender, EventArgs e)
        {
            DataRowView productoSeleccionado = (DataRowView)lstProductos.SelectedItem;
            txtNombreProducto.Text = productoSeleccionado.Row[1].ToString();
            txtPrecioProducto.Text = productoSeleccionado.Row[2].ToString();
        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            int codigoProducto;
            int.TryParse(lstProductos.SelectedValue.ToString(), out codigoProducto);
            actualizarProducto(codigoProducto);
            actualizarListaProductos();
            borrarCampos();
        }
    
        public void borrarCampos()
        {
            txtNombreFabricante.Text = "";
            txtNombreProducto.Text = "";
            txtPrecioProducto.Text = "";
        }
    
    }
}
