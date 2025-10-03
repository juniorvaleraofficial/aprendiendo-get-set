// Objetivo: Encapsular un campo con get/set.
public class Persona
{
    private string nombre = ""; // campo privado
    private string apellido = "";
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public string Apellido
    {
        get { return apellido; }
        set { apellido = value; }
    }

}