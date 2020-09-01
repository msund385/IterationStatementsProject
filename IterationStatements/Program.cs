using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
           

            
            var numbers = new List<int>();

            
            int i = 0;


            do
            {
                i++;
                numbers.Add(i);

            } while (i <= 100);


            while (i <= 200)
            {
                i++;
                numbers.Add(i);
                
            }

            Console.WriteLine("Increase:");




            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            

           Console.WriteLine("");
           Console.WriteLine("Decrease:");

           for (i = 199; i <= numbers.Count; i--)
           while(i >= 0)
            // in your initializer set the value of i to 199
            //in your conditional, as long as i is less than or equal to the amount of items in "numbers" (numbers.Count)
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            {
               Console.WriteLine(numbers[1]);
            }
        }
    }
}
