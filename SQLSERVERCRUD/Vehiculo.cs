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
    public partial class Vehiculo : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Vehiculo ORDER BY idVehiculo");
        }

        public Vehiculo()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string numeroPasajeros = textBox1.Text;
            string tieneArtilleria = textBox2.Text;
            string tipo = textBox3.Text;
            string idCamuflaje = textBox4.Text;


            consulta = "INSERT INTO Vehiculo(numeroPasajeros, tieneArtilleria, tipo,idCamuflaje) values('" + numeroPasajeros + "', '" + tieneArtilleria + "', '" + tipo + "', '" + idCamuflaje + "')";
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
            consulta = "UPDATE Vehiculo SET estatus = 0 WHERE idVehiculo =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string numeroPasajeros = textBox1.Text;
            string tieneArtilleria = textBox2.Text;
            string tipo = textBox3.Text;
            string idCamuflaje = textBox4.Text;



            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Vehiculo SET numeroPasajeros = '" + numeroPasajeros + "',tieneArtilleria = '" + tieneArtilleria + "',tipo = '" + tipo + "',idCamuflaje = '" + idCamuflaje + "' WHERE idVehiculo = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ventaja brr = new Ventaja();
            brr.Show();
        }

        private void Vehiculo_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
