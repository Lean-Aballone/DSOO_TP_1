using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo {
    internal class Socios {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaIngreso { get; set; } // Fecha en la que el socio se unió al club
        public List<Clases> ClasesInscritas { get; set; } // Lista de clases a las que está inscrito el socio
        public List<Pagos> HistorialPagos { get; set; } // Lista de pagos realizados por el socio
        public FichaMedica FichaMedica { get; set; } // Información médica del socio
        public int MaxClases { get; set; } = 3; // Máximo de clases que puede tomar el socio

        public Socios() {
            ClasesInscritas = new List<Clases>();
            HistorialPagos = new List<Pagos>();
        }

        // Método para verificar si el socio puede inscribirse en más clases
        public bool PuedeInscribirseEnClase() {
            return ClasesInscritas.Count < MaxClases;
        }

        // Método para agregar una clase
        public void InscribirseEnClase(Clases nuevaClase) {
            if (PuedeInscribirseEnClase()) {
                ClasesInscritas.Add(nuevaClase);
            } else {
                throw new InvalidOperationException("No se puede inscribir en más de 3 clases.");
            }
        }

        // Método para verificar si el socio está al día con los pagos
        public bool EstaAlDia() {
            return HistorialPagos.All(p => p.Estado == true);
        }

        // Método para obtener la cantidad total de clases inscritas
        public int ObtenerCantidadDeClases() {
            return ClasesInscritas.Count;
        }
    }
}
