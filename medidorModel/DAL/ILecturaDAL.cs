using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medidorModel.DAL
{
    public interface ILecturaDAL
    {
        List<Lectura> ObtenerLectura();

        Lectura Obtener(int id_lectura);


        void EliminarLectura(int id_lectura);

        void AgregarLectura(Lectura lectura);






    }
}
