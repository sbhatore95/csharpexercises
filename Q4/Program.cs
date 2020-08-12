using System;

namespace Q4
{
    class Program
    {
        public static string newString(string str, int num){
            string ans = ""; // Final string to be returned
            if(num > str.Length - 1) // Checking for the feasability of the problem statement
                return "Not Feasible";
            else{
                ans += str[num+1]; // appending the first character
                ans += str[num+2]; // appending the second character
            }
            return ans; // returning the final answer
        }
        static void Main(string[] args)
        {
            var str = Console.ReadLine(); // Read the one line input
            var tuple = str.Split(','); // separating the  read input into a tuple
            var full_str = tuple[0]; // First part of the tuple is the input string
            int number = Convert.ToInt32(tuple[1].Remove(0, 1)); // Parsing the string form of number
            Console.WriteLine(newString(full_str, number)); // final output
        }
    }
}
