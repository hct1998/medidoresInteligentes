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
    public partial class CrearUsuario : System.Web.UI.Page
    {

        private IUsuarioDAL usuarioDAL = new UsuariosDALDB();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.nombre = this.nombreTxt.Text.Trim();
            usuarios.apellido = this.apellidoTxt.Text.Trim();
            usuarios.rut = this.rutTxt.Text.Trim();
            usuarios.password = this.passwordTxt.Text.Trim();
            usuarios.correo = this.correoTxt.Text.Trim();

            this.usuarioDAL.AgregarUsuarios(usuarios);
            Response.Redirect("MostrarUsuarios.aspx");

        }



    }
}