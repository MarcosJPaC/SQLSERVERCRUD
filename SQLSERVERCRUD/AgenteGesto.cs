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
    public partial class AgenteGesto : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM AgenteGesto ORDER BY idAgenteGesto");
        }

        public AgenteGesto()
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
            string idGesto = textBox2.Text;

            consulta = "INSERT INTO AgenteGesto(idAgente, idGesto) values('" + idAgente + "', '" + idGesto + "')";
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            string idAgente = textBox1.Text;
            string idGesto = textBox2.Text;



            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE AgenteGesto SET idAgente = '" + idAgente + "',idGesto = '" + idGesto + "' WHERE idAgenteGesto = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            //consulta = "DELETE FROM HOTEL WHERE idHotel = " + idHotel.ToString();
            consulta = "UPDATE AgenteGesto SET estatus = 0 WHERE idAgenteGesto =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            BarraconVehiculo agnt = new BarraconVehiculo();
            agnt.Show();

        }

        private void AgenteGesto_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
