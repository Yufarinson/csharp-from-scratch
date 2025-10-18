// See https://aka.ms/new-console-template for more information
/*Clases*/
// Console.WriteLine("Hello, World!");
// var rect = new Rectangulo();
// rect.Base = 20;
// rect.Altura = 40;
// Console.WriteLine($"El área es: {rect.Area()}");
// Console.WriteLine($"El perímetro es: {rect.Perimetro()}");
/*End Clases*/

var cuadr = new Cuadrado();
cuadr.Base = 20;
cuadr.Altura = 40;
Console.WriteLine($"El área es: {cuadr.Area()}");
Console.WriteLine($"El perímetro es: {cuadr.Perimetro()}");
Console.WriteLine($"El lado es: {cuadr.Lado}");


class Rectangulo
{
    public double Base { get; set; }
    public double Altura { get; set; }
    public double Area() => Base * Altura;
    public double Perimetro() => 2 * (Base + Altura);
}

class Cuadrado : Rectangulo
{
    public double Lado
    {
        set { Base = value; Altura = value; }
        get { return Base; }
    }
}
