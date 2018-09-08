using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> morePlanets = new List<string>() { "Uranus", "Neptune" };

            // Adds morePlanets to planetList
            planetList.AddRange(morePlanets);

            // Add planets to the list
            planetList.Insert(1, "Earth");
            planetList.Insert(1, "Venus");
            planetList.Add("Pluto");

            List<string> rockyPlanets = new List<string>();
            rockyPlanets = planetList.GetRange(0, 4);

            // Pluto is not a planet
            planetList.Remove("Pluto");

            Console.WriteLine("All Planets: ");
            // Print out all the planets
            for (int i = 0; i < planetList.Count; i++ )
            {
                Console.WriteLine(planetList[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("Rocky Planets: ");
            // Print out the rocky planets (the first 4 in the solar system
            for (int i = 0; i < rockyPlanets.Count; i++)
            {
                Console.WriteLine(rockyPlanets[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("Planets and some of the space probes that have studied the planet.");
            // Build new Dictionary of Planets and Space Probes 
            var spaceProbes = new Dictionary<string, string> {
                { "Mercury", "Mariner, Messenger, BepiColombo" },
                { "Venus", "Mariner, Pioneer, Galileo, Magellan, Cassini, Messenger"},
                { "Mars", "Mariner, Viking, Observer, Pathfinder"},
                { "Jupiter", "Pioneer, Voyager, Galileo, Cassini" },
                { "Saturn", "Pioneer, Voyager, Cassini" },
                { "Uranus", "Voyager" },
                { "Neptune", "Voyager" }
            };

            // iterates over spaceProbes dictionary and prints key and value
            foreach (var i in spaceProbes)
            {
                Console.WriteLine(i.Key + ": " + i.Value);
            }

            Console.ReadLine();
        }
    }
}
