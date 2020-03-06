using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();

               

              
            }
            catch(Exception ex)
            {
                Console.WriteLine("There was an error: {0}", ex.Message);
            }finally
            {
                Console.WriteLine("rest of my app ru");
            }
             

           
        }
    }
}
