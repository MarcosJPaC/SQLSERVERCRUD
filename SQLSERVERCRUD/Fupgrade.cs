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
    public partial class Fupgrade : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Fupgrade ORDER BY idFupgrade");
        }

        public Fupgrade()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string duracion = textBox1.Text;
            string nombre = textBox2.Text;
            string killsNecesarias = textBox3.Text;

            consulta = "INSERT INTO Fupgrade(duracion, nombre, killNecesarias) values('" + duracion + "', '" + nombre + "', '" + killsNecesarias + "')";
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            string duracion = textBox1.Text;
            string nombre = textBox2.Text;
            string killsNecesarias = textBox3.Text;


            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Fupgrade SET duracion = '" + duracion + "',nombre = '" + nombre + "',killNecesarias = '" + killsNecesarias + "' WHERE idFupgrade = " + identificador.ToString();
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
            consulta = "UPDATE Fupgrade SET estatus = 0 WHERE idFupgrade =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Gesto agnt = new Gesto();
            agnt.Show();

        }

        private void Fupgrade_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
