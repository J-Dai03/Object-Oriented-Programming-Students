using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming_Students
{
    class Teacher : Human
    {
        // Create values
        private string[] Subjects;
        //As in the subjects they teach
        private int NumberOfSubjects = 0;
        private string Form;

        //Constructor
        public Teacher(string form, string address, int age, string name)
        {
            Form = form;
            SetName(name);
            SetAddress(address);
            SetAge(age);
            Subjects = new string[10];
            for (int i = 0; i < 10; i++)
            {
                Subjects[i] = "";
            }
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

        //Subject adder
        public void SubjectAdder(string SubName)
        {
            //check if the subject has already been inputted
            int ItemPos = StringArraySearch(SubName, Subjects);
            if (ItemPos == -1)
            {
                SetSubject(NumberOfSubjects, SubName);
                NumberOfSubjects++;
            }
            else
            {
                SetSubject(ItemPos, SubName); ;
            }
        }

        //String array searcher
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
                    }
                }
            }
        }
    }
}
