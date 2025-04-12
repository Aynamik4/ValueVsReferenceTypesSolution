/* 2025-04-12 */

using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            //ValueTypesDemo();
            ReferenceTypesDemo();
        }

        private static void ValueTypesDemo()
        {
            int i = 10;
            int j = i;
            i = 20;
            Console.WriteLine($"i: {i}");
            Console.WriteLine();
            Console.WriteLine($"j: {j}");
            Console.WriteLine("-------------------------------");

            Console.WriteLine($"i: {i}");
            ValueTypeParameterMethod(i);
            Console.WriteLine($"i: {i}");
        }

        private static void ValueTypeParameterMethod(int i)
        {
            i++;
        }

        private static void ReferenceTypesDemo()
        {
            Person me = new()
            {
                Name = "Håkan",
                Age = 62,
                WatchCollection =
                [
                    "Audemars Piguet",
                    "Vacheron Constantin",
                    "Patek Philippe"
                ]
            };

            Person you = me;
            //Person you = me.ShallowClone();
            //Person you = me.DeepClone();
            //Person you = me.JSON_DeepClone();

            you.Name = "Pontus";
            you.Age = 38;
            you.WatchCollection[0] = "Citizen";
            you.WatchCollection[1] = "Seiko";
            you.WatchCollection[2] = "Casio";

            Console.WriteLine($"me:{Environment.NewLine}{me}");
            Console.WriteLine();
            Console.WriteLine($"you:{Environment.NewLine}{you}");

            //ReferenceTypeParameterMethod(me);
            //Console.WriteLine($"me:{Environment.NewLine}{me}");
        }
        private static void ReferenceTypeParameterMethod(Person person)
        {
            person.Name = "Jonathan";
        }
    }
}
