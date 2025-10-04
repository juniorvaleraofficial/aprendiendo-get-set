// Objetivo: Transformar al leer, almacenar crudo.

public class Libro
{
    private string titulo;
    public string Titulo
    {
        get { return titulo?.Trim(); }// quita espacios al leer
        set { titulo = value; } // 
    }
}