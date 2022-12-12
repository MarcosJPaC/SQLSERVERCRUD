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
    public partial class Parche : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Parche ORDER BY idParche");
        }

        public Parche()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string serie = textBox1.Text;
            string fecha = textBox2.Text;
            string versión = textBox3.Text;
            string idVersion = textBox4.Text;


            consulta = "INSERT INTO Parche(serie, fecha, versión,idVersion) values('" + serie + "', '" + fecha + "', '" + versión + "', '" + idVersion + "')";
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
            consulta = "UPDATE Parche SET estatus = 0 WHERE idParche =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string serie = textBox1.Text;
            string fecha = textBox2.Text;
            string versión = textBox3.Text;
            string idVersion = textBox4.Text;



            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Parche SET serie = '" + serie + "',fecha = '" + fecha + "',versión = '" + versión + "',idVersion = '" + idVersion + "' WHERE idParche = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Partida brr = new Partida();
            brr.Show();
        }

        private void Parche_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
