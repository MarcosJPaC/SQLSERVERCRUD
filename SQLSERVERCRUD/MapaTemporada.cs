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
    public partial class MapaTemporada : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM MapaTemporada ORDER BY idMapaTemporada");
        }

        public MapaTemporada()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string idMapa = textBox1.Text;
            string idTemporada = textBox2.Text;

            consulta = "INSERT INTO MapaTemporada(idMapa, idTemporada) values('" + idMapa + "', '" + idTemporada + "')";
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            string idMapa = textBox1.Text;
            string idTemporada = textBox2.Text;



            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE MapaTemporada SET idMapa = '" + idMapa + "',idTemporada = '" + idTemporada + "' WHERE idMapaTemporada = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            //consulta = "DELETE FROM HOTEL WHERE idHotel = " + idHotel.ToString();
            consulta = "UPDATE MapaTemporada SET estatus = 0 WHERE idMapaTemporada =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           

        }

        private void MapaTemporada_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
