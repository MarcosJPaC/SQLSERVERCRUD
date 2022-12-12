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
    public partial class Clase : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Clase ORDER BY idClase");
        }

        public Clase()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string slot = textBox1.Text;
            string armaPrincipal = textBox2.Text;
            string armaSecundaria = textBox3.Text;
            string idArmerio = textBox4.Text;
            string idJugador = textBox5.Text;


            consulta = "INSERT INTO Clase(slot, armaPrincipal, armaSecundaria,idArmerio,idJugador) values('" + slot + "', '" + armaPrincipal + "', '" + armaSecundaria + "', '" + idArmerio + "', '" +idJugador+ "')";
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
            consulta = "UPDATE Clase SET estatus = 0 WHERE idClase =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string slot = textBox1.Text;
            string armaPrincipal = textBox2.Text;
            string armaSecundaria = textBox3.Text;
            string idArmerio = textBox4.Text;
            string idJugador = textBox5.Text;

            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Clase SET slot = '" + slot + "',armaPrincipal = '" + armaPrincipal + "',armaSecundaria = '" + armaSecundaria + "',idArmerio = '" + idArmerio + "',idJugador = '" + idJugador+"' WHERE idClase = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clasificatoria brr = new Clasificatoria();
            brr.Show();
        }

        private void Clase_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
