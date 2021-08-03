using System;
using System.Collections.Generic;

namespace CollectionsAndStuff
{
    class Program
    {
        static void Main(string[] args)
        {
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


        }
    }
}
