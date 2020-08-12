using System;

namespace Q3
{
    class Program
    {   
        private static bool InArrayOrNot(string[] arr, int no){
            bool flag = false;
            foreach(var i in arr){
                if(Convert.ToInt32(i) == no){
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        static void Main(string[] args)
        { 
            var str = Console.ReadLine();
            var tup = str.Split(']');
            var elem = tup[0].Split(',');
            for(int i=0;i<elem.Length;i++)
            {
                elem[i] = elem[i].Remove(0, 1);
                if(i == (elem.Length-1)){
                    elem[i] = elem[i].Remove(elem[i].Length - 1,
                    elem[i].Length - 1);
                    continue;
                }
            }
            var no_to_check = Convert.ToInt32(tup[1].Remove(0, 2)); 
            Console.WriteLine(InArrayOrNot(elem, no_to_check) ? "True" : "False");
        }
    }
}
