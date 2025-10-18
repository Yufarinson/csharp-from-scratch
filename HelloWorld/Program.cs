namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            DateOnly  dateConverted = new DateOnly();
            Console.WriteLine("Hello, Bienvenido al calculador de años!");
            Console.WriteLine("Escribe tu nombre: ");
            string nameInput = Console.ReadLine();
            Console.WriteLine($"Un gusto conocerte {nameInput}!");
            Console.WriteLine("Escribe tu fecha de nacimiento en formato (dd-MM-YYYY): ");
            string birthDateInput = Console.ReadLine();
            bool isDateValid = DateOnly.TryParse(birthDateInput, out dateConverted);
            if (isDateValid == false) Console.WriteLine($"Tu fecha de nacimiento es inválida, usted nos envió dsato erróneo: {birthDateInput}");
            var person = new Person
            {
                Name = nameInput,
                BirthDate = dateConverted,
                Age = DateTime.Now.Year - dateConverted.Year
            };

            Console.WriteLine($"Tu nombre: {person.Name}");
            Console.WriteLine($"Tu fecha de nacimiento es: {person.BirthDate}");
            Console.WriteLine($"Tu edad es: {person.Age} años");

            Console.ReadLine();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}