using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming_Students
{
    class Student
    {
        // Create values
        private string FullName;
        private int Age, CSScore;

        // Default constructor
        public Student()
        {
            FullName = "";
            Age = 0;
            CSScore = 0;
        }

        // Full constructor
        public Student(string name, int age, int score)
        {
            FullName = name;
            Age = age;
            CSScore = score;
        }

        // Personal constructor
        public Student(string name, int age)
        {
            FullName = name;
            Age = age;
            CSScore = 0;
        }

        //Print name
        public void PrintName()
        {
            Console.WriteLine("Name: " + FullName);
        }

        //Print Age
        public void PrintAge()
        {
            Console.WriteLine("Age: " + Age);
        }

        //Print score
        public void PrintScore()
        {
            Console.WriteLine("Computer Science score: " + CSScore);
        }

        //Print personal details
        public void PrintPersonalDetails()
        {
            PrintName();
            PrintAge();
        }

        //Print all details
        public void PrintAllDetails()
        {
            PrintName();
            PrintAge();
            PrintScore();
        }
    }
}
