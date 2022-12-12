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
    public partial class Proyecto : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Proyecto ORDER BY idProyecto");
        }

        public Proyecto()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string arma = textBox2.Text;
            string precio = textBox3.Text;
            string idTienda = textBox4.Text;


            consulta = "INSERT INTO Proyecto(nombre, arma, precio,idTienda) values('" + nombre + "', '" + arma + "', '" + precio + "', '" + idTienda + "')";
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
            consulta = "UPDATE Proyecto SET estatus = 0 WHERE idProyecto =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string arma = textBox2.Text;
            string precio = textBox3.Text;
            string idTienda = textBox4.Text;



            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Proyecto SET nombre = '" + nombre + "',arma = '" + arma + "',precio = '" + precio + "',idTienda = '" + idTienda + "' WHERE idProyecto = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Racha brr = new Racha();
            brr.Show();
        }

        private void Proyecto_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
