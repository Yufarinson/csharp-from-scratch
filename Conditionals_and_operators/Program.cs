/*Conditionals*/
/*
string nameInput = string.Empty;
Console.WriteLine("Ingrese un número: ");
int num = int.Parse(Console.ReadLine());
if (num < 0) Console.WriteLine("Negativo");
else if (num > 0) Console.WriteLine("Positivo");
else Console.WriteLine("Es Cero");
*/

/*End Conditionals*/

/*Operators*/
Console.WriteLine("Ingrese el primer número: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número: ");
double b = double.Parse(Console.ReadLine());

const string Indeterminado = "Indeterminado";
Console.WriteLine($"Suma: {a+b}, Resta: {a-b}, Multiplicación: {a*b}, División: {(b!=0 ? a/b : Indeterminado)}");