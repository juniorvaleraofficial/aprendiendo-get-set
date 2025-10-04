// See https://aka.ms/new-console-template for more information
var inv = new Inventario();     // Cantidad = 0
inv.Agregar(10);                // Cantidad = 10
inv.Quitar(3);                  // Cantidad = 7
inv.Quitar(20);                 // no cumple condición -> sigue en 7
Console.WriteLine(inv.Cantidad); // 7

// inv.Cantidad = 999;  // ❌ No compila: set es private
