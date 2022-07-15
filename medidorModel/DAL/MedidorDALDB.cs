using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medidorModel.DAL
{
    class MedidorDALDB
    {
        private medidorappEntities medidorDB = new medidorappEntities();

        public void actualizarMedidor(Medidor m)
        {
            //Medidor mOriginal = this.medidorDB.usuarios.Find(m.id_medidor);
        }



        public void AgregarMedidor(Medidor medidor)
        {
            this.medidorDB.Medidors.Add(medidor);
            this.medidorDB.SaveChanges();

        }


        
    }
}
