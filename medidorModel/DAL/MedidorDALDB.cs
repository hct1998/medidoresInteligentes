using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medidorModel.DAL 
{
    public class MedidorDALDB : IMedidorDAL
    {
        private appmedidorEntities medidorDB = new appmedidorEntities();

       

        public void AgregarMedidores(Medidor medidores)
        {
            this.medidorDB.Medidors.Add(medidores);
            this.medidorDB.SaveChanges();

        }

        public void EliminarMedidor(int id_medidor)
        {
            Medidor medidor = this.medidorDB.Medidors.Find(id_medidor);

            this.medidorDB.Medidors.Remove(medidor);
            this.medidorDB.SaveChanges();
        }


        public Medidor Obtener(int id_medidor)
        {
            return this.medidorDB.Medidors.Find(id_medidor);
               
        }

        public List<Medidor> ObtenerMedidores()
        {
            return this.medidorDB.Medidors.ToList();
        }

        
        
    }
}
