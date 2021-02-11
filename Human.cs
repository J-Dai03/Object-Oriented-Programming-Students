
using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming_Students
{
    class Human
    {
        // Create values
        private string FullName, Address;
        private int Age;

        //Default constructor
        public Human()
        {
            FullName = "";
            Address = "";
            Age = 0;
        }

        // Full constructor
        public Human(string name, int age, string address)
        {
            FullName = name;
            Age = age;
            Address = address;
        }

        //Get/Set variables
        public string GetName()
        {
            return FullName;
        }
        public void SetName(string INPUT)
        {
            FullName = INPUT;
        }
        public string GetAddress()
        {
            return Address;
        }
        public void SetAddress(string INPUT)
        {
            Address = INPUT;
        }
        public int GetAge()
        {
            return Age;
        }
        public void SetAge(int INPUT)
        {
            Age = INPUT;
        }
    }
}
