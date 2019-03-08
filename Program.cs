using System;
using System.Collections.Generic;
namespace NSSOrientation {
    class Program {
     static void planetPrinter(List<string> stringList){
            foreach(string item in stringList){
                Console.WriteLine(item);
            }
        }        public static void Main ()

        {

            List<string> finalplanetList = new List<string> () {
                "Neptune",
                "Uranus",
            };

            List<string> planetList = new List<string> () {
                "Mercury",
                "Mars"
            };

            planetList.Add ("Jupiter");
            planetList.Add ("Saturn");
            planetList.AddRange (finalplanetList);
            planetList.Insert (1, "venus");
            planetList.Insert (2, "Earth");
            planetList.Add ("Pluto");
            planetList.ForEach (planet => Console.WriteLine (planet + " ")); {
                List<string> rockyPlanets = planetList.GetRange (0, 4);
                Console.WriteLine ();
                foreach (string rockyPlanet in rockyPlanets) {
                    Console.WriteLine (rockyPlanet + " " + "are rocky");
                }
                planetList.RemoveAt (8);
                planetList.ForEach (planet => Console.WriteLine (planet)); { }
            }









            Random random = new Random ();
            List<int> numbers = new List<int> {
                random.Next (10),
                random.Next (10),
                random.Next (10),
                random.Next (10),
                random.Next (10),
                random.Next (10),
                random.Next (10),
                random.Next (10),
                random.Next (10),
                random.Next (10),

            };
            for (int i = 0; i <= numbers.Count - 1; i++) {
if (numbers[i] == i)
{
 Console.WriteLine("random number " + numbers[i] + " " +" is equal to index " + i);
} else {
Console.WriteLine("random number " + numbers[i] + " " +" is NOT equal to index " + i);

            }
        }}}}