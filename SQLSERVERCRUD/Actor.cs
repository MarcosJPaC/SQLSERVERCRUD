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
    public partial class Agente : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Actor ORDER BY idActor");
        }

        public Agente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string fechaNacimiento = textBox2.Text;
            string tipoDeContrato = textBox3.Text;
            consulta = "INSERT INTO Actor(nombre, fechaNacimiento, tipoDeContrato) values('" + nombre + "', '" + fechaNacimiento + "', '" + tipoDeContrato + "')";
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string nombre = textBox1.Text;
            string fechaNacimiento = textBox2.Text;
            string tipoDeContrato = textBox3.Text;
            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Actor SET nombre = '" + nombre + "',fechaNacimiento = '" + fechaNacimiento + "',tipoDeContrato = '" + tipoDeContrato + "' WHERE idActor = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            //consulta = "DELETE FROM HOTEL WHERE idHotel = " + idHotel.ToString();
            consulta = "UPDATE Actor SET estatus = 0 WHERE idActor =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Agent agnt = new Agent();
            agnt.Show();
            
        }
    }
}
