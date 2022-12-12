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
    public partial class Plataforma : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Plataforma ORDER BY idPlataforma");
        }

        public Plataforma()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string requisitos = textBox1.Text;
            string nombre = textBox2.Text;
            string idConfiguracion = textBox3.Text;
            string idVersion = textBox4.Text;


            consulta = "INSERT INTO Plataforma(requisitos, nombre, idConfiguracion,idVersion) values('" + requisitos + "', '" + nombre + "', '" + idConfiguracion + "', '" + idVersion + "')";
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
            consulta = "UPDATE Plataforma SET estatus = 0 WHERE idPlataforma =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string requisitos = textBox1.Text;
            string nombre = textBox2.Text;
            string idConfiguracion = textBox3.Text;
            string idVersion = textBox4.Text;



            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Plataforma SET requisitos = '" + requisitos + "',nombre = '" + nombre + "',idConfiguracion = '" + idConfiguracion + "',idVersion = '" + idVersion + "' WHERE idPlataforma = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Practica brr = new Practica();
            brr.Show();
        }

        private void Plataforma_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
