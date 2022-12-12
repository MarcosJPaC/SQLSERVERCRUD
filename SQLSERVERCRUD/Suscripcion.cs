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
    public partial class Suscripcion : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Suscripcion ORDER BY idSuscripcion");
        }

        public Suscripcion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string precio = textBox1.Text;
            string tipo = textBox2.Text;
            string idBattlePass = textBox3.Text;

            consulta = "INSERT INTO Suscripcion(precio, tipo, idBattlePass) values('" + precio + "', '" + tipo + "', '" + idBattlePass + "')";
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            string precio = textBox1.Text;
            string tipo = textBox2.Text;
            string idBattlePass = textBox3.Text;


            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Suscripcion SET precio = '" + precio + "',tipo = '" + tipo + "',idBattlePass = '" + idBattlePass + "' WHERE idSuscripcion = " + identificador.ToString();
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
            consulta = "UPDATE Suscripcion SET estatus = 0 WHERE idSuscripcion =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Temporada agnt = new Temporada();
            agnt.Show();

        }

        private void Suscripcion_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
