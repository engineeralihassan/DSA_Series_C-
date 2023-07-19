using System.Security.AccessControl;

namespace Lecture_09_DSA_Series
{
    internal class Program
    {
       static void PrintArray<T>(T[] arr)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"The value {arr[i]} on index {i}");
            }
        }
        static int[] reversArrray(int[] ar)
        {

            int first = 0;
            int last = ar.Length - 1;

            for(int i = 0; first<last; i++)
            {
                int temp = ar[first];
                    ar[first] = ar[last];
                ar[last] = temp;
                    first++;
                    last--;
               
             
            }
            return ar;
        }
        static void PrintArra1(int[] arr)
        {
            arr[2] = 1234;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"The value {arr[i]} on index {i}");
            }
        }
        static void linearSearch()
        {
            int[] nums = { 5, 7, -2, 10, 22, -2, 0, 345, 567, 89 };
            for (int i = 0;    i < nums.Length;i++)
            {

                if (nums[i] == 1)
                {
                    Console.WriteLine("The 1 is available in list");
                }
                else
                {
                    Console.WriteLine("Hello not available");
                }

            }
        }
        static void printMaxMin(int[] args) {
            int max = args[0];
            int min = args[0];
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] > max)
                {
                  max= args[i];
                }
                if (args[i] < min)
                {
                    min= args[i];
                }

            }
            Console.WriteLine($"The Maximum is  {max} The miimum is   {min}");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("All About the Arrays!");
            // Arrays are the data structure in wich we add the same type of the data 
            // store on the continouse locations . 
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine("The index 1", nums[1]);
            //int[] ns=new int[nums.Length];
            //ns[0]= nums[0];
            //ns[1]=23;
            //ns[2]= 2345;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine($"The value {nums[i]} on index {i}");
            //}
            // Array swith functions

            //Program.PrintArray(nums);

            string[] strings = { "Ali", "Hassan", "Classes", "Lopson" };
            //Program.PrintArray(strings);
            //Program.printMaxMin(nums);
            // Arrays are the int reference based 
            //int[] nums2 = { 1, 2, 3, 4 };
            //Program.PrintArra1(nums2);
            //for(int i = 0;i < nums2.Length;i++)
            //{
            //    Console.WriteLine(nums2[i]);
            //}
            // Program.linearSearch();
            int[] ar = { 2, 5, 7, 9, 8, 6,34 };
           int[] arr = Program.reversArrray(ar);
            for(int i = 0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}