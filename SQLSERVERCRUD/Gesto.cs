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
    public partial class Gesto : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Gesto ORDER BY idGesto");
        }

        public Gesto()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string calidad = textBox1.Text;
            string temporadaSalida = textBox2.Text;
            string tipo = textBox3.Text;
            string idAgente = textBox4.Text;


            consulta = "INSERT INTO Gesto(calidad, temporadaSalida, tipo,idAgente) values('" + calidad + "', '" + temporadaSalida + "', '" + tipo + "', '" + idAgente + "')";
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
            consulta = "UPDATE Gesto SET estatus = 0 WHERE idGesto =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string calidad = textBox1.Text;
            string temporadaSalida = textBox2.Text;
            string tipo = textBox3.Text;
            string idAgente = textBox4.Text;



            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Gesto SET calidad = '" + calidad + "',temporadaSalida = '" + temporadaSalida + "',tipo = '" + tipo + "',idAgente = '" + idAgente + "' WHERE idGesto = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inventario brr = new Inventario();
            brr.Show();
        }

        private void Gesto_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
