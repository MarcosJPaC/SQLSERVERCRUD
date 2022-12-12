using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace SQLSERVERCRUD
{
    public partial class Tienda : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Tienda ORDER BY idTienda");
        }

        public Tienda()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string producto = textBox1.Text;
            string ofertas = textBox2.Text;
            string precio = textBox3.Text;

            consulta = "INSERT INTO Tienda(producto, ofertas, precio) values('" + producto + "', '" + ofertas + "', '" + precio + "')";
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            string producto = textBox1.Text;
            string ofertas = textBox2.Text;
            string precio = textBox3.Text;


            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Tienda SET producto = '" + producto + "',ofertas = '" + ofertas + "',precio = '" + precio + "' WHERE idTienda = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            //consulta = "DELETE FROM HOTEL WHERE idHotel = " + idHotel.ToString();
            consulta = "UPDATE Tienda SET estatus = 0 WHERE idTienda =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Vehiculo agnt = new Vehiculo();
            agnt.Show();

        }

        private void Tienda_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
