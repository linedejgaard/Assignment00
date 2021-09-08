using System;

namespace MyApp
{

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year to check");
            int input = Int16.Parse(Console.ReadLine());
            Console.WriteLine(IsLeapYearToString(input));

            

        }

        public static string IsLeapYearToString(int input){
            
            
            var year = new Year();
            if(year.IsLeapYear(input)){
                return "yay";
            } else {
                return "nay";
            }
        }
    }

    public class Year{
        public bool IsLeapYear(int year){
            if (year%400 == 0){
                return true;
            } else if(year%100 == 0){
                return false;
            } else if(year%4==4){
                return true;
            } else {
                return false;
            }
        }
    }
}
