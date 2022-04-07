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
            Map<TestAbstract> abs = new Map<TestAbstract>();
            //Se deben instanciar 
            abs[0] = new TestAbstract("Perros",55);
            abs[1] = new TestAbstract("Gatos", 3);
            abs[2] = new TestAbstract("Tortugas", 15);

            var generic = abs[0];

            Console.WriteLine($"Key: {generic.Key}  Value: {generic.Value}" );

            //Value exception
            Console.WriteLine(abs.SearchByKey("Perrosa"));
           // TestAbstract ex = abs.SearchByKey("Perros");
            //Console.WriteLine(ex);

            //5
            //Extension Methods
            Console.WriteLine("Extension:" +Extension.ShowArr(abs).Key);
            


            //6
            //Regex
            string frase = "Hola1234";
            bool isMatch = Regex.IsMatch(frase, @"[A-Z][a-z]{3}[0-9]{4}");
            Console.WriteLine($"Regex:  {isMatch}");


        }
    }

}