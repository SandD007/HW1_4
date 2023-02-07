//-----------------------------------------------------------------------
// < copyright file="Program.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace HW1_4
{
    using System;

    /// <summary>
    /// Entry class.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Entry point.
        /// </summary>
        /// <param name="args">args.</param>
        public static void Main(string[] args)
        {
            char[] alpabet = new char[0];
            string alpabetStr = "abcdefghijklmnopqrstuvwxyz";
            alpabet = alpabetStr.ToCharArray();
            int[] randomArr = new int[26];
            int oddArrLength = 0;
            int evenArrLength = 0;
            int oddIndex = 0;
            int evenIndex = 0;
            string oddText = null;
            string evenText = null;

            for (int i = 0; i < randomArr.Length; i++)
            {
                randomArr[i] = new Random().Next(1, 27);
                if ((randomArr[i] % 2) != 0)
                {
                    oddArrLength++;
                }
                else
                {
                    evenArrLength++;
                }
            }

            int[] oddNumbers = new int[oddArrLength];
            int[] evenNumbers = new int[evenArrLength];
            char[] oddAlphabet = new char[oddArrLength];
            char[] evenAlphabet = new char[evenArrLength];

            for (int i = 0; i < randomArr.Length; i++)
            {
                if ((randomArr[i] % 2) != 0)
                {
                    oddNumbers[oddIndex] = randomArr[i];
                    oddAlphabet[oddIndex] = alpabet[oddNumbers[oddIndex] - 1];
                    if (oddAlphabet[oddIndex] == 'a' || oddAlphabet[oddIndex] == 'e' || oddAlphabet[oddIndex] == 'i' || oddAlphabet[oddIndex] == 'd' || oddAlphabet[oddIndex] == 'h' || oddAlphabet[oddIndex] == 'j')
                    {
                        string str = char.ToString(oddAlphabet[oddIndex]);
                        string upper = str.ToUpper();
                        char[] arr = upper.ToCharArray();
                        oddAlphabet[oddIndex] = arr[0];
                    }

                    oddIndex++;
                }

                if ((randomArr[i] % 2) == 0)
                {
                    evenNumbers[evenIndex] = randomArr[i];
                    evenAlphabet[evenIndex] = alpabet[evenNumbers[evenIndex] - 1];
                    if (evenAlphabet[evenIndex] == 'a' || evenAlphabet[evenIndex] == 'e' || evenAlphabet[evenIndex] == 'i' || evenAlphabet[evenIndex] == 'd' || evenAlphabet[evenIndex] == 'h' || evenAlphabet[evenIndex] == 'j')
                    {
                        string str = char.ToString(evenAlphabet[evenIndex]);
                        string upper = str.ToUpper();
                        char[] arr = upper.ToCharArray();
                        evenAlphabet[evenIndex] = arr[0];
                    }

                    evenIndex++;
                }
            }

            oddText = string.Join(" ", oddAlphabet);
            Console.WriteLine(oddText);

            evenText = string.Join(" ", evenAlphabet);
            Console.WriteLine(evenText);
        }
    }
}