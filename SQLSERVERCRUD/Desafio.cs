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
    public partial class Desafio : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Desafio ORDER BY idDesafio");
        }

        public Desafio()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string recompensa = textBox2.Text;
            string nivelNecesario = textBox3.Text;
            string idMision = textBox4.Text;


            consulta = "INSERT INTO Desafio(nombre, recompensa, nivelNecesario,idMision) values('" + nombre + "', '" + recompensa + "', '" + nivelNecesario + "', '" + idMision + "')";
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
            consulta = "UPDATE Desafio SET estatus = 0 WHERE idDesafio =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string recompensa = textBox2.Text;
            string nivelNecesario = textBox3.Text;
            string idMision = textBox4.Text;


            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Desafio SET nombre = '" + nombre + "',recompensa = '" + recompensa + "',nivelNecesario = '" + nivelNecesario + "',idMision = '" + idMision + "' WHERE idDesafio = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Desarrollador brr = new Desarrollador();
            brr.Show();
        }

        private void Desafio_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
