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
    public partial class Jugador : Form
    {

        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM jugador ORDER BY idjugador");
        }

        public Jugador()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string fechaCreacion = textBox2.Text;
            string privilegios = textBox3.Text;
            string idEmblema = textBox4.Text;
            string idClub = textBox5.Text;
            string idNivel = textBox6.Text;
            string idFupgrade = textBox7.Text;
            string idProgreso = textBox8.Text;


            consulta = "INSERT INTO jugador(nombre, fechaCreacion, privilegios,idEmblema,idClub,idNivel,idFupgrade,idProgreso) values('" + nombre + "', '" + fechaCreacion + "', '" + privilegios + "', '" + idEmblema + "', '" + idClub + "', '" + idNivel + "', '" + idFupgrade + "', '" + idProgreso + "')";
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loot arm = new Loot();
            arm.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            //consulta = "DELETE FROM HOTEL WHERE idHotel = " + idHotel.ToString();
            consulta = "UPDATE jugador SET estatus = 0 WHERE idjugador =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string fechaCreacion = textBox2.Text;
            string privilegios = textBox3.Text;
            string idEmblema = textBox4.Text;
            string idClub = textBox5.Text;
            string idNivel = textBox6.Text;
            string idFupgrade = textBox5.Text;
            string idProgreso = textBox6.Text;

            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Jugador SET nombre = '" + nombre + "',fechaCreacion = '" + fechaCreacion + "',privilegios = '" + privilegios + "',idEmblema='" + idEmblema + "',idClub='" + idClub + "',idNivel='" + idNivel + "',idFupgrade='" + idFupgrade + "',idProgreso='" + idProgreso + "' WHERE idjugador = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void Jugador_Load(object sender, EventArgs e)
        {

            MostrarDatos();


        }
    }
}
