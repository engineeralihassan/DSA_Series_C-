using System.IO.Pipes;

namespace Lecture_08_DSA_Seriese
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello Guys whats up");
            //int num = int.Parse(Console.ReadLine());
            //switch (num)
            //{
            //    case 1:
            //        Console.WriteLine("Case 1 executed");
            //        break;
            //    case 0:
            //        Console.WriteLine("Case 0 executed");
            //        break;
            //    case 10:
            //        Console.WriteLine("Case 10 executed");
            //        int n = int.Parse(Console.ReadLine());
            //        switch (n)
            //        {
            //            case 100:
            //                Console.WriteLine($"The number is : {n}");
            //                break;
            //            case 200:
            //                Console.WriteLine($"The number is : {n}");
            //                break;
            //            case 300:
            //                Console.WriteLine($"The number is : {n}");
            //                break;
            //        }
            //        break;
            //    case 3:
            //        Console.WriteLine("Case 3 executed");
            //        break;
            //    case 5:
            //        Console.WriteLine("Case 5 executed");
            //        break;
            //    case 7:
            //        Console.WriteLine("Case 7 executed");
            //        break;
            //    case 9:
            //        Console.WriteLine("Case 9 executed");
            //        break;
            //    default:
            //        Console.WriteLine("DEfualt case all cases are mismatched");
            //        break;
            //}
            //while (true)
            //{
            //    // Perform some logic...

            //    int choice = int.Parse(Console.ReadLine()) ;  // Get user input for choice

            //    switch (choice)
            //    {
            //        case 1:
            //            // Case 1 logic...
            //            break;

            //        case 2:
            //            // Case 2 logic...
            //            break;

            //        case 3:
            //            // Case 3 logic...
            //            break;

            //        case 4:
            //            // Case 4 logic...
            //            break;

            //        case 5:
            //            // Case 5 logic...
            //            break;

            //        case 6:
            //            Environment.Exit(1);  // Exit the program
            //            break;

            //        default:
            //            // Invalid choice logic...
            //            break;
            //    }

            //    // More logic...
            //}
            // break the infinite loop
            //bool exitProgram = false;

            //while (true)
            //{
            //    // Perform some logic...

            //    int choice = int.Parse(Console.ReadLine());  // Get user input for choice

            //    switch (choice)
            //    {
            //        case 1:
            //            // Case 1 logic...
            //            break;

            //        case 2:
            //            // Case 2 logic...
            //            break;

            //        case 3:
            //            // Case 3 logic...
            //            break;

            //        case 4:
            //            // Case 4 logic...
            //            break;

            //        case 5:
            //            // Case 5 logic...
            //            break;

            //        case 6:
            //            exitProgram = true;  // Set the flag to exit the program
            //            break;

            //        default:
            //            // Invalid choice logic...
            //            break;
            //    }

            //    if (exitProgram)
            //    {
            //        break;  // Exit the infinite loop
            //    }

            //    // More logic...
            //}
            // Assignment 
            //Console.Write("Enter the value: ");
            //int value = int.Parse(Console.ReadLine());

            //int hundreds = value / 100;
            //value %= 100;
            //Console.WriteLine($"The value is : {value}");

            //int fifties = value / 50;
            //value %= 50;
            //Console.WriteLine($"The value is : {value}");
            //int twenties = value / 20;
            //value %= 20;
            //Console.WriteLine($"The value is : {value}");
            //int tens = value / 10;
            //value %= 10;
            //Console.WriteLine($"The value is : {value}");
            //Console.WriteLine($"Number of 100 notes: {hundreds}");
            //Console.WriteLine($"Number of 50 notes: {fifties}");
            //Console.WriteLine($"Number of 20 notes: {twenties}");
            //Console.WriteLine($"Number of 10 notes: {tens}");


            // Doing this by switch case 
            //    Console.Write("Enter the value: ");
            //    int value = int.Parse(Console.ReadLine());

            //    int hundreds = 0, fifties = 0, twenties = 0, tens = 0;

            //    while (value > 0)
            //    {
            //        switch (value)
            //        {
            //            case int n when n >= 100:
            //                hundreds = value / 100;
            //                value %= 100;
            //                break;

            //            case int n when n >= 50:
            //                fifties = value / 50;
            //                value %= 50;
            //                break;

            //            case int n when n >= 20:
            //                twenties = value / 20;
            //                value %= 20;
            //                break;

            //            case int n when n >= 10:
            //                tens = value / 10;
            //                value %= 10;
            //                break;

            //            default:
            //                value = 0; 
            //             // Exit the loop if no valid denomination matches
            //                break;
            //        }
            //    }

            //    Console.WriteLine($"Number of 100 notes: {hundreds}");
            //    Console.WriteLine($"Number of 50 notes: {fifties}");
            //    Console.WriteLine($"Number of 20 notes: {twenties}");
            //    Console.WriteLine($"Number of 10 notes: {tens}");
            //}


            //Console.WriteLine("Wellcome to functions in c#");
            //int Power(int a, int b)
            //{
            //    return (int)Math.Pow(a, b);
            //}
            //int c = Power(12, 2);
            //Console.WriteLine($"The Power is : {c}");

            // Factorial Method 
            int factorial(int n)
            {
                int fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact *= i;
                }
                return fact;
            }
            // cr Method
            int binomial_coefficient(int a, int b)
            {

                int num = factorial(a);
                int denom = factorial(b) * factorial(a - b);
                int ans = num / denom;
                return ans;
            }
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            binomial_coefficient(a, b);
        }  
    }
}