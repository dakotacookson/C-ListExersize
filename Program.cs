using System;
using System.Collections.Generic;
namespace NSSOrientation {
    class Program {
        public static void Main ()

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
                planetList.ForEach (planet => Console.WriteLine (planet)); {
                }
            }
        }
    }
}