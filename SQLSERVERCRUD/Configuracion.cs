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
    public partial class Configuracion : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Configuracion ORDER BY idConfiguracion");
        }

        public Configuracion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nivelDeBrillo = textBox1.Text;
            string sensibilidad = textBox2.Text;
            string idioma = textBox3.Text;

            consulta = "INSERT INTO Configuracion(nivelDeBrillo, sensibilidad, idioma) values('" + nivelDeBrillo + "', '" + sensibilidad + "', '" + idioma + "')";
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            string nivelDeBrillo = textBox1.Text;
            string sensibilidad = textBox2.Text;
            string idioma = textBox3.Text;



            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Configuracion SET nivelDeBrillo = '" + nivelDeBrillo + "',sensibilidad = '" + sensibilidad + "',idioma = '" + idioma + "' WHERE idConfiguracion = " + identificador.ToString();
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
            consulta = "UPDATE Configuracion SET estatus = 0 WHERE idConfiguracion =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Desafio agnt = new Desafio();
            agnt.Show();

        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
