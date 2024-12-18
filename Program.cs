﻿using System;
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

            //Lesson 3 Basic Input and Output 
            lessons.Lesson3();
            Console.WriteLine();


            //Lesson 4 Operators and Expressions
            lessons.Lesson4();
            Console.WriteLine();

            //Lesson 5 Conditional Statements 
            lessons.Lesson5();
            Console.WriteLine();


            //Lesson 6 Switch Statements 
            lessons.Lesson6();
            Console.WriteLine();

            //Lesson 7 Loops
            lessons.Lesson7();
            Console.WriteLine();

            //Lesson 7.5 For-Loops
            lessons.Lesson75();
            Console.WriteLine();


            //Lesson 8 Arrays
            lessons.Lesson8();
            Console.WriteLine();


            //Lesson 9 Functions
            lessons.Lesson9();
            Console.WriteLine();

        }
    }
}
