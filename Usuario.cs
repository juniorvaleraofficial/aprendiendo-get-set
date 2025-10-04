// Objetivo: Rechazar valores inválidos y usar uno por defecto.

public class Usuario
{
    private string email = "sin-correo@demo.local";
    public string Email
    {
        get { return Email; } // ❌ Esto llama a la propiedad otra vez
        set
        {
            if (value != null && value.Contains("@"))
                email = value;
            else
                email = "sin-correo@demo.local";
        }
    }
}