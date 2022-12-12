using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace SQLSERVERCRUD
{
    public partial class Moneda : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Moneda ORDER BY idMoneda");
        }

        public Moneda()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string precio = textBox2.Text;
            string idJugador = textBox3.Text;

            consulta = "INSERT INTO Moneda(nombre, precio, idJugador) values('" + nombre + "', '" + precio + "', '" + idJugador + "')";
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            string nombre = textBox1.Text;
            string precio = textBox2.Text;
            string idJugador = textBox3.Text;

            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Moneda SET nombre = '" + nombre + "',precio = '" + precio + "',idJugador = '" + idJugador + "' WHERE idMoneda = " + identificador.ToString();
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
            consulta = "UPDATE Moneda SET estatus = 0 WHERE idMoneda =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Nivel agnt = new Nivel();
            agnt.Show();

        }

        private void Moneda_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void Moneda_Load_1(object sender, EventArgs e)
        {
            MostrarDatos();

        }
    }
}
