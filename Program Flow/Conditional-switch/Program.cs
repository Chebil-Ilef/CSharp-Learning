using System;

namespace ConditionalOps
{
    class Program
    {
        static void Main(string[] args)
        {
            int theVal = 53;

            // TODO: The switch statement
            switch(theVal)
            {
                case 50:
                    Console.WriteLine("theVal is 50");
                    break;
                case 51:
                case 52:
                case 53:
                case 54:
                    Console.WriteLine("theVal is betweetn 51 & 54");
                    break;
                default:
                    Console.WriteLine("theVal is sth else");
                    break;
            }

        }
    }
}
