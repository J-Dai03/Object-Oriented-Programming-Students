﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming_Students
{
    class Student : Human
    {
        // Create values
        private string[] Subjects;
        private string[] Grades;
        private int NumberOfSubjects = 0;
        private string Form;

        // Constructor
        public Student(string form, string address, int age, string name)
        {
            Form = form;
            SetName(name);
            SetAddress(address);
            SetAge(age);
            Subjects = new string[5] { "", "", "", "", "" };
            Grades = new string[5] { "", "", "", "", "" };
        }

        //Get Set functions
        public string GetSubject(int INPUT)
        {
            return Subjects[INPUT];
        }
        public void SetSubject(int SubjectNum, string INPUT)
        {
            Subjects[SubjectNum] = INPUT;
        }
        public string GetGrade(int INPUT)
        {
            return Grades[INPUT];
        }
        public void SetGrade(int SubjectNum, string INPUT)
        {
            Grades[SubjectNum] = INPUT;
        }

        //Subject adder
        public void SubjectAdder(string SubName, string SubGrade)
        {
            //check if the subject has already been inputted
            int ItemPos = StringArraySearch(SubName, Subjects);
            if (ItemPos == -1)
            {
                SetGrade(NumberOfSubjects, SubGrade);
                SetSubject(NumberOfSubjects, SubName);
                NumberOfSubjects++;
            }
            else
            {
                SetGrade(ItemPos, SubGrade);
            }
        }
        
        //Search for subject
        public int StringArraySearch(string target, string[] InputtedArray)
        {
            bool Presence = false;
            int ItemPos = 0;
            int ArrayLength = InputtedArray.Length;
            int i = 0;
            while ((i < ArrayLength) && (Presence == false))
            {
                if (InputtedArray[i] == target)
                {
                    ItemPos = i;
                    Presence = true;
                }
                else
                {
                    i++;
                }
            }
            if (Presence == false)
            {
                ItemPos = -1;
            }
            return ItemPos;
        }

        //Sorter(Alphabetic)
        public void AlphabeticSorter()
        {
            string TempString;
            for (int selected = 0; selected < Subjects.Length - 1; selected++)
            {
                for (int compared = 0; compared < (Subjects.Length - 2); compared++)
                {
                    if ((Subjects[compared].CompareTo(Subjects[compared + 1])) > 0)
                    {
                        TempString = Subjects[compared + 1];
                        Subjects[compared + 1] = Subjects[compared];
                        Subjects[compared] = TempString;
                        TempString = Grades[compared + 1];
                        Grades[compared + 1] = Grades[compared];
                        Grades[compared] = TempString;
                    }
                }
            }
        }
    }
}
