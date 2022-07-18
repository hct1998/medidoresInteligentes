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
    public partial class MostrarLecturas : System.Web.UI.Page
    {
        private ILecturaDAL lecturaDAL = new LecturaDALDB();

        private void cargaGrilla(List<Lectura> lecturas)
        {
            this.grillaLecturas.DataSource = lecturas;
            this.grillaLecturas.DataBind();
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
            List<Lectura> lecturas;
            {
                lecturas = this.lecturaDAL.ObtenerLecturas();
            }
            this.cargaGrilla(lecturas);
        }


        protected void grillaLecturas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "eliminar")
            {
                int id_lectura = Convert.ToInt32(e.CommandArgument);
                this.lecturaDAL.EliminarLecturas(id_lectura);
                this.cargaGrilla();
            }
        }
    }
}