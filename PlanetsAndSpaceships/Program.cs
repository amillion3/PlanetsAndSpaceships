﻿using System;
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

            planetList.Insert(2, "Earth");
            planetList.Insert(1, "Venus");

            planetList.Add("Pluto");

            for (int i = 0; i < planetList.Count; i++ )
            {
                Console.WriteLine(planetList[i]);
            }
            Console.ReadLine();


            //Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets.
            //Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.
            //Iterating over planets
            //Ref: List of Solar System probes

            //Create another dictionary that will hold the name of a spacecraft that we have launched, and a list of names of the planets that it has visited.Remember that List is a Type just like native types(such as string, int, &bool) and your custom types(such as Movie, Dog, and Food). They can be passed to anything, like a dictionary, as a Type.
            //Iterate over your list of planets from above, and inside that loop, iterate over the dictionary. Write to the console, for each planet, which satellites have visited which planet.
            //Mars: Viking, Opportunity, Curiosity
            //Venus: Mariner, Venera

            //etc...
        }
    }
}
