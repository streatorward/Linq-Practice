﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace linq {
    class Program {
        static void Main (string[] args) {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string> () { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits = from fruit in fruits
            where fruit.StartsWith ("L")
            select fruit;

            Console.WriteLine ("----------------------------------------");
            foreach (string fruit in LFruits) {
                Console.WriteLine ($"{fruit}");
            }

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int> () {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            Console.WriteLine ("----------------------------------------");
            IEnumerable<int> fourSixMultiples = numbers.Where (x => x % 4 == 0).Where (x => x % 6 == 0);
            foreach (int FSM in fourSixMultiples) {
                Console.WriteLine ($"{FSM}");
            }

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string> () {
                "Heather",
                "James",
                "Xavier",
                "Michelle",
                "Brian",
                "Nina",
                "Kathleen",
                "Sophia",
                "Amir",
                "Douglas",
                "Zarley",
                "Beatrice",
                "Theodora",
                "William",
                "Svetlana",
                "Charisse",
                "Yolanda",
                "Gregorio",
                "Jean-Paul",
                "Evangelina",
                "Viktor",
                "Jacqueline",
                "Francisco",
                "Tre"
            };

            IEnumerable<string> descend = from name in names
            orderby name descending
            select name;

            Console.WriteLine ("----------------------------------------");
            foreach (string name in descend) {
                Console.WriteLine ($"{name}");
            }

            // Build a collection of these numbers sorted in ascending order
            List<int> numbers2 = new List<int> () {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            IEnumerable<int> ascend = from number in numbers2
            orderby number
            select number;

            Console.WriteLine ("----------------------------------------");
            foreach (int number in ascend) {
                Console.WriteLine ($"{number}");
            }

            // Output how many numbers are in this list
            List<int> numbers3 = new List<int> () {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };
            Console.WriteLine ("----------------------------------------");
            Console.WriteLine (numbers3.Count ());

            // How much money have we made?
            List<double> purchases = new List<double> () {
                2340.29,
                745.31,
                21.76,
                34.03,
                4786.45,
                879.45,
                9442.85,
                2454.63,
                45.65
            };
            Console.WriteLine ("----------------------------------------");
            Console.WriteLine (purchases.Sum ());

            // What is our most expensive product?
            List<double> prices = new List<double> () {
                879.45,
                9442.85,
                2454.63,
                45.65,
                2340.29,
                34.03,
                4786.45,
                745.31,
                21.76
            };
            
            Console.WriteLine ("----------------------------------------");
            Console.WriteLine (prices.Max ());

            /*
            Store each number in the following List until a perfect square
            is detected.

            Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */
            List<int> wheresSquaredo = new List<int> () {
                66,
                12,
                8,
                27,
                82,
                34,
                7,
                50,
                19,
                46,
                81,
                23,
                30,
                4,
                68,
                14
            };

            var sampleNumbersSquared = wheresSquaredo.TakeWhile(number => Math.Sqrt(number) % 1 != 0);

            Console.WriteLine ("----------------------------------------");
            foreach(double number in sampleNumbersSquared) 
            {
                Console.WriteLine($"{number}");
            }

            
        }
    }
}