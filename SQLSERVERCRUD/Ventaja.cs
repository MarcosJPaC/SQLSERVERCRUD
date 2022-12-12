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
    public partial class Ventaja : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Ventaja ORDER BY idVentaja");
        }

        public Ventaja()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string tiempoDeRecarga = textBox1.Text;
            string nombre = textBox2.Text;
            string killsNecesarias = textBox3.Text;
            string idArmerio = textBox4.Text;


            consulta = "INSERT INTO Ventaja(tiempoDeRecarga, nombre, killsNecesarias,idArmerio) values('" + tiempoDeRecarga + "', '" + nombre + "', '" + killsNecesarias + "', '" + idArmerio + "')";
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
            consulta = "UPDATE Ventaja SET estatus = 0 WHERE idVentaja =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string tiempoDeRecarga = textBox1.Text;
            string nombre = textBox2.Text;
            string killsNecesarias = textBox3.Text;
            string idArmerio = textBox4.Text;



            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Ventaja SET tiempoDeRecarga = '" + tiempoDeRecarga + "',nombre = '" + nombre + "',killsNecesarias = '" + killsNecesarias + "',idArmerio = '" + idArmerio + "' WHERE idVentaja = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veersion brr = new Veersion();
            brr.Show();
        }

        private void Ventaja_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
