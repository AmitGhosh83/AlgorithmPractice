using System;

namespace SortSquareArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array is sorted & can have -ve numbers
            int[] arr = new int[] { -6, -4, 1, 2, 3, 5 };
            //int[] arr = new int[] { 1, 2, 4 };
            var result = SortedArray(arr);
            foreach (var number in result)
            {
                Console.Write(number + " ");

            }
            Console.WriteLine();
        }

        //Produce a sqaured array which is also sorted
        public static int[] SortedArray(int[] inputarray)
        {
            int[] temp = new int[inputarray.Length];
            int left = 0;
            int right = inputarray.Length - 1;
            for (int i = 0; i < inputarray.Length; i++)
            {
                if (Math.Abs(inputarray[left]) > Math.Abs(inputarray[right]))
                {
                    temp[inputarray.Length - i - 1] = (int)Math.Pow(inputarray[left], 2);
                    left++;
                }
                else
                {
                    temp[inputarray.Length - i - 1] = (int)Math.Pow(inputarray[right], 2);
                    right--;
                }
            }
            //Array.Sort(temp);
            return temp;
        }
    }
}
