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
    public partial class DesafioBattlepass : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM DesafioBattlepass ORDER BY idDesafioBattlepass");
        }

        public DesafioBattlepass()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string idDesafio = textBox1.Text;
            string idBattlePass = textBox2.Text;

            consulta = "INSERT INTO DesafioBattlepass(idDesafio, idBattlePass) values('" + idDesafio + "', '" + idBattlePass + "')";
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            string idDesafio = textBox1.Text;
            string idBattlePass = textBox2.Text;



            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE DesafioBattlepass SET idDesafio = '" + idDesafio + "',idBattlePass = '" + idBattlePass + "' WHERE idDesafioBattlepass = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            //consulta = "DELETE FROM HOTEL WHERE idHotel = " + idHotel.ToString();
            consulta = "UPDATE DesafioBattlepass SET estatus = 0 WHERE idDesafioBattlepass =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            EscuadronAgente agnt = new EscuadronAgente();
            agnt.Show();

        }

        private void DesafioBattlepass_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
