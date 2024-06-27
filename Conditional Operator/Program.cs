using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter the student's score: ");
            int score = int.Parse(Console.ReadLine());

            string grade = score >= 90 ? "A" :
                           score >= 80 ? "B" :
                           score >= 70 ? "C" : 
                           score >= 60 ? "D" : "F";

            Console.WriteLine($"The student's grade is: {grade}");
            Console.ReadLine();
        }
    }
}
