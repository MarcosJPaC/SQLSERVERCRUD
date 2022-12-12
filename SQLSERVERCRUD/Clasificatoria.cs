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
    public partial class Clasificatoria : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Clasificatoria ORDER BY idClasificatoria");
        }

        public Clasificatoria()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string rangoNecesario = textBox1.Text;
            string puedeRankear = textBox2.Text;
            string rangoActual = textBox3.Text;
            string idProgreso = textBox4.Text;


            consulta = "INSERT INTO Clasificatoria(rangoNecesario, puedeRankear, rangoActual,idProgreso) values('" + rangoNecesario + "', '" + puedeRankear + "', '" + rangoActual + "', '" + idProgreso + "')";
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
            consulta = "UPDATE Clasificatoria SET estatus = 0 WHERE idClasificatoria =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string rangoNecesario = textBox1.Text;
            string puedeRankear = textBox2.Text;
            string rangoActual = textBox3.Text;
            string idProgreso = textBox4.Text;

            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Clasificatoria SET rangoNecesario = '" + rangoNecesario + "',puedeRankear = '" + puedeRankear + "',rangoActual = '" + rangoActual + "',idProgreso = '" + idProgreso + "' WHERE idClasificatoria = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clip brr = new Clip();
            brr.Show();
        }

        private void Clasificatoria_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
