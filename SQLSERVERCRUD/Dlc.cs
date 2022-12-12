using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLSERVERCRUD
{
    public partial class Dlc : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Dlc ORDER BY idDlc");
        }

        public Dlc()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string precio = textBox1.Text;
            string nombre = textBox2.Text;
            string fechaDeSalida = textBox3.Text;
            string idTienda = textBox4.Text;
            string idMapa = textBox5.Text;


            consulta = "INSERT INTO Dlc(precio, nombre, fechaDeSalida,idTienda,idMapa) values('" + precio + "', '" + nombre + "', '" + fechaDeSalida + "', '" + idTienda + "', '" + idMapa + "')";
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
            consulta = "UPDATE Dlc SET estatus = 0 WHERE idDlc =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string precio = textBox1.Text;
            string nombre = textBox2.Text;
            string fechaDeSalida = textBox3.Text;
            string idTienda = textBox4.Text;
            string idMapa = textBox5.Text;

            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Dlc SET precio = '" + precio + "',nombre = '" + nombre + "',fechaDeSalida = '" + fechaDeSalida + "',idTienda = '" + idTienda + "',idMapa = '" + idMapa + "' WHERE idDlc = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Emblema brr = new Emblema();
            brr.Show();
        }

        private void Dlc_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
