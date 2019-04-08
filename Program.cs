using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() {
                "Mercury",
                "Mars"};
                // planetList.Add("Jupiter");

                // planetList.Add("Saturn ");
            List<string> bigplantes = new List<string> () {
                "Jupiter",
                "Saturn "
            };
            planetList.AddRange(bigplantes);
            planetList.Insert(2,"Earth");
            planetList.Insert(2,"Venus");
            planetList.Add("Pluto");
            List<string> rockyPlanets = planetList.GetRange(0,4);
            planetList.Remove("Pluto");
            foreach(string planet in planetList){
            Console.WriteLine(planet);
            }
            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
            };
            for (int i=0; i<numbers.Count; i++) {
   // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
            if(numbers.Contains(i))
            {
                Console.WriteLine($"numberList contains {i}");
            }
            else
                Console.WriteLine($"numberList does not contain {i} ");
            }
        }
    }
}
