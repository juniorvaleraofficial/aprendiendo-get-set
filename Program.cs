// See https://aka.ms/new-console-template for more information
    var ObjetoPersona = new Persona();
    var ObjApellido = new Persona();
    var ObjProducto = new Producto();
    var e = new Estudiante();
    ObjetoPersona.Nombre = "Junior";
    ObjApellido.Apellido = " Valera";
    ObjProducto.Nombre = "Laptop Gamer: ";
    e.Edad = 30;
    Console.WriteLine(ObjetoPersona.Nombre + ObjApellido.Apellido);
    Console.WriteLine(ObjProducto.Nombre);
    Console.WriteLine($"La Edad es: {e.Edad}");
