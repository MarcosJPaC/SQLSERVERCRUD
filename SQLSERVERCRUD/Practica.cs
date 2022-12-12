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
    public partial class Practica : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Practica ORDER BY idPractica");
        }

        public Practica()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string stage = textBox1.Text;
            string dificultadPractica = textBox2.Text;

            consulta = "INSERT INTO Practica(stage, dificultadPractica) values('" + stage + "', '" + dificultadPractica +  "')";
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            string stage = textBox1.Text;
            string dificultadPractica = textBox2.Text;
            


            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Practica SET stage = '" + stage + "',dificultadPractica = '" + dificultadPractica +  "' WHERE idPractica = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
       
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            //consulta = "DELETE FROM HOTEL WHERE idHotel = " + idHotel.ToString();
            consulta = "UPDATE Practica SET estatus = 0 WHERE idPractica =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Prestigio agnt = new Prestigio();
            agnt.Show();

        }

        private void Practica_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
