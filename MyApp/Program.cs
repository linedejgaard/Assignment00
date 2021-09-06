using System;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            
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
