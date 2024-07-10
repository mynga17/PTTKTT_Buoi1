using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKTT_Buoi1
{
    class Cau2
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 2, 4, 6, 1, 3, 2, 6 };
            int[] sortedArr = MergeSort(arr);

            foreach (int num in sortedArr)
                Console.Write(num + " ");
        }
        public static int[] MergeSort(int[] arr)
        {
            if (arr.Length <= 1)
                return arr;

            int mid = arr.Length / 2;
            int[] left = MergeSort(arr.Take(mid).ToArray());
            int[] right = MergeSort(arr.Skip(mid).ToArray());

            return Merge(left, right);
        }

        private static int[] Merge(int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;
            int[] result = new int[left.Length + right.Length];

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                    result[k++] = left[i++];
                else
                    result[k++] = right[j++];
            }

            while (i < left.Length)
                result[k++] = left[i++];

            while (j < right.Length)
                result[k++] = right[j++];

            return result;
        }
    }
}
