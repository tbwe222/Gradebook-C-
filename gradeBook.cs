using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
          
          var book = new book();
          book.addgrade(89.1);
          List<double> grade = new List<Double>(){12.3, 31.3, 12.2, 23.4};
          grade.Add(56.1);

          var sum = 0.0;
          for(int i = 0; i < grade.Count; i++){
            sum += grade[i];
          }

          var avg = sum / grade.Count;
          Console.WriteLine("the average score is" + avg);
        }
    }
}
