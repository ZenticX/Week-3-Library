using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Library
{
    internal class Student
    {
        //Private fields 
        private int _ID;
        // Static variable to keep track of the next available ID across all students
        private static int _NextID = 1;
        private string _Name;
        private int _Age;
        private int _studentCount = 0;


        //Public properties
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }

        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }
        public int StudentCount
        {
            get { return _studentCount; }
        }

        //Constructor
        public Student()
        {
            ID = _NextID;
            _NextID++;
            _Name = "John Doe";
            _Age = 16;
            _studentCount++;
        }
        //Custom Constructor
        public Student(string name, int age)
        {
            ID = _NextID;
            _NextID++;
            _Name = Name;
            _Age = Age;
            _studentCount++;
        }
        // Methods
        public void Display()
        {
            Console.WriteLine($"Student ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine("-------------------------------------------------");
        }
        public int GetOlder()
        {
            Age++;
            return Age;
        }
    }
}


