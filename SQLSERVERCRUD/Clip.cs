using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLSERVERCRUD
{
    public partial class Clip : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Clip ORDER BY idClip");
        }

        public Clip()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string numeroClip = textBox1.Text;
            string autor = textBox2.Text;
            string duracion = textBox3.Text;



            consulta = "INSERT INTO Clip(numeroClip  , autor, duracion) values('" + numeroClip + "', '" + autor + "', '" + duracion + "')";
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
            consulta = "UPDATE Clip SET estatus = 0 WHERE idClip =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string numeroClip = textBox1.Text;
            string autor = textBox2.Text;
            string duracion = textBox3.Text;


            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Clip SET numeroClip = '" + numeroClip + "',autor = '" + autor + "',duracion = '" + duracion + "' WHERE idClip = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Club brr = new Club();
            brr.Show();
        }

        private void Clip_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void Clip_Load_1(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
