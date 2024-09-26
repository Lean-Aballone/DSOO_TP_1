using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo {
    internal interface IAdministracion {
        void ActualizarBBDD(List<Socios> a, List<Socios> i);//TODO: , List<NoSocios> ns); implementar pase de NoSocio a socio.
        void AltaSocio(NoSocios noSocio);
        string InscribirActividad(string actividadDeportiva, int idSocio);
    }
}
