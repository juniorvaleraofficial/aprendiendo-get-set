// See https://aka.ms/new-console-template for more information
var a = new Usuario();
a.Email = "detoprox@gmai.com";
Console.WriteLine($"Email valido {a.Email}");
a.Email = "Invalido";
Console.WriteLine($"Email invalido {a.Email}");