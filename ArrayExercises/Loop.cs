using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExercises
{
    class Loop
    {
        public static void GetLoop(int[] myArray)
        {
            //int[] myArray = { 1, 1, 2, 3, 5, 8 };

            for (int i = 0; i < myArray.Length; i++)
            {
                    Console.WriteLine(myArray[i]);
                if (myArray[i] % 2 != 0)
                {
                    Console.WriteLine(myArray[i]);
                }
            }
        }

    }
}
