// Objetivo: Validar antes de asignar.
public class Estudiante
{
    private int edad;
    public int Edad
    {
        get { return edad; }
        set
        {
            // Reglas: 0–120; si no, forzar 0
            if (value >= 0 && value <= 120)
            {
                edad = value;
            }
            else
            {
                edad = 0;
            }
        }
    }
}