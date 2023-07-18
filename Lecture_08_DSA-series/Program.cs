
// All baout the Switch case and the Functions 
static void Main()
{
    int num = int.Parse(Console.ReadLine());
    switch (num)
    {
        case 1:
            Console.WriteLine("Case 1 executed");
            break;
        case 0:
            Console.WriteLine("Case 0 executed");
            break;
        case 10:
            Console.WriteLine("Case 10 executed");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 100:
                    Console.WriteLine($"The number is : {n}");
                    break;
                case 200:
                    Console.WriteLine($"The number is : {n}");
                    break;
                case 300:
                    Console.WriteLine($"The number is : {n}");
                    break;
            }
            break;
        case 3:
            Console.WriteLine("Case 3 executed");
            break;
        case 5:
            Console.WriteLine("Case 5 executed");
            break;
        case 7:
            Console.WriteLine("Case 7 executed");
            break;
        case 9:
            Console.WriteLine("Case 9 executed");
            break;
        default:
            Console.WriteLine("DEfualt case all cases are mismatched");
            break;
    }
}

