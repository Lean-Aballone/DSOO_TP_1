using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    class Administracion
    {
        private const string nombre = "Club Deportivo";
        private List<Socios> Activos;           //  ****
        private List<Socios> Inactivos;         //  REGISTRO DE LOS SOCIOS Y NO SOCIOS.
        private List<NoSocios> Aspirantes;      //  ****
        public string Nombre { get { return nombre; } }

    }
}
