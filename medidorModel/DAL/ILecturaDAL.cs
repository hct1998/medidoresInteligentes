using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medidorModel.DAL
{
    public interface ILecturaDAL
    {
        List<Lectura> ObtenerLecturas();

        Lectura Obtener(int id_lectura);


        void EliminarLecturas(int id_lectura);

        void AgregarLecturas(Lectura lectura);






    }
}
