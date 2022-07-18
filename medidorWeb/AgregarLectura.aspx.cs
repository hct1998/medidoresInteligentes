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
    public partial class AgregarLectura : System.Web.UI.Page
    {

        private ILecturaDAL lecturaDAL = new LecturaDALDB();
        private IMedidorDAL medidorDAL = new MedidorDALDB();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.id_medidorDDL.DataSource = this.medidorDAL.ObtenerMedidores();
                this.id_medidorDDL.DataValueField = "id_medidor";
                this.id_medidorDDL.DataBind();
            }

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

        }

        protected void ingresarBtn_Click(object sender, EventArgs e)
        {
            Lectura lectura = new Lectura();
            lectura.id_medidor = Convert.ToInt32(this.id_medidorDDL.SelectedItem.Value);
            lectura.consumo = this.consumoTxt.Text.Trim();

            this.lecturaDAL.AgregarLecturas(lectura);
            Response.Redirect("MostrarLecturas.aspx");
        }
    }
}