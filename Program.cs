using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee\r\nWage Computation\r\nProgram\n");

           Random rnd = new Random();
            int check = rnd.Next(0,3);
            
            int perHour = 20;
            int fullDay = 8;
            int dailyWage = 0;
            int halfDay = 4;
            if (check == 0)
            {
                Console.WriteLine("Employee is absent ");

            }
            else if (check==1) 
            {
                dailyWage = perHour * halfDay;
               Console.WriteLine("Employee is present for Half day");
                Console.WriteLine("Employee's dailywage is " + dailyWage);
            }

            else
            {
                dailyWage = perHour * fullDay;

                Console.WriteLine("Employee is present for full day");
                Console.WriteLine("Employee's dailywage is " + dailyWage);
            }

        
        }
    }
}
