using System;
using System.Collections;
using System.Collections.Generic;

namespace AssigmentPOP8_JuliePOLICAR
{
    public class Student : Person
    {
        // Instance variables
        private string studentnb;
        private int age;
        private Adress adress;
        private ArrayList scores;


        // Constructor
        public Student(string firstname, string lastname, string studentnb, int age, Adress adress) : base(firstname, lastname)
        {

            this.studentnb = studentnb;
            this.age = age;
            this.adress = adress;
           

        }

        // Properties
        public string StudentNumber
        {
            get { return studentnb; }
            set
            {
                studentnb = value;
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Student number is empty !");
                }
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                if (age < 1 || age > 100)
                {
                    throw new ArgumentOutOfRangeException("Age might be 1-100 !");
                }
            }
        }

        public Adress Adress
        {
            get { return adress; }
            set { adress = value; }
        }


        public ArrayList Scores
        {
            get { return scores; }
            set { scores = value; }
        }

        // Methods


        public string FN() //To create the full name with the variables firstname and lastname
        {
            string fullname = firstname + " " + lastname; // Initialization + program logic
            return fullname;
        }

       public double CalculateAvScore(ArrayList scores) //To calculate the average score of a student according to his grade
        {
            //Initialization
            double avscore = 0; 
            double sum = 0; 

            //Program logic
            foreach (int i in scores)
            {
                sum += i;
            }
            avscore = sum / scores.Count;
            avscore = Math.Round(avscore, 2);

            
            //Output
            return avscore;

        }
        
        public string FullAdress()
        {
            return $"{adress.FAdress()}";
        }
        public override string ToString() 
        {

            return $"The Student {firstname} {lastname}'s student number is {studentnb}. /n " +
                $"He is {age}. /n" +
                $"He lives at {adress.FAdress()}. /n";
               // $"His average score is {CalculateAvScore()}"; I don't know why it does not work ...
               
        }
       


    }
}
