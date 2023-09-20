using System;

namespace Calculator
{
class Program
{
    static void Main(string[] args)
    {
        int input1;
        int input2;
        int answer;

        Console.WriteLine("Enter the type of calculation required (Add, Subtract, Multiply or Divide): ");

        string response = Console.ReadLine().ToLower(); // make inputs lowercase

        if((response == "add") || (response== "+")) {

            Console.WriteLine("Enter first value:");
            string first=Console.ReadLine();
            input1 = System.Convert.ToInt32(first);

            Console.WriteLine("Enter second value:");
            string second = Console.ReadLine();
            input2 = System.Convert.ToInt32(second);

            answer=input1+input2;
            Console.WriteLine("result: " + answer);
        }
        else if((response == "subtract") || (response== "-")) {

            Console.WriteLine("Enter first value:");
            string first=Console.ReadLine();
            input1 = System.Convert.ToInt32(first);

            Console.WriteLine("Enter second value:");
            string second = Console.ReadLine();
            input2 = System.Convert.ToInt32(second);

            answer=input1-input2;
            Console.WriteLine("result: " + answer);
        }
        else if((response == "multiply") || (response== "*")) {

            Console.WriteLine("Enter first value:");
            string first=Console.ReadLine();
            input1 = System.Convert.ToInt32(first);

            Console.WriteLine("Enter second value:");
            string second = Console.ReadLine();
            input2 = System.Convert.ToInt32(second);

            answer=input1*input2;
            Console.WriteLine("result: " + answer);
        }
        else if((response == "divide") || (response== "/")) {

            Console.WriteLine("Enter first value:");
            string first=Console.ReadLine();
            input1 = System.Convert.ToInt32(first);

            Console.WriteLine("Enter second value:");
            string second = Console.ReadLine();
            input2 = System.Convert.ToInt32(second);

            answer=input1 / input2;
            Console.WriteLine("result: " + answer);
        }
      
        else {
            Console.WriteLine("Input not recognised. Please try again");

        }
    }
}
}
