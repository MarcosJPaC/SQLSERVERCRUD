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
    public partial class Emblema : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Emblema ORDER BY idEmblema");
        }

        public Emblema()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string color = textBox1.Text;
            string tamaño = textBox2.Text;
            string figura = textBox3.Text;



            consulta = "INSERT INTO Emblema(color  , tamaño, figura) values('" + color + "', '" + tamaño + "', '" + figura + "')";
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
            consulta = "UPDATE Emblema SET estatus = 0 WHERE idEmblema =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string color = textBox1.Text;
            string tamaño = textBox2.Text;
            string figura = textBox3.Text;

            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Emblema SET color = '" + color + "',tamaño = '" + tamaño + "',figura = '" + figura + "' WHERE idEmblema = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Escuadron brr = new Escuadron();
            brr.Show();
        }

        private void Emblema_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void Emblema_Load_1(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
