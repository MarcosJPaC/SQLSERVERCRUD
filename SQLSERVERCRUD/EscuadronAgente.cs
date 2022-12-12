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
    public partial class EscuadronAgente : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM EscuadronAgente ORDER BY idEscuadronAgente");
        }

        public EscuadronAgente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string idAgente = textBox1.Text;
            string idEscuadron = textBox2.Text;

            consulta = "INSERT INTO EscuadronAgente(idAgente, idEscuadron) values('" + idAgente + "', '" + idEscuadron + "')";
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            string idAgente = textBox1.Text;
            string idEscuadron = textBox2.Text;



            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE EscuadronAgente SET idAgente = '" + idAgente + "',idEscuadron = '" + idEscuadron + "' WHERE idEscuadronAgente = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            //consulta = "DELETE FROM HOTEL WHERE idHotel = " + idHotel.ToString();
            consulta = "UPDATE EscuadronAgente SET estatus = 0 WHERE idEscuadronAgente =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            JugadorPlataforma agnt = new JugadorPlataforma();
            agnt.Show();

        }

        private void EscuadronAgente_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
