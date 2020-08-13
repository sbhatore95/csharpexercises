using System;

namespace csharpexercises
{
    class Program
    {
        private static readonly char[] alphabet_arr = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o',
            'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z','\0'}; // chracter array used to identify
            // the common term in the input stream.

        static void Main(string[] args)
        {
            string str = Console.ReadLine(); // String to be read from console
            int [] count_keeper = new int[27]; // Stores frequencies of all the chracters
            for(int j=0;j<27;j++){
                count_keeper[j] = 0;
            } // Initializing the count keeper to 0 for each of the 26 alphabet characters.
            foreach(var character in str){
                count_keeper[Convert.ToInt32(character) - Convert.ToInt32('a')]++; 
                // converting the character in str to int and ...
            } // Storing all frequencies of characters in str in count_keeper
            int max_freq = 0; // Keep the dummy variable to 0 indicating 'a' is most frequent
            int keep_max = count_keeper[0]; // Keep 'a' at max for first.
            for(int i=1;i<26;i++){ // Going through 'b' to 'z' counts through i
                if(keep_max < count_keeper[i]){  
                    max_freq = i; // dummy_max_freq will keep the latest highest index of count_keeper.
                    keep_max = count_keeper[i]; // keep_max will keep the highest found value of count_keeper
                }
            }
            char answer = alphabet_arr[max_freq]; // Converts character at max frequency to 
            Console.WriteLine(answer); // converting from decimal to char
        }
    }
}
