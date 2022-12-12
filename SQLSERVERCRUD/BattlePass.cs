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
    public partial class BattlePass : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM BattlePass ORDER BY idBattlePass");
        }

        public BattlePass()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string nivelActual = textBox2.Text;
            string recompensa = textBox3.Text;



            consulta = "INSERT INTO BattlePass(nombre  , nivelActual, recompensa) values('" + nombre + "', '" + nivelActual + "', '" + recompensa + "')";
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
            consulta = "UPDATE BattlePass SET estatus = 0 WHERE idBattlePass =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string nivelActual = textBox2.Text;
            string recompensa = textBox3.Text;

            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE BattlePass SET nombre = '" + nombre + "',nivelActual = '" + nivelActual + "',recompensa = '" + recompensa + "' WHERE idBattlePass = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Camuflaje brr = new Camuflaje();
            brr.Show();
        }

        private void BattlePass_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void BattlePass_Load_1(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
