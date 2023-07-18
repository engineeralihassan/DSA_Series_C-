// All About bitwise operators or for loop
// in this case we can solve the question on the plateform 
//int a = 3;
//int b = 6;
//Console.WriteLine($" A&B {a & b}");
//Console.WriteLine($" A|B {a | b}");
//Console.WriteLine($" A~B {~ b}");
//Console.WriteLine($" A^B {a ^ b}");


//// left shift right shift operators 
//Console.WriteLine($"12<<2  {12 << 2}");
//Console.WriteLine($"14<<1  {14 << 1}");
//Console.WriteLine($"17>>1  {17 >> 1}");
//Console.WriteLine($"15>>2  {15 >> 2}");

//// Pre-increment ++i post increment operators i++;
//int a1 = 12;
//int b1 = ++a1;
//int c1 = b++;
//Console.WriteLine($"A:{a1} b:{b1} c:{c1}");
//// For loop
//int n = 10; // Number of Fibonacci numbers to generate
//int firstNumber = 0;
//int secondNumber = 1;

//Console.Write($"{firstNumber}, {secondNumber}");

//for (int i = 2; i < n; i++)
//{
//    int nextNumber = firstNumber + secondNumber;
//    Console.Write($", {nextNumber}");

//    firstNumber = secondNumber;
//    secondNumber = nextNumber;
//}for
// Prime or not with break statement 
//int a=int.Parse(Console.ReadLine());
//for(int i = 2; i < a; i++)
//{
//    if(a%i == 0)
//    {
//        Console.WriteLine("Its not a prime number ");
//        break;
//    }
//}

//  scope of variables 


//if(34 >45 )
//{
//    int a = 34;
//    Console.WriteLine(a);
//        }
//if (23 < 67)
//{
//    int a = 9;
//    Console.WriteLine(a);
//}
//// operator precedent 
//int op = 2 * 3 / 4 + 5;
//int c = ((2 * 3) / 4) + 5;

// assignment 
//int num=int.Parse(Console.ReadLine());
//int sum = 0, prod = 1;
//for(int i = 0; num!=0; i++)
//{
//    int digit = num % 10;
//    sum += digit;
//    prod *= digit;
//    num = num / 10;
//}
//Console.WriteLine($"Sum:{sum} Prod :{prod} Answer : {prod-sum}");

// Decimal number system and binary number system . 
//Convert 7 into the binary
// 7/2=3 %=1,3/2=1%=1,111
//2p2+2p1+2p0
//int n=int.Parse(Console.ReadLine());
//int ans = 0;
//int i = 0;
//while (n != 0)
//{
//    int digit = n & 1;
//    ans = (int)(digit * Math.Pow(10, i)) + ans;
//    n = n >> 1;
//    i++;

//}
//Console.WriteLine($"The ans is :{ans}");

// Binary to decimal
// 10101 its an binay
// 2p4+2p3+2p2+2p1+2p0
// take only the 1 digits values= 2p2+2p2+2p0 =16+4+1 =21 correct answers

int n = int.Parse(Console.ReadLine());
int ans = 0;
int i = 0;
while (n != 0)
{
    int digit = n %10;
    if (digit == 1){
        ans = (int)( Math.Pow(2, i)) + ans;
    }
    n = n / 10;
   
    i++;

}
Console.WriteLine($"The ans is :{ans}");


