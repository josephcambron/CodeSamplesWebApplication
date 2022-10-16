using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace CodeSamplesWebApplication
{
    public class AddTwoIntsInArray
    {
//          Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
//          You may assume that each input would have exactly one solution, and you may not use the same element twice.
//          You can return the answer in any order.
        public int[] TwoSum(int[] nums, int target)
        {
            int[] output = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int a = i + 1; a < nums.Length; a++)
                {
                    if (nums[i] + nums[a] == target)
                    {
                        output[0] = i;
                        output[1] = a;
                        return output;
                    }
                }
            }
            return output;
        }
    }
}