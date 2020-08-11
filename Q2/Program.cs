using System;

namespace Q2
{
    class Program
    {
        private static int returnMax(int first, int second){
            int ans; // Declaration of ans to be output in the end
            if(first < 20 || second > 30 || first > 30 || second < 20)
                ans = 0; // Condition satisfied if the above holds true. Store in ans.
            else{
                ans = Math.Max(first, second); // Calculation of max of two numbers. Store in ans.
            }
            return ans;
        }
        static void Main(string[] args)
        {
            var no1 = Convert.ToInt32(Console.ReadLine()); // Read first variable
            var no2 = Convert.ToInt32(Console.ReadLine()); // Read second variable
            Console.WriteLine(returnMax(no1, no2));
        }
    }
}
