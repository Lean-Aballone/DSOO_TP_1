using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo
{
    class ClubDeportivo : IAdministracion
    {

        private const int TOPEACTIVIDADESPORSOCIO = 3;
        private List<Socios> Activos;           //  ****
        private List<Socios> Inactivos;         //  REGISTRO DE LOS SOCIOS Y NO SOCIOS.
        private List<NoSocios> Aspirantes;      //  ****

        public string InscribirActividad(string actividadDeportiva, int idSocio) {


            /* 
                "INSCRIPCIÓN EXITOSA" (en este caso, el socio se ha inscrito correctamente en la actividad deportiva y se ha reservado un cupo para él).
                "ACTIVIDAD INEXISTENTE" (cuando la actividad deportiva no se encuentra dentro de la colección de actividades en el club deportivo).
                "TOPE DE ACTIVIDADES ALCANZADO" (cuando el socio ya participa en tres actividades deportivas).
                "SOCIO INEXISTENTE" (cuando el socio no se encuentra registrado dentro de la colección de socios en el club deportivo).
            */

           
            if(!Activos.Exists(socio => socio.Id.Equals(idSocio))) return "SOCIO INEXISTENTE"; // el socio no se encuentra registrado dentro de la colección de socios en el club deportivo.
            if (!Inactivos.Exists(socio => socio.Id.Equals(idSocio))) return "EL SOCIO NO SE ENCUENTRA ACTIVO";
            //TODO: if(Plantel.Actividades.Exists( actividad => actividad.nombre:Equals(actividadDeportiva))) return "ACTIVIDAD INEXISTENTE"; // la actividad deportiva no se encuentra dentro de la colección de actividades en el club deportivo.
           // if(Activos.Find(socio => socio.Id.Equals(idSocio)).ClasesInscritas.Count >= TOPEACTIVIDADESPORSOCIO) return "TOPE DE ACTIVIDADES ALCANZADO"; //cuando el socio ya participa en tres actividades deportivas

            //TODO: Agregar la actividadDeportiva de Plantel.Actividades a la lista de actividades del socio e Imprimir mensaje Inscripcion exitosa.

            return "INSCRIPCIÓN EXITOSA";
        }
        public void AltaSocio(NoSocios noSocios) {
         //   Activos.Add(new Socios(true, noSocios.Nombre));
        }

        public void AltaSocio(string nombre, string apellido, uint dni) {

            if (Activos.Exists(socio => socio.DNI.Equals(dni))) { 
                Console.WriteLine("\nEl Socio ya se encuentra registrado.");
                return;
            }
            if (Inactivos.Exists(socio => socio.DNI.Equals(dni))) {
                Console.WriteLine("\nEl Socio ya se encuentra registrado.");
                return;
            }
            if (Aspirantes.Exists(aspirante => aspirante.DNI.Equals(dni))) Aspirantes.RemoveAll(aspirante => aspirante.DNI.Equals(dni));
            Inactivos.Add(new Socios(nombre, apellido, dni, (uint)Inactivos.Count));
        }
        public void ActualizarBBDD(List<Socios> activ, List<Socios> inact) {
            //TODO: implementar pase de NoSocio a socio (remover '?')
            
            inact.ForEach(socio => { if (socio.Activo.Equals(true)) activ.Add(socio); });
            inact.RemoveAll(socio => socio.Activo.Equals(true));

            activ.ForEach(socio => { if (socio.Activo.Equals(false)) inact.Add(socio); });
            activ.RemoveAll(socio => socio.Activo.Equals(false));
        }

        public ClubDeportivo(List<Socios> activos, List<Socios> inactivos, List<NoSocios> aspirantes) { //Futura BBDD
            Activos = activos;
            Inactivos = inactivos;
            Aspirantes = aspirantes;
        }

        public ClubDeportivo() {
            this.Activos = new List<Socios>();       //  ****
            this.Inactivos = new List<Socios>();     //  REGISTRO DE LOS SOCIOS Y NO SOCIOS.
            this.Aspirantes = new List<NoSocios>();  //  
        }
    }
}
