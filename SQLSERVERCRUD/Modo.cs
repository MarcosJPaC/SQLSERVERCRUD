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
    public partial class Modo : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Modo ORDER BY idModo");
        }

        public Modo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string jugadoresNecesarios = textBox1.Text;
            string tamaño = textBox2.Text;
            string duracion = textBox3.Text;

            consulta = "INSERT INTO Modo(jugadoresNecesarios, tamaño, duracion) values('" + jugadoresNecesarios + "', '" + tamaño + "', '" + duracion + "')";
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            string jugadoresNecesarios = textBox1.Text;
            string tamaño = textBox2.Text;
            string duracion = textBox3.Text;

            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Modo SET jugadoresNecesarios = '" + jugadoresNecesarios + "',tamaño = '" + tamaño + "',duracion = '" + duracion + "' WHERE idModo = " + identificador.ToString();
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
            consulta = "UPDATE Modo SET estatus = 0 WHERE idModo =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Moneda agnt = new Moneda();
            agnt.Show();

        }

        private void Modo_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void Modo_Load_1(object sender, EventArgs e)
        {
            MostrarDatos();

        }
    }
}
