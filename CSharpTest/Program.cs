using System;
using System.Runtime.Intrinsics.X86;


namespace HelloWorld
{


     class Program
    {

        public static void Main(String[] args) 
        {
            Calculator();

        }

        public static int Calculator()

        {

            int result = 0;
            int num1 = 0;
            int num2 = 0;
            Boolean numbsChosen = false;


            while (numbsChosen == false)
            {
                Console.WriteLine("Please enter a number");
                string? num1Input = Console.ReadLine();
                Console.WriteLine("Please enter another number");
                string? num2Input = Console.ReadLine();

                try
                {
                    if (num1Input != null && num2Input != null)
                    {
                        num1 = int.Parse(num1Input);
                        num2 = int.Parse(num2Input);
                        numbsChosen = true;
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Number not found");

                }
            }
     
            Console.WriteLine("Please choose an operator (+, -, /, *)");

            string? opp = Console.ReadLine();

            if (opp != null)
            {
                switch (opp)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        result = num1 / num2;
                        break;

                }
            }

            Console.WriteLine("The answer is... " + result);
            return result;
        }
    }
}
