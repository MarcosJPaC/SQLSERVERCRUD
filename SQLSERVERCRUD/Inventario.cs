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
    public partial class Inventario : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Inventario ORDER BY idInventario");
        }

        public Inventario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string calidad = textBox1.Text;
            string objeto = textBox2.Text;
            string cantidad = textBox3.Text;

            consulta = "INSERT INTO Inventario(calidad, objeto, cantidad) values('" + calidad + "', '" + objeto + "', '" + cantidad + "')";
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            string calidad = textBox1.Text;
            string objeto = textBox2.Text;
            string cantidad = textBox3.Text;

            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Inventario SET calidad = '" + calidad + "',objeto = '" + objeto + "',cantidad = '" + cantidad + "' WHERE idInventario = " + identificador.ToString();
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
            consulta = "UPDATE Inventario SET estatus = 0 WHERE idInventario =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Jugador agnt = new Jugador();
            agnt.Show();

        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
