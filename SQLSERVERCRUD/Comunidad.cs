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
    public partial class Comunidad : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Comunidad ORDER BY idComunidad");
        }

        public Comunidad()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nacionalidad = textBox1.Text;
            string juego = textBox2.Text;
            string usuariosConectados = textBox3.Text;

            consulta = "INSERT INTO Comunidad(nacionalidad, juego, usuariosConectados) values('" + nacionalidad + "', '" + juego + "', '" + usuariosConectados + "')";
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            string nacionalidad = textBox1.Text;
            string juego = textBox2.Text;
            string usuariosConectados = textBox3.Text;


            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Comunidad SET nacionalidad = '" + nacionalidad + "',juego = '" + juego + "',usuariosConectados = '" + usuariosConectados + "' WHERE idComunidad = " + identificador.ToString();
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
            consulta = "UPDATE Comunidad SET estatus = 0 WHERE idComunidad =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Configuracion agnt = new Configuracion();
            agnt.Show();

        }

        private void Comunidad_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
