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
    public partial class Cinematica : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Cinematica ORDER BY idCinematica");
        }

        public Cinematica()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string duracion = textBox1.Text;
            string perteneceAModo = textBox2.Text;
            string sePuedeSaltar = textBox3.Text;



            consulta = "INSERT INTO Cinematica(duracion  , perteneceAModo, sePuedeSaltar) values('" + duracion + "', '" + perteneceAModo + "', '" + sePuedeSaltar + "')";
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
            consulta = "UPDATE Cinematica SET estatus = 0 WHERE idCinematica =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string duracion = textBox1.Text;
            string perteneceAModo = textBox2.Text;
            string sePuedeSaltar = textBox3.Text;


            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Cinematica SET duracion = '" + duracion + "',perteneceAModo = '" + perteneceAModo + "',sePuedeSaltar = '" + sePuedeSaltar + "' WHERE idCinematica = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clase brr = new Clase();
            brr.Show();
        }

        private void Cinematica_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void Cinematica_Load_1(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
