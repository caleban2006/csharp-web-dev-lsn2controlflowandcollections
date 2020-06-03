using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExercises
{
    class Loop
    {
        public static int GetLoop(int[] myArray)
        {
            //int[] myArray = { 1, 1, 2, 3, 5, 8 };

            for (int i = 0; i < myArray.Length; i++)
            {
                    //return myArray[i];
                if (myArray[i] % 2 != 0)
                {
                    return myArray[i];
                };
            }
        }

    }
}
