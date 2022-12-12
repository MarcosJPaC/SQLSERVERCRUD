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
    public partial class Mision : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Mision ORDER BY idMision");
        }

        public Mision()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            string nombre = textBox1.Text;
            string jugabilidad = textBox2.Text;
            string duracion = textBox3.Text;

            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Mision SET nombre = '" + nombre + "',jugabilidad = '" + jugabilidad + "',duracion = '" + duracion + "' WHERE idMision = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Mision_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void Mision_Load_1(object sender, EventArgs e)
        {
            MostrarDatos();

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string jugabilidad = textBox2.Text;
            string duracion = textBox3.Text;

            consulta = "INSERT INTO Mision(nombre, jugabilidad, duracion) values('" + nombre + "', '" + jugabilidad + "', '" + duracion + "')";
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            //consulta = "DELETE FROM HOTEL WHERE idHotel = " + idHotel.ToString();
            consulta = "UPDATE Mision SET estatus = 0 WHERE idMision =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {

            string nombre = textBox1.Text;
            string jugabilidad = textBox2.Text;
            string duracion = textBox3.Text;

            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Mision SET nombre = '" + nombre + "',jugabilidad = '" + jugabilidad + "',duracion = '" + duracion + "' WHERE idMision = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Modo agnt = new Modo();
            agnt.Show();

        }
    }
}
