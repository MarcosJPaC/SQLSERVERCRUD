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
    public partial class Progreso : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Progreso ORDER BY idProgreso");
        }

        public Progreso()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string misionesCompletadas = textBox1.Text;
            string mejorPuntuacion = textBox2.Text;
            string rangoAnterior = textBox3.Text;

            consulta = "INSERT INTO Progreso(misionesCompletadas, mejorPuntuacion, rangoAnterior) values('" + misionesCompletadas + "', '" + mejorPuntuacion + "', '" + rangoAnterior + "')";
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            string misionesCompletadas = textBox1.Text;
            string mejorPuntuacion = textBox2.Text;
            string rangoAnterior = textBox3.Text;


            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Progreso SET misionesCompletadas = '" + misionesCompletadas + "',mejorPuntuacion = '" + mejorPuntuacion + "',rangoAnterior = '" + rangoAnterior + "' WHERE idProgreso = " + identificador.ToString();
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
            consulta = "UPDATE Progreso SET estatus = 0 WHERE idProgreso =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Proyecto agnt = new Proyecto();
            agnt.Show();

        }

        private void Progreso_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
