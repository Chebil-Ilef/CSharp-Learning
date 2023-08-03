using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2000;
            int y = 0;
            int result;

            // TODO: try-catch expressions make error checking easier
           // + personalized exception
           
            try{
            if (x> 1000)
               throw new ArgumentOutOfRangeException("x", "x should be less than 1000");
            result = x / y;
            Console.WriteLine("The result is: {0}", result);
            }
            catch(DivideByZeroException ex){
                Console.WriteLine("Cannot divide by zero");
                Console.WriteLine(ex.Message);
           }
           catch (ArgumentOutOfRangeException ex){
               Console.WriteLine("Argument out of range exception: {0}", ex.Message);
               Console.WriteLine(ex.Message);

           }
           finally{
               Console.WriteLine("Cleaning up always executes...");
           }


    }
}
}
