using System;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var a = TwoSum(new[] { 2,7,11,15 }, 9);
            
            Console.WriteLine(a);
        }
        
        private static int[] TwoSum(int[] nums, int target) {
            for (var i = 0; i < nums.Length; i++) {
                if (nums.Length - i == 1) {
                    break;
                } 
            
                for(var y = i + 1; y < nums.Length; y++) {
                    if (nums[i] + nums[y] == target) {
                        return new[] { i, y };
                    }
                }
            }
        
            return Array.Empty<int>();
        }
    }
}
