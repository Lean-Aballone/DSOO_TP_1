namespace ClubDeportivo {
    internal class Program {
        static void Main(string[] args) {
            // Crear una instancia de un profesor
            Profesores profesor = new Profesores {
                Id = 1,
                Nombre = "Carlos",
                Actividad = "Entrenador"
            };

            // Crear una instancia de un socio
            Socio socio = new Socio {
                Id = 100,
                Nombre = "Juan"
            };

            // Crear un turno para el socio
            Turno turno = new Turno {
                Fecha = DateTime.Now,
                Hora = new TimeSpan(9, 0, 0),
                Socio = socio
            };

            // Usar métodos de la clase profesor
            profesor.RegistrarAsistencia();
            double salario = profesor.CalcularSalarioMensual();

            // Mostrar resultados en consola
            Console.WriteLine($"El profesor {profesor.Nombre} ha registrado asistencia.");
            Console.WriteLine($"El salario calculado del profesor es: {salario}");
            Console.WriteLine($"El socio {socio.Nombre} tiene un turno asignado el {turno.Fecha} a las {turno.Hora}");


            // Inscripcion PRUEBA 
             // Crear una ficha médica de ejemplo
            FichaMedica ficha = new FichaMedica
            {
                Apto = true,
                Observaciones = "Sin observaciones",
                Medicamentos = false,
                EnfermedadesPreexistentes = "Ninguna"
            };

            // Crear un pago de ejemplo
            Pago pago = new Pago
            {
                Estado = true,
                Monto = 100.0,
                Vencimiento = DateTime.Now.AddDays(10),
                FechaDePago = DateTime.Now
            };

            // Crear datos de ejemplo
            Datos datos = new Datos
            {
                Nombre = "Juan Perez",
                Direccion = "Calle Falsa 123",
                DNI = 12345678
            };

            // Crear una inscripción de ejemplo
            Inscripcion inscripcion = new Inscripcion(ficha, pago, datos, 1);
            if (inscripcion.ValidarInscripcion())
            {
                Console.WriteLine("Inscripción válida.");
            }
            else
            {
                Console.WriteLine("Inscripción inválida.");
            }
            }
        }
    }
}