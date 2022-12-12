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
    public partial class Soundtrack : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Soundtrack ORDER BY idSoundtrack");
        }

        public Soundtrack()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string autor = textBox1.Text;
            string nombre = textBox2.Text;
            string duracion = textBox3.Text;

            consulta = "INSERT INTO Soundtrack(autor, nombre, duracion) values('" + autor + "', '" + nombre + "', '" + duracion + "')";
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            string autor = textBox1.Text;
            string nombre = textBox2.Text;
            string duracion = textBox3.Text;


            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Soundtrack SET autor = '" + autor + "',nombre = '" + nombre + "',duracion = '" + duracion + "' WHERE idSoundtrack = " + identificador.ToString();
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
            consulta = "UPDATE Soundtrack SET estatus = 0 WHERE idSoundtrack =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Suscripcion agnt = new Suscripcion();
            agnt.Show();

        }

        private void Soundtrack_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
