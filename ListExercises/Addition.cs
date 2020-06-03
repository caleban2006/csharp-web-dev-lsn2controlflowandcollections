using System;
using System.Collections.Generic;
using System.Text;

namespace ListExercises
{
    class Addition
    {
        public static void GetSum()
        {
            List<int> nums = new List<int>();
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            nums.Add(4);
            nums.Add(5);
            nums.Add(6);
            nums.Add(7);
            nums.Add(8);
            nums.Add(9);
            nums.Add(10);

            int evenSum = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    evenSum += nums[i];
                }
            }
            Console.WriteLine(evenSum);
        }

        public static void WordSearch()
        {
             List<string> names = new List<string>();
        names.Add("trial");
            names.Add("error");
            names.Add("attempt");
            names.Add("nice");
            names.Add("stupid");
            names.Add("dummy");
            names.Add("tired");
            names.Add("virus");
            names.Add("football");
            names.Add("sports");

            Console.WriteLine("Enter a word length to search for:");
            string userInput = Console.ReadLine();
        int wordLength = int.Parse(userInput);

            for (int i = 0; i<names.Count; i++)
            {
                if (names[i].Length == wordLength)
                {
                    Console.WriteLine(names[i]);
                }
}
        }
    }
}
