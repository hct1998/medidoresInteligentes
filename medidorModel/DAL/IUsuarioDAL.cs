using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medidorModel.DAL
{
    public interface IUsuarioDAL
    {
        List<Usuario> ObtenerUsuarios();

        Usuario Obtener(int id_usuario);

        void AgregarUsuarios(Usuario usuarios);

        void EliminarUsuarios(int id_usuario);

        void Actualizar(Usuario a);


    }
}
