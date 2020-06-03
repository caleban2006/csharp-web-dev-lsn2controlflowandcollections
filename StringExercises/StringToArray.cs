using System;
using System.Collections.Generic;
using System.Text;

namespace StringExercises
{
    class StringToArray
    {
        public static void GetArray()
        {
            string myString = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";
            //string[] myArray = myString.Split(" ");
            //Console.WriteLine(string.Join(",", myArray));

            string[] myArray = myString.Split(".");
            Console.WriteLine(string.Join(",", myArray));
        }

    }
}
