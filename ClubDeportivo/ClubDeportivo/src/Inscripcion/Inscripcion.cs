using System;

public class FichaMedica
{
    public bool Apto { get; set; }
    public string Observaciones { get; set; }
    public bool Medicamentos { get; set; }
    public string EnfermedadesPreexistentes { get; set; }
}

public class Pago
{
    public bool Estado { get; set; }
    public double Monto { get; set; }
    public DateTime Vencimiento { get; set; }
    public DateTime FechaDePago { get; set; }
}

public class Datos
{
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public int DNI { get; set; }
}

public class Inscripcion
{
    public FichaMedica FM { get; set; }
    public Pago Pago { get; set; }
    public Datos Datos { get; set; }
    public int ID_Inscripcion { get; set; }

    public Inscripcion(FichaMedica fichaMedica, Pago pago, Datos datos, int idInscripcion)
    {
        FM = fichaMedica;
        Pago = pago;
        Datos = datos;
        ID_Inscripcion = idInscripcion;
    }

    // Valida si la ficha médica es apta
    public bool ValidarFichaMedica()
    {
        return FM.Apto;
    }

    // Valida si el pago se ha realizado
    public bool ValidarPago()
    {
        return Pago.Estado && Pago.FechaDePago <= Pago.Vencimiento;
    }

    // Valida si los datos necesarios han sido ingresados
    public bool ValidarDatos()
    {
        return !string.IsNullOrEmpty(Datos.Nombre) &&
               !string.IsNullOrEmpty(Datos.Direccion) &&
               Datos.DNI != 0;
    }

    // Valida si la inscripción es válida en general
    public bool ValidarInscripcion()
    {
        return ValidarFichaMedica() && ValidarPago() && ValidarDatos();
    }
}
