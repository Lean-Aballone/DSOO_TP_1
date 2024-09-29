using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo {
    internal class Socios {
        public uint Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public uint DNI { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaIngreso { get; set; } // Fecha en la que el socio se unió al club
        public List<Actividades> ActividadesInscriptas { get; set; } // Lista de actividades a las que está inscripto el socio
      //  public List<Pagos> HistorialPagos { get; set; } // Lista de pagos realizados por el socio
     //   public FichaMedica FichaMedica { get; set; } // Información médica del socio

        public Socios() {
//            ClasesInscritas = new List<Clases>();
 //           HistorialPagos = new List<Pagos>();
        }

        public Socios(string Nombre, string Apellido, uint dni, uint Id, bool activo) {
            this.Id = Id + 1;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Activo = activo;
            DNI = dni;
            FechaIngreso = DateTime.Now;
            Console.WriteLine("\nEl Socio: " + this.Apellido +", "+ this.Nombre + " DNI: " + dni + " Fue Ingresado Exitosamente.");
            Console.WriteLine("Con Nro de ID: " + this.Id);
        }

        // Método para verificar si el socio puede inscribirse en más clases
        public bool PuedeInscribirseEnClase(int MaxClases) {
            return ActividadesInscriptas.Count < MaxClases;
        }
/*
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
    */}
}
