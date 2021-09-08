using System;

namespace MyApp
{

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year to check");
            Console.WriteLine(IsLeapYearErrors(Console.ReadLine()));
            

        }

        public static string IsLeapYearErrors(string readline){
            try{
                int input = Int16.Parse(readline);
                if(input>=1582){
                return IsLeapYearToString(input);
                } else {
                return "You have to enter a year after 1582";
                }
            } catch (Exception e) {
                return e.ToString() + "Exception caught.\n\r Please type a year";
            }
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
