namespace ClubDeportivo.Models
{
    public class Turno
    {
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public Socio Socio { get; set; }

        public bool VerificarTurnoSemanal()
        {
            // Lógica para verificar que el turno sea semanal
            return true;
        }
    }
}
