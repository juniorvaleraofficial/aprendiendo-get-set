// Objetivo: Rechazar valores inválidos y usar uno por defecto.

public class Usuario
{
    private string email = "sin-correo@demo.local";// campo 
    public string Email // propiedad
    {
        get { return email; } // ✅ usar el campo, no la propiedad
        set
        {
            if (value != null && value.Contains("@"))
                email = value;
            else
                email = "sin-correo@demo.local";
        }
    }
}