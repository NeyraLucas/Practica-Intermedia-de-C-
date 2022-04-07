using System;
using System.Text.RegularExpressions;

namespace Practica1 // Note: actual namespace depends on the project name.
{
    internal class Practica1
    {
        static void Main(string[] args)
        {
            // 1.- Ternario
            //create random number
            int random = new Random().Next(0, 1000);

            string ternarioRandom = random > 500 ? "Greater than 500" : "Less than";

            Console.WriteLine($"Random: {random} --- {ternarioRandom}");

            // 2.- Exception
            try
            {
                //creamos el null
                int? exampleNull = null;

                //se le da un valor
                exampleNull = 5;

                //utilizamos un ternario en caso de que venga como null
                string nullException = exampleNull.HasValue ? "Valor valido" : throw new ExceptionExample(exampleNull.HasValue);

                Console.WriteLine(nullException);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            //3
            //Tipos anonimos
            var person = new { Name = "Veronica", Age = 55 };
            Console.WriteLine($"Tipos Anonimos: {person}");

            dynamic number = 5;
            Console.WriteLine($"Dynamic - before: {number}");

            number = "Hola mundo";
            Console.WriteLine($"Dynamic - after: {number}");

            Animal animal = new Animal("Dog", "Bulldog", "Small");
            number = animal;
            Console.WriteLine($"Dynamic - obj: {number.Name}");

            //4
            //Generics
            GenericExample<AbstractExample> abs = new GenericExample<AbstractExample>();
           // abs[1].Key = "mmm";
            //abs[1].Value
            //var generic = abs[0].Key;

           // Console.WriteLine($"Value: {generic}");


            //6
            //Regex
            string frase = "Hola1234";
            bool isMatch = Regex.IsMatch(frase, @"[A-Z][a-z]{3}[0-9]{4}");
            Console.WriteLine($"Regex:  {isMatch}");


        }
    }

}