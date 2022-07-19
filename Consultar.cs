
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormJECOR
{
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
            //string cod = txtCodigo.Text;
            //string cadena = "select nombre from Tienda where ID =" +cod;
            //SqlCommand comando = new SqlCommand(cadena, conexion);
            //SqlDataReader Ejemplo = comando.ExecuteReader();
            //if (Ejemplo.Read())
            //{
            //    label4.Text = Ejemplo["nombre"].ToString();

            //}
            //else {
            //    MessageBox.Show("No servimos para nada compadre");
            //            conexion.Close();
            //}
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void Consultar_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DIEGUITO;DATABASE=tienda;Integrated security=true");
            conexion.Open();
            string cod = txtCodigo.Text;
            string cadena = "select nombre from clientes where codigo =" + cod;
            try
            {
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader Ejemplo = comando.ExecuteReader();
                if (Ejemplo.Read())
                {
                    label4.Text = Ejemplo["nombre"].ToString();

                }
                else
                {
                    MessageBox.Show("Error.");
                    conexion.Close();
                }
            }
            catch (Exception) {
                MessageBox.Show("Error.");
            }
        }
    }
}
