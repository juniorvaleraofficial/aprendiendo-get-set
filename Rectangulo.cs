// Objetivo: Devolver valor calculado a partir de campos/otras props

public class Rectangulo
{
    public double Alto { get; set; }
    public double Ancho { get; set; }
    public double Area
    {
        get { return Ancho * Alto; } // Calculada, solo lectura
    }
}