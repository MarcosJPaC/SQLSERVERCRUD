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
    public partial class Nivel : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Nivel ORDER BY idNivel");
        }

        public Nivel()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string identificad = textBox1.Text;
            string recompensa = textBox2.Text;
            string desbloqueo = textBox3.Text;
            string idFicha = textBox4.Text;
            string idPrestigio = textBox5.Text;


            consulta = "INSERT INTO Nivel(identificador, recompensa, desbloqueo,idFicha,idPrestigio) values('" + identificad + "', '" + recompensa + "', '" + desbloqueo + "', '" + idFicha + "', '" + idPrestigio + "')";
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
            consulta = "UPDATE Nivel SET estatus = 0 WHERE idNivel =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string identificad = textBox1.Text;
            string recompensa = textBox2.Text;
            string desbloqueo = textBox3.Text;
            string idFicha = textBox4.Text;
            string idPrestigio = textBox5.Text;

            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Nivel SET identificador= '" + identificad + "',recompensa= '" + recompensa + "',desbloqueo = '" + desbloqueo + "',idFicha = '" + idFicha + "',idPrestigio = '" + idPrestigio + "' WHERE idNivel = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Parche brr = new Parche();
            brr.Show();
        }

        private void Nivel_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
