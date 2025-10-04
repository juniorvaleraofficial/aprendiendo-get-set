//Objetivo: Permitir leer siempre, escribir solo dentro de la clase.
public class Cuenta
{
    public decimal Saldo { get; private set; } = 0m;
    public void Depositar(decimal monto)
    {
        if (monto > 0) Saldo += monto;
    }

    static void Main(string[] args)
    {
        var c = new Cuenta();
        c.Depositar(120m);
        Console.WriteLine(c.Depositar);
    }
}