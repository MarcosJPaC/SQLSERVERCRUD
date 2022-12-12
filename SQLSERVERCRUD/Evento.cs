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
    public partial class Evento : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Evento ORDER BY idEvento");
        }

        public Evento()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string fechaInicio = textBox2.Text;
            string fechaFin = textBox3.Text;
            string idModo = textBox4.Text;


            consulta = "INSERT INTO Evento(nombre, fechaInicio, fechaFin,idModo) values('" + nombre + "', '" + fechaInicio + "', '" + fechaFin + "', '" + idModo + "')";
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
            consulta = "UPDATE Evento SET estatus = 0 WHERE idEvento =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string fechaInicio = textBox2.Text;
            string fechaFin = textBox3.Text;
            string idModo = textBox4.Text;



            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Evento SET nombre = '" + nombre + "',fechaInicio = '" + fechaInicio + "',fechaFin = '" + fechaFin + "',idModo = '" + idModo + "' WHERE idEvento = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exclusiva brr = new Exclusiva();
            brr.Show();
        }

        private void Evento_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
