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
    public partial class CapituloTemporada : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM CapituloTemporada ORDER BY idCapituloTemporada");
        }

        public CapituloTemporada()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string idCapitulo = textBox1.Text;
            string idTemporada = textBox2.Text;

            consulta = "INSERT INTO CapituloTemporada(idCapitulo, idTemporada) values('" + idCapitulo + "', '" + idTemporada + "')";
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            string idCapitulo = textBox1.Text;
            string idTemporada = textBox2.Text;



            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE CapituloTemporada SET idCapitulo = '" + idCapitulo + "',idTemporada = '" + idTemporada + "' WHERE idCapituloTemporada = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            //consulta = "DELETE FROM HOTEL WHERE idHotel = " + idHotel.ToString();
            consulta = "UPDATE CapituloTemporada SET estatus = 0 WHERE idCapituloTemporada =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DesafioBattlepass agnt = new DesafioBattlepass();
            agnt.Show();

        }

        private void Temporada_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void CapituloTemporada_Load(object sender, EventArgs e)
        {
            MostrarDatos();

        }
    }
}
