using Finanzas6J.Modelos;
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
    public partial class FGastos : Form
    {
        public FGastos()
        {
            InitializeComponent();
        }
        public int IDGasto;
        public bool Editar;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FGastos_Load(object sender, EventArgs e)
        {
            ListarCombo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!agregar()) return;

            finalizar();
        }
        private void finalizar()
        {
            txtDescripcion.Text = "";
            txtMonto.Text = "";
            Editar = false;
            cboTipoGasto.SelectedIndex = -1;
        }
        private bool agregar()
        {
            Gasto Gasto = new Gasto
            {

                Descripcion = txtDescripcion.Text,
                Fecha = dtpFecha.Value.ToShortDateString(),
                Monto = Convert.ToDecimal(txtMonto.Text),
                IDGasto = IDGasto,
                IDTipoGasto = Convert.ToInt32(cboTipoGasto.SelectedValue)
            };
            return Gasto.Agregar(Gasto, Editar);
        }

        private void btnTipoGasto_Click(object sender, EventArgs e)
        {
            FTipoGasto frm = new FTipoGasto();
            frm.ShowDialog();
        }

        private void btnTipoGasto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                ListarCombo();
            }
        }
        private void ListarCombo()
        {
            TipoGasto.ListarCombo(cboTipoGasto);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            finalizar();
        }
    }
}
