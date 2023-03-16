using System;

namespace FlowControl
{

    // enum for options to choose from
    enum Options
    {

        Aggregate = 1,

        MinMark = 2,

        MaximumMark = 3,

        Grade = 4

    }

    class Student
    {
        public string Name;
        public decimal[] Marks = new decimal[5];

        static decimal AverageMarks;

        /// <summary>
        /// This method calculates the average marks. 
        /// </summary>
        /// <returns>decimal</returns>
        public decimal CalculateAverageMarks()
        {
            decimal sumMarks = 0;

            foreach (decimal mark in Marks)
            {
                sumMarks += mark;
            }

            AverageMarks = sumMarks / Marks.Length;
            return AverageMarks;

        }

        /// <summary>
        /// This method calculates the grade according to the marks.
        /// </summary>
        /// <param name="marks"></param>
        /// <returns>string</returns>
        public string CalculateGrade(decimal marks)
        {
            switch(marks)
            {
                case > 90:
                    return "A";
                    
                case > 80 :
                    return "B";
                  
                case > 70 :
                    return "C";
                   
                case < 70:
                    return "D";
                  
                default:
                    return "wrong option chosen ";
                    
            }
        }

        public static void Main()
        {

            Student student = new Student();
            student.Name = "Suman";
            student.Marks = new decimal[5] { 81, 97, 92, 78, 80 };

            //choice from user to continue or not
            string userChoice = " ";
            
            do
            {
                Console.WriteLine("\n1 - Aggregate: Displays the Name: Average marks \r\n2 - MinMark: Displays the minimum marks of the student\r\n3 - MaximumMark: Displays the maximum mark\r\n4 - Grade: Displays grade\n");
                int choice;
                bool isValidChoice  = int.TryParse(Console.ReadLine(), out choice);
                if(isValidChoice)
                {
                   switch(choice)
                    {
                        case (int)Options.Aggregate:
                            Console.WriteLine($"\n{student.Name} : Average Mark is {student.CalculateAverageMarks()}"); 
                            break;
                        case (int)Options.MinMark:
                            Console.WriteLine($"\n{student.Name} : Minimum Mark is  {student.Marks.Min()}");
                            break;
                        case (int)Options.MaximumMark:
                            Console.WriteLine($"\n{student.Name} : Maximum Mark is  {student.Marks.Max()}");
                            break;
                        case (int)Options.Grade:
                            Console.WriteLine($"\n{student.Name} : Grade is  {student.CalculateGrade(AverageMarks)}");
                            break;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;

                    }

                } else
                {
                    Console.WriteLine("Invalid Option");
                }

                // loop until user enters a valid choice
                do
                {
                    Console.Write("\nDo you want to continue : Yes or No : ");
                    userChoice = Console.ReadLine()!;
                    if (userChoice.ToLower() != "yes" && userChoice.ToLower() != "no")
                    {
                        Console.WriteLine("\nPlease enter a valid choice !!! ");
                    }
                   
                } while (userChoice.ToLower() != "yes" && userChoice.ToLower() != "no");


            } while(userChoice.ToLower() == "yes");
        }

    }
}