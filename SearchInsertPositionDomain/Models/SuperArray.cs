using System;

namespace SearchInsertPositionDomain.Models
{
    public class SuperArray
    {
        /// <summary>Searches the position that the target number would be inserted in the list</summary>
        /// <param name="numbers">List of numbers</param>
        /// <param name="target">The number to insert</param>
        /// <returns>The index that the target number would be inserted</returns>
        public static int SearchInsertPosition(int[] numbers, int target)
        {
            if (numbers.GetType() != typeof(int[]) || target.GetType() != typeof(int))
                return 0;

            Array.Sort(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                if (target <= numbers[i]) return i;
            }

            return numbers.Length;
        }
    }
}