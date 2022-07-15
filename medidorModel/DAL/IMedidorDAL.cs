using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medidorModel.DAL
{
    public interface IMedidorDAL
    {
        List<Medidor> ObtenerMedidores();

        Medidor Obtener(int id_medidor);

        void EliminarMedidor(int id_medidor);

        void AgregarMedidor(Medidor medidor);




    }
}
