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
    public partial class Coalicion : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Coalicion ORDER BY idCoalicion");
        }

        public Coalicion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string cantidadIntegrentes = textBox2.Text;
            string paisOrigen = textBox3.Text;
            string idAgente = textBox4.Text;


            consulta = "INSERT INTO Coalicion(nombre, cantidadIntegrentes, paisOrigen,idAgente) values('" + nombre + "', '" + cantidadIntegrentes + "', '" + paisOrigen + "', '" + idAgente + "')";
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
            consulta = "UPDATE Coalicion SET estatus = 0 WHERE idCoalicion =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string cantidadIntegrentes = textBox2.Text;
            string paisOrigen = textBox3.Text;
            string idAgente = textBox4.Text;

            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Coalicion SET nombre = '" + nombre + "',cantidadIntegrentes = '" + cantidadIntegrentes + "',paisOrigen = '" + paisOrigen + "',idAgente = '" + idAgente + "' WHERE idCoalicion = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Colaboracion brr = new Colaboracion();
            brr.Show();
        }

        private void Coalicion_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
