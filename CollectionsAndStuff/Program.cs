using System;
using System.Collections.Generic;

namespace CollectionsAndStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            // All of these methods that are on a List


            // List<T> is a generic type, a type that requires me to tell it what type of stuff it does/Likes
            // in this case 'string' is a type of parameter used to tell the List<T> how to work
            var e14Names = new List<string>();

            //add a single item
            e14Names.Add("Martin");
            e14Names.Add("Chie");
            e14Names.Add("Holly");

            // put the item into a certain spot
            e14Names.Insert(1, "Chris");

            // collection initializer - curly braces with elements inside
            var teacherNames = new List<string> { "Nathan", "Jameka", "Dylan" };

            // add one collection to the other
            e14Names.AddRange(teacherNames);

            // remove tom (this uses a thing called reference equality)
            e14Names.RemoveAt(0);

            // remove by expressoion
            e14Names.RemoveAll(name => name.StartsWith("N"));

            // normal C# foreach loop
            foreach (var name in e14Names)
            {
                Console.WriteLine($"{name} is in e14!");
            }

            // inline ForEach loop over a List
            // list specific loop, takes in an action<T> (like a fat arrow fucntion)
            e14Names.ForEach(name => Console.WriteLine($"{name} is in e14 again!"));

            var firstStudent = e14Names[0];

            // Dictionary<Tkey, TValue> -- Open Generic (no one has specified what type of thing it is yet)
            // like a physical dictionary, kinda
            // Keys have to be unique
            // our dictionary is keyed by strings, and has string values
            var dictionary = new Dictionary<string, string>(); // closed generic (we have told it how to behave)

            // adding things requires a key and a value
            dictionary.Add("penultimate", "second to last");
            dictionary.Add("Jib", "The things that stick out of rollercoasters");
            dictionary.Add("Arbitrary", "Someone who doesn't like Arby's");

            // get one thing based on its key
            var definition = dictionary["Arbitrary"];
            // Console.WriteLine(definition);

            // this won't work : dictionaries require each key to be unique
            // dictionary.Add("Penultimate", "Thing said too many times a the olympics");


            // Try methods return a boolean indicating success or failure
            // kind of expensive just to find out if the key exists
          if   (!dictionary.TryAdd("Penultimate", "Thing said too many times at the olympics"));
            {
                Console.WriteLine("Its already in the dictionary, I couldn't add it");
            }

            if (dictionary.ContainsKey("Penultimate"))
            {
                dictionary("Penultimate") = "Thing said too many times at the Olympics";
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





        }
    }
}
