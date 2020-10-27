// Square.cs
using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Square Luis:\n");
            // SquareLuis();
            // Console.WriteLine("\n\n");
            // Console.WriteLine("Square Pablo:\n");
            // SquarePablo();
           // Square cuadrado_bonito = new Square();
           // string la_formita_del_cuadrado = cuadrado_bonito.Draw();
           // Console.WriteLine(la_formita_del_cuadrado);

             Stairs escalera_bonita = new Stairs();
            string la_escalera_bonita = escalera_bonita.Draw();
            Console.WriteLine(la_escalera_bonita);
            Console.Read();
        }
    }
}