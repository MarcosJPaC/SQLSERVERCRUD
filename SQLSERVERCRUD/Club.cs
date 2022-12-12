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
    public partial class Club : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Club ORDER BY idClub");
        }

        public Club()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string integrante = textBox2.Text;
            string plataforma = textBox3.Text;
            string idComunidad = textBox4.Text;


            consulta = "INSERT INTO Club(nombre, integrante, plataforma,idComunidad) values('" + nombre + "', '" + integrante + "', '" + plataforma + "', '" + idComunidad + "')";
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
            consulta = "UPDATE Club SET estatus = 0 WHERE idClub =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string integrante = textBox2.Text;
            string plataforma = textBox3.Text;
            string idComunidad = textBox4.Text;

            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Club SET nombre = '" + nombre + "',integrante = '" + integrante + "',plataforma = '" + plataforma + "',idComunidad = '" + idComunidad + "' WHERE idClub = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Coalicion brr = new Coalicion();
            brr.Show();
        }

        private void Club_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
