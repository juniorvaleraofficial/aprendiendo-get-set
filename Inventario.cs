// Objetivo: Combinar get público, set privado y un método para modificar.
/*
Qué hace cada parte (en palabras)

public int Cantidad { get; private set; }

get público: cualquiera puede leer el número de unidades.

set privado: solo la clase puede cambiar ese número (desde sus propios métodos).

Es una auto-propiedad: el compilador crea un campo “oculto” para guardar el valor.

Como es int, empieza en 0 por defecto.

Agregar(int n)

Si n > 0, suma n a Cantidad.

Si n <= 0, ignora la operación (no tiene sentido agregar 0 o negativos).

Usa el setter privado de Cantidad (permitido porque estamos dentro de la clase).

Quitar(int n)

Solo quita si n > 0 y n <= Cantidad (no permite números negativos ni quedar en negativo).

Si la condición no se cumple, no cambia nada.

Ejemplo mental rápido
Inicio: Cantidad = 0
Agregar(10) → Cantidad = 10
Quitar(3) → Cantidad = 7
Quitar(20) → no cumple n <= Cantidad → Cantidad sigue en 7.
*/
public class Inventario
{
    // Propiedad con lectura pública y escritura privada.
    // Cualquiera puede LEER Cantidad, pero solo esta clase puede CAMBIARLA.
    // Al ser int, inicia en 0 por defecto.
    public int Cantidad { get; private set; }

    // Agrega n unidades al inventario si n es positivo.
    public void Agregar(int n)
    {
        // Validación básica: solo tiene sentido agregar cantidades > 0
        if (n > 0)
        {
            // Como estamos dentro de la clase, podemos usar el set privado.
            // Equivale a: Cantidad = Cantidad + n;
            Cantidad += n;
        }
        // Si n <= 0, no hace nada (protege el estado contra entradas inválidas).
    }

    // Quita n unidades si hay suficiente stock y n es positivo.
    public void Quitar(int n)
    {
        // Debe ser > 0 y no exceder lo disponible para evitar números negativos.
        if (n > 0 && n <= Cantidad)
        {
            // Usa el set privado para actualizar el valor.
            Cantidad -= n;
        }
        // Si n <= 0 o n > Cantidad, no cambia nada (protege el estado).
    }
}
