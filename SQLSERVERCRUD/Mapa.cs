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
    public partial class mapa : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM mapa ORDER BY idmapa");
        }

        public mapa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string categoria = textBox1.Text;
            string tamaño = textBox2.Text;
            string idSoundtrack = textBox3.Text;

            consulta = "INSERT INTO mapa(categoria, tamaño, idSoundtrack) values('" + categoria + "', '" + tamaño + "', '" + idSoundtrack + "')";
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            string categoria = textBox1.Text;
            string tamaño = textBox2.Text;
            string idSoundtrack = textBox3.Text;

            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE mapa SET categoria = '" + categoria + "',tamaño = '" + tamaño + "',idSoundtrack = '" + idSoundtrack + "' WHERE idmapa = " + identificador.ToString();
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
            consulta = "UPDATE mapa SET estatus = 0 WHERE idmapa =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Mision   agnt = new Mision();
            agnt.Show();

        }

        private void mapa_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void mapa_Load_1(object sender, EventArgs e)
        {
            MostrarDatos();

        }
    }
}
