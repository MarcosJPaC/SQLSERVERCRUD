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
    public partial class Agent : Form
    {
        
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Agente ORDER BY idAgente");
        }

        public Agent()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string edad = textBox2.Text;
            string nacionalidad = textBox3.Text;
            string idActor = textBox4.Text;
            string idBarracon = textBox5.Text;
            string idInventario = textBox6.Text;


            consulta = "INSERT INTO Agente(nombre, edad, nacionalidad,idActor,idBarracon,idInventario) values('" + nombre + "', '" + edad + "', '" + nacionalidad+ "', '" + idActor + "', '" +idBarracon + "', '" +idInventario +"')";
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Armerio arm = new Armerio();
            arm.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            //consulta = "DELETE FROM HOTEL WHERE idHotel = " + idHotel.ToString();
            consulta = "UPDATE Agente SET estatus = 0 WHERE idAgente =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string edad = textBox2.Text;
            string nacionalidad = textBox3.Text;
            string idActor = textBox4.Text;
            string idBarracon = textBox5.Text;
            string idInventario = textBox6.Text;
            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Agente SET nombre = '" + nombre + "',edad = '" + edad + "',nacionalidad = '" + nacionalidad +"',idActor='"+idActor+"',idBarracon='"+idBarracon +"',idInventario='" + idInventario +"' WHERE idAgente = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void Agent_Load(object sender, EventArgs e)
        {
            
            MostrarDatos();
            

        }
    }
}
