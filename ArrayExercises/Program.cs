using System;

namespace ArrayExercises
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] myArray = { 1, 1, 2, 3, 5, 8 };
            
            Loop.GetLoop(myArray);
            
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //Console.WriteLine(myArray[i]);
            //if (myArray[i] % 2 != 0) 
            //{
            //Console.WriteLine(myArray[i]);
            //};
            //}
        }
    }
}
