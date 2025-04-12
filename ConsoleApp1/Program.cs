using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            int i = 10;
            int j = i;
            i = 20;
            Console.WriteLine($"i: {i}");
            Console.WriteLine();
            Console.WriteLine($"j: {j}");
            Console.WriteLine("-------------------------------");

            Person me = new() { Name = "Håkan", Age = 62, WatchCollection = ["Audemars Piguet", "Vacheron Constantin", "Patek Philippe"] };

            Person you = me;
            //Person you = me.ShallowClone();
            //Person you = me.DeepClone();
            //Person you = me.JSON_DeepClone();

            you.Name = "Pontus";
            you.Age = 38;
            you.WatchCollection[0] = "Seiko";
            you.WatchCollection[1] = "Citizen";
            you.WatchCollection[2] = "Casio";

            Console.WriteLine($"me:{Environment.NewLine}{me}");
            Console.WriteLine();
            Console.WriteLine($"you:{Environment.NewLine}{you}");
        }
    }
}
