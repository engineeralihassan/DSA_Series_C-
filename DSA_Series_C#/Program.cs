
// The Lecture no 3
// Conditionals and loop 
//Console.WriteLine("Please entert the value of A");
//int c = int.Parse(Console.ReadLine());

//if (c > 6)
//{
//    Console.WriteLine("C is valid number ");
//    Console.WriteLine("Press any key to display its ASCII code...");
//    ConsoleKeyInfo keyInfo = Console.ReadKey();
//    int asciiCode = (int)keyInfo.Key;

//    Console.WriteLine("\nThe ASCII code of the key you pressed is: " + asciiCode);
//}

//// If else assignment 

//Console.WriteLine("Enter a character: ");
//char input = Console.ReadKey().KeyChar;

//if (char.IsLower(input))
//{
//    Console.WriteLine("\nIt's a lowercase letter.");
//}
//else if (char.IsUpper(input))
//{
//    Console.WriteLine("\nIt's an uppercase letter.");
//}
//else
//{
//    Console.WriteLine("\nIt's not a letter.");
//}

// Loops in c#
//int c=int.Parse(Console.ReadLine());
//int i= 1;
//while (i <=10)
//{
//    Console.WriteLine($"{c} X {i} = {c * i} ");
//    i++;
//}

// Sum of numbers 

//Console.WriteLine("Enter the number you want to calculate the sum");
//int d=int.Parse(Console.ReadLine());
//int sum = 0;
//List<int> list = new List<int>(); ;
//for (int i=1; i<=d; i++)
//{
//    int s = 0;
//    if (i % 2 == 0)
//    {
//        list.Add(i);
//        s++;
//        sum = sum + i;
//    }

//}
//Console.WriteLine($"The total sum of even numbers" +
//    $" : {sum}");
//for(int i=0; i<list.Count; i++)
//{
//    Console.WriteLine(list[i]);
//}

//// Prime number example 
//Console.WriteLine("Enter any number to check its prim or not ");
//int primeNumber= int.Parse(Console.ReadLine());
//Boolean t = false;
//for(int i=2;i<primeNumber; i++)
//{
//  if(primeNumber % i == 0)
//    {
//        t = true;
//    }
//}
//if (t)
//{
//    Console.WriteLine("The given  number is Prime ");
//}
//else
//{
//    Console.WriteLine("The given number is not prime number ");
//}

// Paterns questions
//int num= int.Parse(Console.ReadLine());
//for(int i=1; i<=num; i++)
//{
//    for(int j=1; j<=num; j++)
//    {
//        Console.WriteLine("*");
//    }
//}

//Second Pattern Question
//Console.Write("Enter a number: ");
//int number = int.Parse(Console.ReadLine());

//for (int i = 1; i <= number; i++)
//{
//    for (int j = 1; j <= number; j++)
//    {
//        Console.Write(i);
//    }
//    Console.WriteLine();
//}

// Pattern Q 3
//Console.Write("Enter a number: ");
//int number = int.Parse(Console.ReadLine());

//for (int i = 1; i <= number; i++)
//{
//    for (int j = 1; j <= number; j++)
//    {
//        Console.Write(j);
//    }
//    Console.WriteLine();
//}
// Assignment 
//Console.Write("Enter a number: ");
//int number1 = int.Parse(Console.ReadLine());

//for (int i = 1; i <= number1; i++)
//{
//    for (int j = 1; j <= number1; j++)
//    {
//        Console.Write(number1-j+1);
//    }
//    Console.WriteLine();
//}
// Assignment
//Console.Write("Enter a number: ");
//int number1 = int.Parse(Console.ReadLine());
//int count = 1;
//for (int i = 1; i <= number1; i++)
//{
//    for (int j = 1; j <= count; j++)
//    {
//        Console.Write("* ");
//    }
//    Console.WriteLine("\n");
//    count++;
//}

// Assignment 

//Console.Write("Enter a number: ");
//int number = int.Parse(Console.ReadLine());

//int count = 1;

//for (int i = 1; i <= number; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write(count + " ");
//        count++;
//    }
//    Console.WriteLine();
//}

//Console.Write("Enter a number: ");
//int number = int.Parse(Console.ReadLine());

//for (int i = 1; i <= number; i++)
//{
//    int currentValue = i;

//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write(currentValue + " ");
//        currentValue++;
//    }

//    Console.WriteLine();
//}

// Assignment 
//Console.Write("Enter a number: ");
//int number = int.Parse(Console.ReadLine());

//for (int i = 1; i <= number; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write(i-j+1 + " ");
//    }

//    Console.WriteLine();
//}



//Console.Write("Enter a number: ");
//int number = int.Parse(Console.ReadLine());
//char letter = 'A';
//for (int i = 1; i <= number; i++)
//{
//    for (int j = 1; j <= number; j++)
//    {
//       ;
//        Console.Write( $"{letter+j-1} ");
//    }
//    letter++;
//    Console.WriteLine();
//}
// Assignment
//Console.Write("Enter a number: ");
//int number = int.Parse(Console.ReadLine());

//for (int i = 0; i < number; i++)
//{
//    for (char letter = 'A'; letter < 'A' + number; letter++)
//    {
//        Console.Write(letter);
//    }
//    Console.WriteLine();
//}
// Assignment
//Console.Write("Enter a number: ");
//int number = int.Parse(Console.ReadLine());
//char letter = 'A';
//for (int i = 0; i < number; i++)
//{
//    for (int a =1 ;a<=number; a++)
//    {
//        Console.Write(letter);
//        letter++;
//    }
//    Console.WriteLine();
//}
// Assignment 
// abc
// Bcd
// cDE
//DEF

// Assignment
//Console.Write("Enter a number: ");
//int number = int.Parse(Console.ReadLine());

//for (int i = 1; i <= number; i++)
//{
//    for (int j = 1; j <= number - i; j++)
//    {
//        Console.Write("* ");
//    }

//    for (int k = 1; k <= i; k++)
//    {
//        Console.Write(k + " ");
//    }

//    Console.WriteLine();
//}
// Assignment

// The assignment
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    int space = number - i;
    for (int j = 1; space>0; j++)
    {
        Console.Write("*");
        space--;
    }

    for (int k = 1; k <= i; k++)
    {
        Console.Write(k);
    }
    for (int k = 1; k > 0; k--)
    {
        Console.Write(k);
        
    }
   
    Console.WriteLine();
}