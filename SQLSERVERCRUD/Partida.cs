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
    public partial class Partida : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Partida ORDER BY idPartida");
        }

        public Partida()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string cantidadJugadores = textBox1.Text;
            string duracion = textBox2.Text;
            string squadGanador = textBox3.Text;
            string idCinematica = textBox4.Text;
            string idPractica = textBox5.Text;


            consulta = "INSERT INTO Partida(cantidadJugadores, duracion, squadGanador,idCinematica,idPractica) values('" + cantidadJugadores + "', '" + duracion + "', '" + squadGanador + "', '" + idCinematica + "', '" + idPractica + "')";
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
            consulta = "UPDATE Partida SET estatus = 0 WHERE idPartida =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string cantidadJugadores = textBox1.Text;
            string duracion = textBox2.Text;
            string squadGanador = textBox3.Text;
            string idCinematica = textBox4.Text;
            string idPractica = textBox5.Text;

            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Partida SET cantidadJugadores= '" + cantidadJugadores + "',duracion= '" + duracion + "',squadGanador = '" + squadGanador + "',idCinematica = '" + idCinematica + "',idPractica = '" + idPractica + "' WHERE idPartida = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Plataforma brr = new Plataforma();
            brr.Show();
        }

        private void Partida_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
