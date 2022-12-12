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
    public partial class Exclusiva : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Exclusiva ORDER BY idExclusiva");
        }

        public Exclusiva()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string contenido = textBox1.Text;
            string plataforma = textBox2.Text;
            string fechaInicio = textBox3.Text;
            string idModo = textBox4.Text;


            consulta = "INSERT INTO Exclusiva(contenido, plataforma, fechaInicio,idModo) values('" + contenido + "', '" + plataforma + "', '" + fechaInicio + "', '" + idModo + "')";
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
            consulta = "UPDATE Exclusiva SET estatus = 0 WHERE idExclusiva =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string contenido = textBox1.Text;
            string plataforma = textBox2.Text;
            string fechaInicio = textBox3.Text;
            string idModo = textBox4.Text;



            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Exclusiva SET contenido = '" + contenido + "',plataforma = '" + plataforma + "',fechaInicio = '" + fechaInicio + "',idModo = '" + idModo + "' WHERE idExclusiva = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ficha brr = new Ficha();
            brr.Show();
        }

        private void Exclusiva_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
