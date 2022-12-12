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
    public partial class Compra : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Compra ORDER BY idCompra");
        }

        public Compra()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string precio = textBox1.Text;
            string comprasRealizadas = textBox2.Text;
            string devoluciones = textBox3.Text;
            string idJugador = textBox4.Text;


            consulta = "INSERT INTO Compra(precio, comprasRealizadas, devoluciones,idJugador) values('" + precio + "', '" + comprasRealizadas + "', '" + devoluciones + "', '" + idJugador + "')";
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
            consulta = "UPDATE Compra SET estatus = 0 WHERE idCompra =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string precio = textBox1.Text;
            string comprasRealizadas = textBox2.Text;
            string devoluciones = textBox3.Text;
            string idJugador = textBox4.Text;

            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Compra SET precio = '" + precio + "',comprasRealizadas = '" + comprasRealizadas + "',devoluciones = '" + devoluciones + "',idJugador = '" + idJugador + "' WHERE idCompra = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Comunidad brr = new Comunidad();
            brr.Show();
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
