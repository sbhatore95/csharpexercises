using System;

namespace Q1
{
    class Program
    {
        static double findAverage(double[] students, int no_of_st)
        {   
            // Sorting the numbers of the students in an descending order
            for(var i=0;i<no_of_st;i++){
                for(int j=0;j<no_of_st-1;j++){
                    double temp;
                    if(students[i] > students[j]){
                        temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }
            double precise_failed = (no_of_st)/10;
            double failed = Math.Floor(precise_failed); // Number of failed students
            // failed = failed - ((failed % 2) > 1 ? (failed- 1 - failed%2) : (failed - failed%2); // The integer part of {failed}
            int count = 0;
            double passed_marks = 0;
            // Increase the {passed_marks} till the desired location.
            int no_of_failed = Convert.ToInt32(failed);
            while(count != no_of_st - no_of_failed){
                passed_marks += Convert.ToInt32(students[count]);
                count++;
            }
            double answer; // The final aswer to be calculated
            answer = passed_marks/Convert.ToDouble(no_of_st); // Caclulation of the final result
            return answer;
        }
        static void Main(string[] args)
        {
            double[] newlist = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            double answer = Program.findAverage(newlist, 10);
            Console.WriteLine(answer);
        }
    }
}
