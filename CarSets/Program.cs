using System;
using System.Collections.Generic;

namespace CarSets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> Showroom = new HashSet<string>();

            Showroom.Add("Toyota");
            Showroom.Add("Nissan");
            Showroom.Add("Volvo");
            Showroom.Add("Fiat");

            Console.WriteLine(Showroom.Count);

            foreach (var model in Showroom)
            {
                Console.WriteLine($"{model}");
            }
           
            Showroom.Add("Volvo");


            foreach (var model in Showroom)
            {
                Console.WriteLine($"{model}");
            }

            HashSet<string> UsedLot = new HashSet<string>();

            UsedLot.Add("Mercedes");
            UsedLot.Add("Mazda");

            Showroom.UnionWith(UsedLot);
            Showroom.Remove("Toyota");

            var JunkYard = new HashSet<string>();

            JunkYard.Add("Volvo");
            JunkYard.Add("Mazda");
            JunkYard.Add("Range Rover");
            JunkYard.Add("Dodge");
            JunkYard.Add("Hyundai");
            JunkYard.Add("Mitsibushi");
            JunkYard.Add("Jeep");
            JunkYard.Add("Mercedes");

            Showroom.IntersectWith(JunkYard);

            Console.WriteLine("Intersect With");
            Console.WriteLine();
            foreach(var car in Showroom)
            {
                Console.WriteLine($"{car}");
            }

            JunkYard.UnionWith(Showroom);

            Console.WriteLine("Union With");
            Console.WriteLine();

            foreach (var addedCar in JunkYard)
            {
                Console.WriteLine($"{addedCar}");
            }


            Console.ReadLine();
        }

       
    }
}
