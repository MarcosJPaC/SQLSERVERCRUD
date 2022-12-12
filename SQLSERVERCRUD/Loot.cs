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
    public partial class Loot : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Loot ORDER BY idLoot");
        }

        public Loot()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string tipo = textBox1.Text;
            string cantidad = textBox2.Text;
            string calidad = textBox3.Text;
            string idMapa = textBox4.Text;
            string idFupgrade = textBox5.Text;


            consulta = "INSERT INTO Loot(tipo, cantidad, calidad,idMapa,idFupgrade) values('" + tipo + "', '" + cantidad + "', '" + calidad + "', '" + idMapa + "', '" + idFupgrade + "')";
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
            consulta = "UPDATE Loot SET estatus = 0 WHERE idLoot =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string tipo = textBox1.Text;
            string cantidad = textBox2.Text;
            string calidad = textBox3.Text;
            string idMapa = textBox4.Text;
            string idFupgrade = textBox5.Text;

            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Loot SET tipo= '" + tipo + "',cantidad= '" + cantidad + "',calidad = '" + calidad + "',idMapa = '" + idMapa + "',idFupgrade = '" + idFupgrade + "' WHERE idLoot = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mapa brr = new mapa();
            brr.Show();
        }

        private void Loot_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
