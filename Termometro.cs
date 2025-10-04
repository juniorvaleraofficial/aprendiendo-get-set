// Objetivo: Mostrar cómo una propiedad refleja otra.
public class Termometro
{
    public double Celsius { get; set; }
    public double Fahrenheit
    {
        get { return (Celsius * 9 / 5) + 32; }
        set { Celsius = (value - 32) * 5 / 9; }// escribir Fahrenheit ajusta Celsius
    }
}

/*
Por qué salen 32 y 100 (o 212 y 100 según el orden):

Las fórmulas son:

F = C × (9/5) + 32

C = (F − 32) × (5/9)

32°F es lo que da cuando C = 0 → F = 0×(9/5)+32 = 32.
Es el punto de congelación del agua.

100°C es lo que da cuando F = 212 → C = (212−32)×(5/9) = 180×(5/9) = 100.
Es el punto de ebullición del agua.
**/