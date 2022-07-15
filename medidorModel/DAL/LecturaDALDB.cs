using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medidorModel.DAL
{
    class LecturaDALDB
    {
        private appmedidoresEntities medidorDB = new appmedidoresEntities();

        public void AgregarLectura(Lectura lectura)
        {
            this.medidorDB.Lectura.Add(lectura);
            this.medidorDB.SaveChanges();
        }

        public void EliminarLectura(int id_lectura)
        {
            Lectura lectura = this.medidorDB.Lectura.Find(id_lectura);

            this.medidorDB.Lectura.Remove(lectura);
            this.medidorDB.SaveChanges();
        }

        public Lectura Obtener(int id_lectura)
        {
            return this.medidorDB.Lectura.Find(id_lectura);
        }

        public List<Lectura> ObtennerLectura()
        {
            return this.medidorDB.Lectura.ToList();
        }


    }
}
