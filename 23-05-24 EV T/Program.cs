using System.ComponentModel.Design;

namespace _23_05_24_EV_T
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Reverse Array
            /* TASK 1 - Arrayin tersine cevrilmesi*/
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //if (true)
            //{
            //    int[] modifiedNumbers = new int[numbers.Length];
            //    for (int i = numbers.Length - (1); i >= 0; i--)
            //    {
            //        modifiedNumbers[numbers.Length - 1 - i] = numbers[i];
            //    }
            //    for (int i = 0; i < modifiedNumbers.Length; i++)
            //    {
            //        Console.Write(modifiedNumbers[i] + " ");
            //    }
            //}
            #endregion

            #region Common element between the two arrays
            /* TASK 2 -  Birinci array daxilinde olan butun reqemler, 2 ci array daxilinde var ya yox?*/

            //int[] numbers = { 1, 2, 3, 4, };
            //int[] numbers2 = { 1, 3, 5, 6, };
            //bool commonElement = false;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = 0; j < numbers2.Length; j++)
            //    {

            //          if (numbers[i] == numbers2[j])
            //          {
            //            commonElement = true;
            //            break;
            //          }
            //         else
            //         {
            //            commonElement = false;

            //         }
            //    }
            //}

            //if (commonElement = true)
            //{
            //    Console.WriteLine("There is a common element between the two arrays.");
            //}
            //else
            //{
            //    Console.WriteLine("There is no common element between the two arrays");
            //}
            #endregion


            #region back-to-back duplicate number
            /* TASK 3 - Eyni reqemden yan-yana duplicate varsa, bunu bize bildirsin */
            int[] numbers = { 1, 2, 4, 4, 5, };
            bool duplicateNumber = false;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    duplicateNumber = true;
                    Console.WriteLine($"Duplicate number found: {numbers[i]}");
                }

            }
            #endregion









        }
    }
}
