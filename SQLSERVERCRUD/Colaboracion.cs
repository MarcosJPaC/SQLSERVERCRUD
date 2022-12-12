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
    public partial class Colaboracion : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Colaboracion ORDER BY idColaboracion");
        }

        public Colaboracion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string inicioColaboracion = textBox2.Text;
            string finColaboracion = textBox3.Text;
            string idExclusiva = textBox4.Text;


            consulta = "INSERT INTO Colaboracion(nombre, inicioColaboracion, finColaboracion,idExclusiva) values('" + nombre + "', '" + inicioColaboracion + "', '" + finColaboracion + "', '" + idExclusiva + "')";
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
            consulta = "UPDATE Colaboracion SET estatus = 0 WHERE idColaboracion =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string inicioColaboracion = textBox2.Text;
            string finColaboracion = textBox3.Text;
            string idExclusiva = textBox4.Text;


            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Colaboracion SET nombre = '" + nombre + "',inicioColaboracion = '" + inicioColaboracion + "',finColaboracion = '" + finColaboracion + "',idExclusiva = '" + idExclusiva + "' WHERE idColaboracion = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Compra brr = new Compra();
            brr.Show();
        }

        private void Colaboracion_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
