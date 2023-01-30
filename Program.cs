using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee\r\nWage Computation\r\nProgram\n");

           Random rnd = new Random();
           

            int perHourWage = 20;
            int fullDay = 8;
            int totalWage = 0;
            int halfDay = 4;
            int day = 1;
            int present = 0;
            int halfDayPresent = 0;
            int fullDayPresent = 0;
            int absent = 0;
            int totalday = 1;
            int totalHour = 0; 
            
            while (day <= 20 && totalday<=30 && totalHour!=100)
            {
           int check = rnd.Next(0, 3);

                switch (check)
                {
                    case 0:
                        absent++;
                        totalday++;
                        break;

                    case 1:
                        totalWage = totalWage+ perHourWage * halfDay;
                        totalHour = totalHour + halfDay;
                        totalday++; 
                        present++;
                        fullDayPresent++;
                        day++;
                        break;
                        

                    case 2:
                        totalWage =totalWage+ perHourWage * fullDay;
                        totalHour = totalHour + fullDay;
                        totalday++;
                        present++;
                        halfDayPresent++;
                        day++;
                        break;
                }
              

            }
            Console.WriteLine("Employee is absent in a month - " + absent);

            Console.WriteLine("Employee is present for full day in a month - " + fullDayPresent);
            Console.WriteLine("Employee is present for half day in a month - " + halfDayPresent);
            Console.WriteLine("Total present - " +present);
            Console.WriteLine("Total Hour worked by Employee in month - "+totalHour+" Hour");
            Console.WriteLine("Employee's monthly wage is - " + totalWage);
        
        }
    }
}
