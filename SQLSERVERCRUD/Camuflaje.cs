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
    public partial class Camuflaje : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Camuflaje ORDER BY idCamuflaje");
        }

        public Camuflaje()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string color = textBox1.Text;
            string precio = textBox2.Text;
            string tieneAnimacion = textBox3.Text;
            string idArmerio = textBox4.Text;


            consulta = "INSERT INTO Camuflaje(color, precio, tieneAnimacion,idArmerio) values('" + color + "', '" + precio + "', '" + tieneAnimacion+ "', '" +idArmerio+ "')";
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
            consulta = "UPDATE Camuflaje SET estatus = 0 WHERE idCamuflaje =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string color = textBox1.Text;
            string precio = textBox2.Text;
            string tieneAnimacion = textBox3.Text;
            string idArmerio = textBox4.Text;

            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Camuflaje SET color = '" + color + "',precio = '" + precio + "',tieneAnimacion = '" + tieneAnimacion + "',idArmerio = '"  +idArmerio+"' WHERE idCamuflaje = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Capitulo brr = new Capitulo();
            brr.Show();
        }

        private void Camuflaje_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
