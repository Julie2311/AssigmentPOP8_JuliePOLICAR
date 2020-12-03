using System;
using System.Collections;
using System.Collections.Generic;

namespace AssigmentPOP8_JuliePOLICAR
{
    class Program
    {
        private static Student student;
        private static Adress adress;
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("Hello! Here are some questions please answer carefully :) ");
                Console.WriteLine("Please enter a firstname : ");
                string firstname = Console.ReadLine();
                Console.WriteLine("Please enter a lastname : ");
                string lastname = Console.ReadLine();

                ArrayList scores = new ArrayList();
                Console.WriteLine("Please enter a grade :");
                int g1 = int.Parse(Console.ReadLine());
                scores.Add(g1);
                Console.WriteLine("Please enter a grade :");
                int g2 = int.Parse(Console.ReadLine());
                scores.Add(g2);
                Console.WriteLine("Please enter a grade :");
                int g3 = int.Parse(Console.ReadLine());
                scores.Add(g3);

                Console.WriteLine("Please enter the age of the student : ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the student number : ");
                string studentnb = Console.ReadLine();
                Console.WriteLine("Please enter the street :");
                string street = Console.ReadLine();
                Console.WriteLine("Please enter the city :");
                string city = Console.ReadLine();
                Console.WriteLine("Please enter the country :");
                string country = Console.ReadLine();


                Adress adress = new Adress(street, city, country);
                Student student = new Student(firstname, lastname, studentnb, age, adress);

                double avscore = student.CalculateAvScore(scores);

                string fullname = student.FN();

                string adress1 = student.FullAdress();

                Console.WriteLine("Here are the tasks:\n"
                                 + "1: Click here to display the average score of the student\n"
                                 + "2: Click here to display the city where lives the student\n"
                                 + "3: Click here to display the adress where lives the student\n"
                                 + "4: Click here to display all the information about the student\n");
                int number = ChooseNumber();
               

                switch (number)
                {
                    #region
                    case 1:
                        
                        // Displaying the average score 

                        Console.WriteLine($"The student {fullname} has an average score of {avscore}.");

                        break;

                    case 2:
                        
                        //Displaying the city

                        Console.WriteLine($"The student {fullname} lives in {city}.");

                        break;

                    case 3:

                        // Displaying The full adress

                        Console.Write($"The student {fullname} is living at {adress1}.");

                        break;

                    case 4:

                        student.ToString();

                        break;

                    default:
                        return;
                        #endregion
                }
                Console.WriteLine("\nEnter Escape to stop the program or any key to choose another task.");
                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.Escape);
        }
        private static int ChooseNumber()
        {
            // Initialization
            int nombre;

            //Program logic
            do
            {
                nombre = Convert.ToInt32(Console.ReadLine());
            } while (nombre < 0 && nombre > 4);
            return nombre;
        }

    

        



    }
}

