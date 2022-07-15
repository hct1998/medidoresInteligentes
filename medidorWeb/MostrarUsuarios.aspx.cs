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
    public partial class MostrarUsuarios : System.Web.UI.Page
    {
        private IUsuarioDAL usuarioDAL = new UsuariosDALDB();

        private void cargaGrilla(List<Usuarios> usuarios)
        {
            this.grillaUsuario.DataSource = usuarios;
            this.grillaUsuario.DataBind();
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
            List<Usuarios> usuarios;
            {
                usuarios = this.usuarioDAL.ObtenerUsuarios();
            }
            this.cargaGrilla(usuarios);
        }

        private void grillaUsuario_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "eliminar")
            {
                int id_usuario = Convert.ToInt32(e.CommandArgument);
                this.usuarioDAL.EliminarUsuarios(id_usuario);
                this.cargaGrilla();
            }
        }



    }
}