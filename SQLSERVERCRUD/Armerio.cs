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
    public partial class Armerio : Form
    {
        string consulta;
        private void MostrarDatos()
        {
            dataGridView1.DataSource = ConexionSqlSever.ejecutaConsultaSelect("SELECT *FROM Armerio ORDER BY idArmerio");
        }

        public Armerio()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string slot = textBox1.Text;
            string armas = textBox2.Text;
            string mejoras = textBox3.Text;



            consulta = "INSERT INTO Armerio(slot, armas, mejoras) values('" + slot + "', '" + armas + "', '" + mejoras +  "')";
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
            consulta = "UPDATE Armerio SET estatus = 0 WHERE idArmerio =  " + identificador.ToString(); ;
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string slot = textBox1.Text;
            string armas = textBox2.Text;
            string mejoras = textBox3.Text;
            int identificador = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Armerio SET slot = '" + slot + "',armas = '" + armas + "',mejoras = '" + mejoras + "' WHERE idArmerio = " + identificador.ToString();
            ConexionSqlSever.ejecutaConsulta(consulta);
            MostrarDatos();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Barracon brr = new Barracon();
            brr.Show();
        }

        private void Armerio_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
    }
}
