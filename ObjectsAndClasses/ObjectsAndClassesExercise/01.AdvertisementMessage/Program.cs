﻿using System;
using System.Collections.Generic;

namespace _01.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phrases = new List<string>{  "Excellent product.", "Such a great product.",
                "I always use that product.", "Best product of its category.",
                "Exceptional product.", "I can’t live without this product." };
            List<string> events = new List<string> { "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!" };
            List<string> authors = new List<string> { "Diana", "Petya", "Stella", "Elena",
                "Katya", "Iva", "Annie", "Eva" };
            List<string> cities = new List<string> { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            int number = int.Parse(Console.ReadLine());
            Random rnd = new Random();

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"{phrases[rnd.Next(phrases.Count)]} {events[rnd.Next(events.Count)]} " +
                    $"{authors[rnd.Next(authors.Count)]} - {cities[rnd.Next(cities.Count)]}");
            }
        }
    }
}
