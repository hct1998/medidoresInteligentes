using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medidorModel.DAL
{
    public interface IUsuarioDAL
    {
        List<Usuarios> ObtenerUsuarios();

        Usuarios Obtener(int id_usuario);

        void AgregarUsuarios(Usuarios usuarios);

        void EliminarUsuarios(int id_usuario);

        void Actualizar(Usuarios a);


    }
}
