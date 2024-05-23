using System.ComponentModel.Design;

namespace _23_05_24_EV_T
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Reverse Array
            /* TASK 1 - Arrayin tersine cevrilmesi*/
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            if (true)
            {
                int[] modifiedNumbers = new int[numbers.Length];
                for (int i = numbers.Length - (1); i >= 0; i--)
                {
                    modifiedNumbers[numbers.Length - 1 - i] = numbers[i];
                }
                for (int i = 0; i < modifiedNumbers.Length; i++)
                {
                    Console.Write(modifiedNumbers[i] + " ");
                }
            }
            #endregion








        }
}
}
