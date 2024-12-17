using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfosoftTraining
{
    internal class Lessons

    {
        // Lesson 1 Hello World
        public void Lesson1()
        {
            Console.WriteLine("LESSON 1 INTRODUCTION TO C#");
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello \nWorld");

        }

        // Lesson 2 Data Variables and Data Types
        public void Lesson2()
        {
            string name = "Karl Vincent Paclar";
            int age = 22;
            double GPA = 1.5;
            char sex = 'M';

            Console.WriteLine("LESSON 2 VARIABLES AND DATA TYPES");
            Console.WriteLine("My name is " + name);
            Console.WriteLine("I'm " + age + " years old");
            Console.WriteLine("My GPA is " + GPA);
            Console.WriteLine("My sex is " + sex);
        }
        // Lesson 3 Basic Input and Output
        public void Lesson3()
        {
            string name, location, study;


            Console.WriteLine("LESSON 3 BASIC INPUT AND OUTPUT");
            Console.Write("Name       : ");
            name = Console.ReadLine();

            Console.Write("Location   : ");
            location = Console.ReadLine();

            Console.Write("Study      : ");
            study = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Hi my name is " + name);
            Console.WriteLine("I'm from " + location);
            Console.WriteLine("I study in " + study);

        }
        // Lesson 4 Operators and Expressions
        public void Lesson4()
        {
            Console.WriteLine("LESSON 4 OPERATORS AND EXPRESSIONS");

            Console.WriteLine("Enter your grade to Calculate your GPA");

            Console.Write("Math          :");
            double math = Convert.ToSingle(Console.ReadLine());

            Console.Write("Science       :");
            double science = Convert.ToSingle(Console.ReadLine());

            Console.Write("English       :");
            double english = Convert.ToSingle(Console.ReadLine());

            Console.Write("Computer      :");
            double computer = Convert.ToSingle(Console.ReadLine());


            double average = (math + science + english + computer) / 4;

            Console.WriteLine("Your average grade is " + average);

        }
        // Lesson 5 Conditional Statements

        public void Lesson5()
        {
            Console.WriteLine("LESSON 5 CONDITIONAL STATEMENTS");

            Console.WriteLine("Enter your grade to Calculate your GPA and see if you passed.");

            Console.Write("Math          :");
            double math = Convert.ToSingle(Console.ReadLine());

            Console.Write("Science       :");
            double science = Convert.ToSingle(Console.ReadLine());

            Console.Write("English       :");
            double english = Convert.ToSingle(Console.ReadLine());

            Console.Write("Computer      :");
            double computer = Convert.ToSingle(Console.ReadLine());


            double average = (math + science + english + computer) / 4;

            Console.WriteLine("Your average grade is " + average);

            if (average > 100) Console.WriteLine("Invalid Grade");
            else if (average >= 98) Console.WriteLine("With Highest Honors");
            else if (average >= 95) Console.WriteLine("With High Honors");
            else if (average >= 90) Console.WriteLine("With Honors");
            else if (average >= 75) Console.WriteLine("Passed");
            else Console.WriteLine("Failed");
        }

        // Lesson 6 Conditional Statements

        public void Lesson6()
        {

            Console.WriteLine("LESSON 6 SWITCH STATEMENTS");

            Console.WriteLine("ONLY USE NUMBERS AND IN A FORMAT EX. MONTH: 12 DAY: 17 YEAR: 2002");


            Console.Write("Month :   ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Day   :   ");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Year  :   ");
            int year = Convert.ToInt32(Console.ReadLine());


            string monthWord;

            switch (month)
            {
                case 1:
                    monthWord = "January";
                    break;
                case 2:
                    monthWord = "February";
                    break;
                case 3:
                    monthWord = "March";
                    break;
                case 4:
                    monthWord = "April";
                    break;
                case 5:
                    monthWord = "May";
                    break;
                case 6:
                    monthWord = "June";
                    break;
                case 7:
                    monthWord = "July";
                    break;
                case 8:
                    monthWord = "August";
                    break;
                case 9:
                    monthWord = "September";
                    break;
                case 10:
                    monthWord = "October";
                    break;
                case 11:
                    monthWord = "November";
                    break;
                case 12:
                    monthWord = "December";
                    break;
                default:
                    monthWord = "";
                    Console.WriteLine("Invalid Month Input");
                    break;
            }

            if (day <= 31)
            {
                if (monthWord != "") Console.WriteLine(monthWord + " " + day + ", " + year);
            }
            else Console.WriteLine("Invalid Day, Day is only up to 31.");



        }
        // Lesson 7 While and Do-While Loops
        public void Lesson7()
        {
            Console.WriteLine("LESSON 7 LOOPS");

            int lives = 3;

            string correctAnswer = "Infosoft";
            string answer;

            while (lives > 0)
            {
                Console.WriteLine("Lives : " + lives);
                Console.WriteLine("What is the name of the company that you are working for right now?");
                Console.WriteLine();
                Console.Write("Answer : ");
                answer = Console.ReadLine();



                if (answer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("CORRECT!");
                    break;
                }
                else lives--;

                if (lives == 0) Console.WriteLine("WRONG! NO LIVES LEFT YOU LOST");

                Console.WriteLine();

            }

        }
        // Lesson 7.5 For-Loops
        public void Lesson75()
        {
            Console.WriteLine("LESSON 7.5 FOR-LOOPS");

            string[] username = { "Karl", "Vincent", "Paclar" };
            string[] password = { "password", "password123", "passwordnikarl" };

            Console.Write("Username : ");
            string authUsername = Console.ReadLine();

            Console.Write("Password : ");
            string authPassword = Console.ReadLine();

            bool isFound = false;

            for (int i = 0; i < username.Length; i++)
            {
                if (authUsername.Equals(username[i], StringComparison.OrdinalIgnoreCase) && authPassword.Equals(password[i], StringComparison.OrdinalIgnoreCase))
                {
                    isFound = true;
                    Console.WriteLine("Welcome, " + username[i]);
                    break;
                }
            }

            if (!isFound) Console.WriteLine("Account Not Found!");
        }
        // Lesson 8 For-Loops
        public void Lesson8()
        {
            int input;

            string[] email = {"paclarvincentkarl@gmail.com",
                              "vincentkarlpaclar@gmail.com",
                              "karlvincentpaclar@gmail.com"};

            string[] username = { "karl",
                                  "vincent", 
                                  "paclar" };

            string[] password = { "karlvincent",
                                 "vincentkarl",
                                 "paclarkarl"};

            
            Console.Write("Index   : ");

            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Email   : " + email[index]);
            Console.WriteLine("Username: " + username[index]);
            Console.WriteLine("Password: " + password[index]);
        }

        // Lesson 9 Functions
        public void Lesson9()
        {

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

           Console.WriteLine(add(numbers));

        }
        static int add(int[] numbers)
        {
            int sum = 0;
            for(int i = 0;i < numbers.Length;i++)
            {
                sum += numbers[i];
            }
            return sum;
        }


    }
}
