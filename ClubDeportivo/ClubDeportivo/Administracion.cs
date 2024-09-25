using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    class Administracion : IAdministracion
    {
        private const string nombre = "Club Deportivo";
        private List<Socios> Activos;           //  ****
        private List<Socios> Inactivos;         //  REGISTRO DE LOS SOCIOS Y NO SOCIOS.
        private List<NoSocios> Aspirantes;      //  ****
        public string Nombre { get { return nombre; } }

        public void ActualizarBBDD(List<Socios> activ, List<Socios> inact) {
            //TODO: implementar pase de NoSocio a socio (remover '?')
            
            inact.ForEach(socio => { if (socio.Activo.Equals(true)) activ.Add(socio); });
            inact.RemoveAll(socio => socio.Activo.Equals(true));

            activ.ForEach(socio => { if (socio.Activo.Equals(false)) inact.Add(socio); });
            activ.RemoveAll(socio => socio.Activo.Equals(false));
        }
    }
}
