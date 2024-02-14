using Finanzas6J.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finanzas6J
{
    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FIngreso frm = new FIngreso();
            frm.ShowDialog();
        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {
            txtAño.Text = DateTime.Now.Year.ToString();
            cboMes.SelectedIndex = (DateTime.Now.Month - 1);
            ListarMovimiento();
            
        }

        private void ListarMovimiento()
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("@Mes",(cboMes.SelectedIndex + 1)),
                new Parametro("@Año",txtAño.Text)
            };
            dgvMovimiento.DataSource = DBDatos.Listar("Movimiento_Listar",parametros);
            DBDatos.OcultarIds(dgvMovimiento);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarMovimiento();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FGastos frm = new FGastos();
            frm.ShowDialog();
        }
    }
}
