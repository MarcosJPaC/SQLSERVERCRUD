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
    public partial class Racha : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Racha ORDER BY idRacha");
        }

        public Racha()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string puntosNecesaraios = textBox1.Text;
            string nivelDesbloqueo = textBox2.Text;
            string idArmerio = textBox3.Text;

            consulta = "INSERT INTO Racha(puntosNecesaraios, nivelDesbloqueo, idArmerio) values('" + puntosNecesaraios + "', '" + nivelDesbloqueo + "', '" + idArmerio + "')";
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            string puntosNecesaraios = textBox1.Text;
            string nivelDesbloqueo = textBox2.Text;
            string idArmerio = textBox3.Text;


            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Racha SET puntosNecesaraios = '" + puntosNecesaraios + "',nivelDesbloqueo = '" + nivelDesbloqueo + "',idArmerio = '" + idArmerio + "' WHERE idRacha = " + identificador.ToString();
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
            consulta = "UPDATE Racha SET estatus = 0 WHERE idRacha =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Soundtrack agnt = new Soundtrack();
            agnt.Show();

        }

        private void Racha_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
