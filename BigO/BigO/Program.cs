using System;

namespace BigO
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[20000];
            //0(1)
            PerformSomeAction_01(testArray);
            //0(n)
            PerformSomeAction_On(testArray);
            //0(n^2)
            PerformSomeAction_On2(testArray);
            //0(log n)
            PerformSomeAction_On(testArray); //assume array sorted
            PerformSomeAction_OnLogn(testArray);
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();

        }

        private static void PerformSomeAction_OnLogn(int[] testArray)
        {
            //O(log n)
            //2 ^ x = n;
            int loopCount = 0;
            Random rnd = new Random();
            int NumberToFind = rnd.Next(0, testArray.Length);
            int Upper = testArray.Length - 1;
            int Lower = 0;
            int indexi = (int)Math.Floor(Upper / 2.0);
            while (NumberToFind != testArray[indexi])
            {
                loopCount++;
                if (NumberToFind < testArray[indexi])
                {
                    Upper = indexi;
                    indexi = Lower + (int)Math.Floor((Upper - Lower) / 2.0);

                }
                else
                {
                    Lower = indexi;
                    indexi = Lower + (int)Math.Floor((Upper - Lower) / 2.0);
                }
            }
            Console.WriteLine("O(log n) complete in " + loopCount.ToString() + "steps.");
            return;
        }

        private static void PerformSomeAction_On(int[] testArray)
        {
            //O(n)
            int loopCount = 0;
            for (int i = 0; i < testArray.Length; i++)
            {
                loopCount++;
                testArray[i] = i;
            }
            Console.WriteLine("O(n) complete in " + loopCount.ToString() + "steps.");
            return;
        }
        private static void PerformSomeAction_On2(int[] testArray)
        {
            //O(n)
            int loopCount = 0;
            for (int i = 0; i < testArray.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    loopCount++;

                }

            }
            Console.WriteLine("O(n^2) complete in " + loopCount.ToString() + "steps.");
            return;
        }

        private static void PerformSomeAction_01(int[] testArray)
        {
            //O(1)
            int loopCount = 1;
            testArray[0] = 1;
            Console.WriteLine("O(1) complete in " + loopCount.ToString() + "steps.");
            return;

        }


    }
}
