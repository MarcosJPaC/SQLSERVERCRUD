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
    public partial class Ficha : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Ficha ORDER BY idFicha");
        }

        public Ficha()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string duracion = textBox1.Text;
            string valor = textBox2.Text;
            string potencia = textBox3.Text;

            consulta = "INSERT INTO Ficha(duracion, valor, potencia) values('" + duracion + "', '" + valor + "', '" + potencia + "')";
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            string duracion = textBox1.Text;
            string valor = textBox2.Text;
            string potencia = textBox3.Text;


            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Ficha SET duracion = '" + duracion + "',valor = '" + valor + "',potencia = '" + potencia + "' WHERE idFicha = " + identificador.ToString();
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
            consulta = "UPDATE Ficha SET estatus = 0 WHERE idFicha =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Fupgrade agnt = new Fupgrade();
            agnt.Show();

        }

        private void Ficha_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
