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
    public partial class Prestigio : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Prestigio ORDER BY idPrestigio");
        }

        public Prestigio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string nivelPrestigio = textBox2.Text;
            string prestigioAnterior = textBox3.Text;

            consulta = "INSERT INTO Prestigio(nombre, nivelPrestigio, prestigioAnterior) values('" + nombre + "', '" + nivelPrestigio + "', '" + prestigioAnterior + "')";
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            string nombre = textBox1.Text;
            string nivelPrestigio = textBox2.Text;
            string prestigioAnterior = textBox3.Text;


            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Prestigio SET nombre = '" + nombre + "',nivelPrestigio = '" + nivelPrestigio + "',prestigioAnterior = '" + prestigioAnterior + "' WHERE idPrestigio = " + identificador.ToString();
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
            consulta = "UPDATE Prestigio SET estatus = 0 WHERE idPrestigio =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Progreso agnt = new Progreso();
            agnt.Show();

        }

        private void Prestigio_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
