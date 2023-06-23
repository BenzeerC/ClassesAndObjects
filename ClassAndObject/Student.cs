using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    //4.	Create class Student, with roll no , name , percentage auto implemented properties.
    //Use property initialize syntax to assign the values.
    //Print the student details
    public class Student
    {
        private  int studentId;
        private string studentName;
        private int percentage;
        private static int count = 0;

        public Student(string studentName)
        {
            count++;
            studentId = count;
            this.studentName = studentName;
            //this.percentage = percentage;
        }

        public void CalculatePercentage(int totalMarks, int totalSubject)
        {
            percentage = totalMarks / totalSubject;
           // return percentage;

        }
        public static int GetCount()
        {
            return count;
        }

        public override string ToString() 
        {
            return $"Student Id:{studentId}\nStudent Name:{studentName}\nPercentage:{percentage}";
        }

        public static void Main(string[] args)
        {
            Student student = new Student("Arsh");
            student.CalculatePercentage(450, 5);


            //student.studentName="Hiyansh";
           // Console.WriteLine(student.ToString());
            Console.WriteLine(student.ToString());
        }


    }
}
