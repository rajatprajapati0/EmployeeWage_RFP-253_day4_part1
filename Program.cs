using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee\r\nWage Computation\r\nProgram\n");

           Random rnd = new Random();
            int check = rnd.Next(0,2);
            
            int perHour = 20;
            int fullDay = 8;
            int dailyWage = 0;

            if (check == 0) 
            {
                Console.WriteLine("Employee is absent ");

            }
            else 
            {
                dailyWage = perHour * fullDay;   

                Console.WriteLine("Employee is present ");
                Console.WriteLine("Employee's dailywage is "+dailyWage);
            }

        
        }
    }
}
