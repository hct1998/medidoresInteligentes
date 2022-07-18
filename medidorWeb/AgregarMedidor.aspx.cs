using medidorModel;
using medidorModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace medidorWeb
{
    public partial class AgregarMedidor : System.Web.UI.Page
    {
        private IMedidorDAL medidorDAL = new MedidorDALDB();


        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void ingresarBtn_Click(object sender, EventArgs e)
        {
            Medidor medidor = new Medidor();
            medidor.num_medidor = Convert.ToInt32(this.num_medidorTxt.Text.Trim());

            this.medidorDAL.AgregarMedidores(medidor);
            Response.Redirect("MostrarMedidores.aspx");
        }
    }
}