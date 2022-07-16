using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medidorModel.DAL
{
    public class UsuariosDALDB : IUsuarioDAL
    {
        private appmedidorEntities medidorDB = new appmedidorEntities();

        public void Actualizar(Usuario a)
        {
            Usuario aOriginal = this.medidorDB.Usuarios.Find(a.id_usuario);
            aOriginal.nombre = a.nombre;
            aOriginal.apellido = a.apellido;
            aOriginal.rut = a.rut;
            aOriginal.password = a.password;
            aOriginal.correo = a.correo;
            this.medidorDB.SaveChanges();
        }

        public void AgregarUsuarios(Usuario usuarios)
        {
            this.medidorDB.Usuarios.Add(usuarios);
            this.medidorDB.SaveChanges();
        }

        public void EliminarUsuarios(int id_usuario)
        {
            Usuario usuarios = this.medidorDB.Usuarios.Find(id_usuario);

            this.medidorDB.Usuarios.Remove(usuarios);
            this.medidorDB.SaveChanges();
        }

        public Usuario Obtener(int id_usuario)
        {
            return this.medidorDB.Usuarios.Find(id_usuario);
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return this.medidorDB.Usuarios.ToList();
        }

    }
}
