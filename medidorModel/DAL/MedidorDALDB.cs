using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medidorModel.DAL
{
    class MedidorDALDB
    {
        private appmedidoresEntities medidorDB = new appmedidoresEntities();

       

        public void AgregarMedidor(Medidor medidor)
        {
            this.medidorDB.Medidor.Add(medidor);
            this.medidorDB.SaveChanges();

        }

        public void EliminarMedidor(int id_medidor)
        {
            Medidor medidor = this.medidorDB.Medidor.Find(id_medidor);

            this.medidorDB.Medidor.Remove(medidor);
            this.medidorDB.SaveChanges();
        }


        public Medidor Obtener(int id_medidor)
        {
            return this.medidorDB.Medidor.Find(id_medidor);
               
        }

        public List<Medidor> ObtenerMedidores()
        {
            return this.medidorDB.Medidor.ToList();
        }

        
        
    }
}
