using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeTwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            // maps number to index found in nums array
            Dictionary<int, int> indexesOfFoundNumbers = new();

            for (int i = 0; i < nums.Length; i++)
            {
                var value = nums[i];

                if (!indexesOfFoundNumbers.ContainsKey(value))
                    indexesOfFoundNumbers[value] = i;

                var numberWanted = target - value;
                
                if (indexesOfFoundNumbers.ContainsKey(numberWanted) && indexesOfFoundNumbers[numberWanted]!=i)
                {
                    return new int[] { i, indexesOfFoundNumbers[numberWanted]};
                }
            }

            return Array.Empty<int>();
        }
    }
}
