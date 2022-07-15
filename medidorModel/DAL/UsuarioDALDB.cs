using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medidorModel.DAL
{
    class UsuarioDALDB
    {
        private appmedidoresEntities medidorDB = new appmedidoresEntities();

        public void Actualizar(Usuarios a)
        {
            Usuarios aOriginal = this.medidorDB.Usuarios.Find(a.id_usuario);
            aOriginal.nombre = a.nombre;
            aOriginal.apellido = a.apellido;
            aOriginal.rut = a.rut;
            aOriginal.password = a.password;
            aOriginal.correo = a.correo;
            this.medidorDB.SaveChanges();
        }

        public void AgregarUsuarios(Usuarios usuarios)
        {
            this.medidorDB.Usuarios.Add(usuarios);
            this.medidorDB.SaveChanges();
        }



    }
}
