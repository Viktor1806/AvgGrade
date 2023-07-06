using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AvgGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            StreamReader reader = new StreamReader("infostudents.txt");
            string line = reader.ReadLine();
            while (line != null)
            {
                List<string> studentInfo = line
                    .Split(',')
                    .ToList();
                Student current = new Student(studentInfo[0], int.Parse(studentInfo[1]), int.Parse(studentInfo[2]),int.Parse(studentInfo[3]));
                students.Add(current);

                line = reader.ReadLine();
            }
            StreamWriter writer = new StreamWriter("output.txt");
            using(writer)
            { 
            foreach (Student st in students)
            {
                double avg = (st.BelGrade + st.MathGrade + st.InfoGrade)/3.0;
                Console.WriteLine($"{st.Name} - {avg:f2}");
            }
        }
     }
  }
}
