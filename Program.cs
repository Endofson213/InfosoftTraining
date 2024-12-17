using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfosoftTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lessons lessons = new Lessons();

            //Lesson 1 Introduction to C#
            
            lessons.Lesson1();
            Console.WriteLine();

            //Lesson 2 Variables and Data Types
            lessons.Lesson2();
            Console.WriteLine();

            //Lesson 3 Variables and Data Types
            lessons.Lesson3();
            Console.WriteLine();


            //Lesson 4 Arithmetic Operators
            lessons.Lesson4();
            Console.WriteLine();

            //Lesson 5 Arithmetic Operators
            lessons.Lesson5();
            Console.WriteLine();


            //Lesson 6 Arithmetic Operators
            lessons.Lesson6();
            Console.WriteLine();

        }
    }
}
