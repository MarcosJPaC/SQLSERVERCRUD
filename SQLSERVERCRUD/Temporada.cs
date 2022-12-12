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
    public partial class Temporada : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Temporada ORDER BY idTemporada");
        }

        public Temporada()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreTemporada = textBox1.Text;
            string inicio = textBox2.Text;
            string final = textBox3.Text;
            string idBattlePass = textBox4.Text;
            string idDesarrollador = textBox5.Text;


            consulta = "INSERT INTO Temporada(nombreTemporada, inicio, final,idBattlePass,idDesarrollador) values('" + nombreTemporada + "', '" + inicio + "', '" + final + "', '" + idBattlePass + "', '" + idDesarrollador + "')";
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
            consulta = "UPDATE Temporada SET estatus = 0 WHERE idTemporada =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombreTemporada = textBox1.Text;
            string inicio = textBox2.Text;
            string final = textBox3.Text;
            string idBattlePass = textBox4.Text;
            string idDesarrollador = textBox5.Text;

            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Temporada SET nombreTemporada= '" + nombreTemporada + "',inicio= '" + inicio + "',final = '" + final + "',idBattlePass = '" + idBattlePass + "',idDesarrollador = '" + idDesarrollador + "' WHERE idTemporada = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tienda brr = new Tienda();
            brr.Show();
        }

        private void Temporada_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
