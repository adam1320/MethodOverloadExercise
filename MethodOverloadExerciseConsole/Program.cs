using System;

namespace MethodOverloadExerciseConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            

        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isDollar)
        {
            var sum = num1 + num2;

            if (isDollar == true && sum == 1) 
            {
                return ($"{sum} dollar");
            }
            else if (isDollar == true && sum > 1)    
            {
                return ($"{sum} dollars");
            }
            else
            {
                return ($"{sum}");
            }

        }
    }
}
