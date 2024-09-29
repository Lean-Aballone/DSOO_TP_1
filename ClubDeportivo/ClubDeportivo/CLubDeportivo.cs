using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    class ClubDeportivo : IAdministracion
    {

        private const int TOPEACTIVIDADESPORSOCIO = 3;
        private List<Socios> L_Activos;           //  ****
        private List<Socios> L_Inactivos;         //  REGISTRO DE LOS SOCIOS Y NO SOCIOS.
        private List<NoSocios> L_Aspirantes;      //  ****
        public List<Actividades> L_Actividades {  get; set; }

        public string InscribirActividad(sbyte actividadDeportiva, int idSocio) {
            if (!L_Activos.Exists(socio => socio.Id.Equals(idSocio))) return "SOCIO INEXISTENTE"; // el socio no se encuentra registrado dentro de la colección de socios en el club deportivo.
            if (!L_Inactivos.Exists(socio => socio.Id.Equals(idSocio))) return "EL SOCIO NO SE ENCUENTRA ACTIVO";
            if (!L_Actividades.Exists(actividad => actividad.id.Equals(actividadDeportiva))) return "ACTIVIDAD INEXISTENTE"; // la actividad deportiva no se encuentra dentro de la colección de actividades en el club deportivo.
            Actividades actividad = this.L_Actividades.Find(act => act.id.Equals(actividadDeportiva));
            Socios socio = L_Activos.Find(socio => socio.Id.Equals(idSocio));
            if (socio.ActividadesInscriptas.Count >= TOPEACTIVIDADESPORSOCIO) return "TOPE DE ACTIVIDADES ALCANZADO"; //cuando el socio ya participa en tres actividades deportivas

            socio.ActividadesInscriptas.Add(actividad);
            actividad.Inscriptos.Add(socio);
            return "INSCRIPCIÓN EXITOSA"; // el socio se ha inscrito correctamente en la actividad deportiva y se ha reservado un cupo para él).
        }

        public string InscribirActividad(sbyte actividadDeportiva, uint dni) {
            
            if (!L_Activos.Exists(socio => socio.DNI.Equals(dni))) return "SOCIO INEXISTENTE"; // el socio no se encuentra registrado dentro de la colección de socios en el club deportivo.
            if (!L_Inactivos.Exists(socio => socio.DNI.Equals(dni))) return "EL SOCIO NO SE ENCUENTRA ACTIVO";
            if (!L_Actividades.Exists( actividad => actividad.id.Equals(actividadDeportiva))) return "ACTIVIDAD INEXISTENTE"; // la actividad deportiva no se encuentra dentro de la colección de actividades en el club deportivo.
            Actividades actividad = this.L_Actividades.Find(act => act.id.Equals(actividadDeportiva));
            Socios socio = L_Activos.Find(socio => socio.DNI.Equals(dni));
            if (socio.ActividadesInscriptas.Count >= TOPEACTIVIDADESPORSOCIO) return "TOPE DE ACTIVIDADES ALCANZADO"; //cuando el socio ya participa en tres actividades deportivas

            socio.ActividadesInscriptas.Add(actividad);
            actividad.Inscriptos.Add(socio);
            return "INSCRIPCIÓN EXITOSA"; // el socio se ha inscrito correctamente en la actividad deportiva y se ha reservado un cupo para él).
        }
        public void AltaSocio(NoSocios noSocios) {
         //   L_Activos.Add(new Socios(true, noSocios.Nombre));
        }

        public void AltaSocio(string nombre, string apellido, uint dni) {

            if (L_Activos.Exists(socio => socio.DNI.Equals(dni))) { 
                Console.WriteLine("\nEl Socio ya se encuentra registrado.");
                return;
            }
            if (L_Inactivos.Exists(socio => socio.DNI.Equals(dni))) {
                Console.WriteLine("\nEl Socio ya se encuentra registrado.");
                return;
            }
            if (L_Aspirantes.Exists(aspirante => aspirante.DNI.Equals(dni))) L_Aspirantes.RemoveAll(aspirante => aspirante.DNI.Equals(dni));
            L_Inactivos.Add(new Socios(nombre, apellido, dni, (uint)L_Inactivos.Count));
        }
        public void ActualizarBBDD(List<Socios> activ, List<Socios> inact) {
            //TODO: implementar pase de NoSocio a socio (remover '?')
            
            inact.ForEach(socio => { if (socio.Activo.Equals(true)) activ.Add(socio); });
            inact.RemoveAll(socio => socio.Activo.Equals(true));

            activ.ForEach(socio => { if (socio.Activo.Equals(false)) inact.Add(socio); });
            activ.RemoveAll(socio => socio.Activo.Equals(false));
        }

        public ClubDeportivo(List<Socios> activos, List<Socios> inactivos, List<NoSocios> aspirantes) { //Futura BBDD
            L_Activos = activos;
            L_Inactivos = inactivos;
            L_Aspirantes = aspirantes;
        }

        public ClubDeportivo() {
            this.L_Activos = new List<Socios>();       //  ****
            this.L_Inactivos = new List<Socios>();     //  REGISTRO DE LOS SOCIOS Y NO SOCIOS.
            this.L_Aspirantes = new List<NoSocios>();  //  
            this.L_Actividades = new List<Actividades>();
        }
    }
}
