﻿using System;

namespace EnrolmentSystem
{
    internal class Student : Person 
    {

        //private int studentID;
        //private string program;
        //private DateTime dateRegistered;

        //Property Assessor Methods:
        public string StudentID { get; set; }
        public string Program { set; get; }
        public DateTime DateRegistered { get; set; }
        public Enrollment StudentEnrollment { get; set; }  //Aggregation 



        //constants for defaults

        const string DEF_STUDENT_ID = "None provided";
        const string DEF_PROGRAM = "None provided";
        private static readonly DateTime DEFAULT_DATE = DateTime.MinValue;
        //private static Enrollment DEF_ENROLMENT = null; 


        // No-argument constructor

        public Student() : this(DEF_STUDENT_ID, DEF_PROGRAM, DEFAULT_DATE,new Enrollment())
        {
        }

        // All-argument constructor
        public Student(string studentID, string program, DateTime date, Enrollment enrollment)
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = date;
            StudentEnrollment = enrollment;
        

        }

        //ToSTring 

        public override string ToString()
        {
            return "Student ID: " + StudentID+ "\nProgram: " + Program + "\nDate Registered : " + DateRegistered;

        }





    }
}


