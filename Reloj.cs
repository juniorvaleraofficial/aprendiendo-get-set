// Objetivo: Exponer dato sin permitir escritura externa.
public class Reloj
{
    private string zona = "UTC-4";
    public string Zona // La propiedad debe tener la primera letra en Mayuscula
    {
        get { return zona; } // solo lectura 
    }
}