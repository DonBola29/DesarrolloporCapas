using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentacionWeb
{
    public partial class Saludos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            CapaLogica.Contabilidad conta = new CapaLogica.Contabilidad();

            this.lblMensaje.Text =
                conta.Saludos(nombre);

            double sueldo = double.Parse(this.txtSueldo.Text);
            this.lblSueldo.Text = conta.getSaldos(sueldo).ToString();

            int mes = Convert.ToInt32(this.txtNuMes.Text);
            this.lblMes.Text = CapaLogica.Utilidades.getNombreDelMes(mes);




        }
    }
}