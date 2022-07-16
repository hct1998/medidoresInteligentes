using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medidorModel.DAL
{
    public class LecturaDALDB : ILecturaDAL
    {
        private appmedidorEntities medidorDB = new appmedidorEntities();

        public void AgregarLecturas(Lectura lecturas)
        {
            this.medidorDB.Lecturas.Add(lecturas);
            this.medidorDB.SaveChanges();
        }

        public void EliminarLecturas(int id_lectura)
        {
            Lectura lectura = this.medidorDB.Lecturas.Find(id_lectura);

            this.medidorDB.Lecturas.Remove(lectura);
            this.medidorDB.SaveChanges();
        }

        public Lectura Obtener(int id_lectura)
        {
            return this.medidorDB.Lecturas.Find(id_lectura);
        }

        public List<Lectura> ObtenerLecturas()
        {
            return this.medidorDB.Lecturas.ToList();
        }


    }
}
