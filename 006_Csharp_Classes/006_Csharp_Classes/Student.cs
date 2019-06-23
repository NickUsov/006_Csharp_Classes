using System;
using System.Collections.Generic;
using System.Text;

namespace _006_Csharp_Classes
{
    partial class Student
    {
        string firstName;
        string lastName;
        string fathersName;
        string group;
        int[][] scores;
        public Student()
        {
            this.scores = new int[3][];
            this.scores[0] = new int[0];
            this.scores[1] = new int[0];
            this.scores[2] = new int[0];
        }
        public Student(string firstName):this()
        {
            this.firstName = firstName;
        }
        public Student(string firstName,string fathersName):this(firstName)
        {
            this.fathersName = fathersName;
        }
        public Student(string firstName, string fathersName, string lastName):this(firstName, fathersName)
        {
            this.lastName = lastName;
        }
        public Student(string firstName, string fathersName, string lastName, string group):this(firstName,fathersName,lastName)
        {
            this.group = group;
        }
        public Student(string firstName, string fathersName, string lastName, string group, int[][] scores):this(firstName, fathersName, lastName,group)
        {
            if (scores.Length == 3)
                this.scores = scores;
            else
                Console.WriteLine("Not correct length setting scores array");
        }
    }
}
