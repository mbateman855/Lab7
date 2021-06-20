using System;
using System.Text.RegularExpressions;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NameValidation("Morgan Bateman"));
            Console.WriteLine(DateValidation("07/26/1996"));
           
        }
        static bool NameValidation(string name)
        {
            Regex nameValidation = new Regex(@"[A-Z][a-z]{1,30}");
            return nameValidation.IsMatch(name);
        }
        static bool DateValidation(string date)
        {
            Regex dateValidation = new Regex(@"\d{2}/\d{2}/\d{4}");
            return dateValidation.IsMatch(date);
        }
    }
}
