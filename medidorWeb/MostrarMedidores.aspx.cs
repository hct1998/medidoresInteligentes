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
    public partial class MostrarMedidores : System.Web.UI.Page
    {
        private IMedidorDAL medidorDAL = new MedidorDALDB();

        private void cargaGrilla(List<Medidor> medidors)
        {
            this.grillaMedidores.DataSource = medidors;
            this.grillaMedidores.DataBind();
        }



        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.cargaGrilla();
            }

        }

        private void cargaGrilla()
        {
            List<Medidor> medidors;
            {
                medidors = this.medidorDAL.ObtenerMedidores();
            }
            this.cargaGrilla(medidors);
        }



        protected void grillaMedidores_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "eliminar")
            {
                int id_medidor = Convert.ToInt32(e.CommandArgument);
                this.medidorDAL.EliminarMedidor(id_medidor);
                this.cargaGrilla();
            }

        }
    }
}