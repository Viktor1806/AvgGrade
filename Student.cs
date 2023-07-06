using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AvgGrade
{
    class Student
    {
        private string name;
        private int belGrade;
        private int mathGrade;
        private int infoGrade;

        public Student(string name, int belGrade, int mathGrade, int infoGrade)
        {
            this.name = name;
            this.belGrade = belGrade;
            this.mathGrade = mathGrade;
            this.infoGrade = infoGrade;
        }

        public string Name { get => name; set => name = value; }
        public int BelGrade { get => belGrade; set => belGrade = value; }
        public int MathGrade { get => mathGrade; set => mathGrade = value; }
        public int InfoGrade { get => infoGrade; set => infoGrade = value; }
    }
}
