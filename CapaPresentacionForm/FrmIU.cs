using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacionForm
{
    public partial class FrmIU : Form
    {
        public FrmIU()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CapaLogica.Contabilidad conta = new CapaLogica.Contabilidad();
            string nombre = this.txtNombre.Text;
            this.txtMensaje.Text = conta.Saludos(nombre);

            double x = double.Parse( this.txtSaldoInicial.Text);
            this.txtResultado.Text = conta.getSaldos(x).ToString();


            //llamando utilidades
            int nummes = int.Parse(this.txtNumMes.Text);
            this.txtNombreMes.Text = CapaLogica.Utilidades.getNombreDelMes (nummes);

        }
    }
}
