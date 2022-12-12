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
    public partial class Escuadron : Form
    {

        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Escuadron ORDER BY idEscuadron");
        }

        public Escuadron()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string integrantes = textBox2.Text;
            string idAgente = textBox3.Text;
            string idModo = textBox4.Text;
            string idPartida = textBox5.Text;
            


            consulta = "INSERT INTO Escuadron(nombre, integrantes, idAgente,idModo,idPartida) values('" + nombre + "', '" + integrantes + "', '" + idAgente + "', '" + idModo + "', '" + idPartida + "')";
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Evento arm = new Evento();
            arm.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            //consulta = "DELETE FROM HOTEL WHERE idHotel = " + idHotel.ToString();
            consulta = "UPDATE Escuadron SET estatus = 0 WHERE idEscuadron =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string integrantes = textBox2.Text;
            string idAgente = textBox3.Text;
            string idModo = textBox4.Text;
            string idPartida = textBox5.Text;

            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Escuadron SET nombre = '" + nombre + "',integrantes = '" + integrantes + "',idAgente = '" + idAgente + "',idModo='" + idModo + "',idPartida='" + idPartida + "' WHERE idEscuadron = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void Escuadron_Load(object sender, EventArgs e)
        {

            MostrarDatos();


        }
    }
}
