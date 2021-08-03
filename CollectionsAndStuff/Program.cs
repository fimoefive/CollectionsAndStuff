﻿using System;
using System.Collections.Generic;

namespace CollectionsAndStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            // All of these methods mutate the original collection


            // List<T> is a generic type, a type that requires me to tell it what type of stuff it does/uses
            // in this case 'string' is a type of parameter used to tell the List<T> how to work
            var e14Names = new List<string>();

            //add a single item
            //works like push, appends to the end of the list
            e14Names.Add("Martin");
            e14Names.Add("Chie");
            e14Names.Add("Holly");

            // put the item into a certain spot
            e14Names.Insert(1, "Chris");

            // collection initializer - curly braces with elements inside
            var teacherNames = new List<string> { "Nathan", "Jameka", "Dylan", "Tom" };

            // add one collection to the other
            e14Names.AddRange(teacherNames);

            // remove tom (this uses a thing called reference equality)
            e14Names.Remove("Tom");

            // remove by index
            e14Names.RemoveAt(0);

            // remove by expressoion
            e14Names.RemoveAll(name => name.StartsWith("N"));

            // normal C# foreach loop
            foreach (var name in e14Names)
            {
                Console.WriteLine($"{name} is in e14!");
            }

            // inline ForEach loop over a List
            // list specific loop, takes in an Action<T> (like a fat arrow fucntion)
            e14Names.ForEach(name => Console.WriteLine($"{name} is in e14 again!"));

            // get the item at the index of 0  
            var firstStudent = e14Names[0];

            // Dictionary<Tkey, TValue> -- Open Generic (no one has specified what type of thing it is yet)
            // Arity (`2) => how many generic type parameters a type has. Dictionary`2
            // like a physical dictionary, kinda
            // Keys have to be unique
            // our dictionary is keyed by strings, and has string values
            // Good for: infrequently updated but often read data
            // Good for: loading information at startup or in the background and fast retrieval on demand (caching)
            var dictionary = new Dictionary<string, string>(); // closed generic (we have told it how to behave)

            // adding things requires a key and a value
            dictionary.Add("Penultimate", "second to last");
            dictionary.Add("Jib", "The things that stick out of rollercoasters");
            dictionary.Add("Arbitrary", "Someone who doesn't like Arby's");

            // get one thing based on its key
            var definition = dictionary["Arbitrary"];
            // Console.WriteLine(definition);

            // this won't work : dictionaries require each key to be unique
            // dictionary.Add("Penultimate", "Thing said too many times at the Olympics");


            // Try methods return a boolean indicating success or failure
            // kind of expensive just to find out if the key exists
          if   (!dictionary.TryAdd("Penultimate", "Thing said too many times at the Olympics"))
            {
                Console.WriteLine("Its already in the dictionary, I couldn't add it");
            }

            if (dictionary.ContainsKey("Penultimate"))
            {
                dictionary["Penultimate"] = "Thing said too many times at the Olympics";
            }

            // give me all the keys in a collection
            var allTheWords = dictionary.Keys;

            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine($"{item.Key}'s definition is {item.Value}");
            //}


            // C# destructuring
            foreach (var (word, def) in dictionary)
            {
                Console.WriteLine($"{word}'s definition is {def}");
            }

            var complicatedDictionary = new Dictionary<string, List<string>>();

            complicatedDictionary.Add("Soup", new List<string> { "Hot or cold liquid you eat." });
            var soupDefinitions = complicatedDictionary["Soup"];
            soupDefinitions.Add("This is a definition of soup");

            complicatedDictionary.Add("Arity", new List<string> { "A definition of arity" });

            foreach (var (word, definitions) in complicatedDictionary)
            {
                Console.WriteLine(word);
                foreach (var def in definitions)
                {
                    Console.WriteLine($"\t{def}");
                }
            }



            // Hashset<T>
            // Like a list in that they store a value at an index
            // Like a dictionary in that the value has to be unique
            // Completly different in that it eliminates non-unique stuff without errors
            // pretty slow at adding data
            // super fast getting data out, comparing data
            //var jamekasName = "Jameka";
            //jamekasName.GetHashCode();

            var uniqueNames = new HashSet<string>();
            uniqueNames.Add("jameka");
            uniqueNames.Add("Dylan");

            uniqueNames.Remove("Dylan");
            
            foreach(var name in uniqueNames)
            {
                Console.WriteLine($"{name} is unique");
            }

            //Queue<T>
            //FIFO based collection

            var queue = new Queue<int>();
            queue.Enqueue(3);
            queue.Enqueue(1);
            queue.Enqueue(5);
            queue.Enqueue(7);
            queue.Enqueue(2);
            queue.Enqueue(100);
            queue.Enqueue(6);

            while(queue.Count > 0)
            {
                Console.WriteLine($"dequeuing  {queue.Dequeue()}");
            }



        }
    }
}