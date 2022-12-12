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
    public partial class Barracon : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Barracon ORDER BY idBarracon");
        }

        public Barracon()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Barracon_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BattlePass btp = new BattlePass();
            btp.Show();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            string tarjetaDeVisita = textBox1.Text;
            string calidad = textBox2.Text;
            string precio = textBox3.Text;



            consulta = "INSERT INTO Barracon(tarjetaDeVisita, calidad, precio) values('" + tarjetaDeVisita + "', '" + calidad + "', '" + precio + "')";
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            //consulta = "DELETE FROM HOTEL WHERE idHotel = " + idHotel.ToString();
            consulta = "UPDATE Barracon SET estatus = 0 WHERE idBarracon =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            string tarjetaDeVisita = textBox1.Text;
            string calidad = textBox2.Text;
            string precio = textBox3.Text;
            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Barracon SET tarjetaDeVisita = '" + tarjetaDeVisita + "',calidad = '" + calidad + "',precio = '" + precio + "' WHERE idBarracon = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
