
//Console.WriteLine("All About binary search");
//// its apply on monitoring functions like ascending or decending order.
//// then find the mid element in the array
//// then we see we run the loop on wich part mean first half or second half 
//// mide level      first index+lenght/2
//// compare then repeat this
//// // then again find mid level and compaire values 
//// Example
//int[] arr = { 12, 45, 67, 89, 123, 456, 789,567 };
//int binarySearch(int[] arr,int search)
//{
//    int start = 0;
//    int end = arr.Length - 1;

//    while (start <= end)
//    {
//        int mid = start + (end - start) / 2;

//        if (arr[mid] == search)
//        {
//            return mid;
//        }
//        if (search > arr[mid])
//        {
//            start = mid + 1;
//        }
//        else
//        {
//            end = mid - 1;
//        }
//    }
//    return -1;
//}
//int search = int.Parse(Console.ReadLine());
//if (binarySearch(arr,search) == -1)
//{
//    Console.WriteLine("You Element is not in the search");

//}
//else
//{
//    Console.WriteLine($"You Element is find the search");
//}
//////////////////  Binary search problems solutions 
using System.IO.Pipes;
/// problem 1 =  find the first and last occurance of an element 
/// // first occurance 

//int[] arr = { 12, 45, 67, 89, 123, 456, 789,  };
//int binarySearch(int[] arr, int search)
//{
//    int start = 0;
//    int end = arr.Length - 1;
//    int ans = -1;
//    while (start <= end)
//    {
//        int mid = start + (end - start) / 2;


//        if (arr[mid] == search)
//        {
//            ans = mid;
//           // return mid;
//           end = mid -1;
//        }
//        else if (search > arr[mid])
//        {
//            start = mid + 1;
//        }
//       else if((search < arr[mid]) )
//        {
//            end = mid - 1;
//        }
//    }
//    return ans;
//}
//int search = int.Parse(Console.ReadLine());

//int ans=binarySearch(arr, search);
//Console.WriteLine( $"The first occurance of {search} in array is at index : {ans}");

//// last occurance 

//int[] arr1 = {12,12,12,12, 45,45, 67, 89, 123, 456, 789, };
//int binarySearch1(int[] arr1, int search1)
//{
//    int start = 0;
//    int end = arr1.Length - 1;
//    int ans = -1;
//    while (start <= end)
//    {
//        int mid = start + (end - start) / 2;


//        if (arr1[mid] == search)
//        {
//            ans = mid;
//            // return mid;
//            start = mid + 1;
//        }
//        else if (search > arr1[mid])
//        {
//            start = mid + 1;
//        }
//        else if ((search < arr1[mid]))
//        {
//            end = mid - 1;
//        }
//    }
//    return ans;
//}
//int search1 = int.Parse(Console.ReadLine());

//int ans1 = binarySearch1(arr1, search1);
//Console.WriteLine($"The last occurance of {search1} in array is at index : {ans1}");
//Console.WriteLine($"The last occurance of {search1} in array is at total : {(ans1+ans)+1}");
//Peak occurance 

//int[] arr1 = { 12, 12, 12, 12, 45, 45, 67, 89, 123, 456, 789, };
//int binarySearch1(int[] arr1, int search1)
//{
//    int start = 0;
//    int end = arr1.Length - 1;
//    int ans = -1;
//    while (start < end)
//    {
//        int mid = start + (end - start) / 2;


//        if (arr1[mid] < arr1[mid+1])
//        {
//            start = mid + 1;
//        }
//        else
//        {
//            end = mid;
//        }
//    }
//    return start;
//}

//// Find Pivot in array
//int FindPivot(int[] arr1)
//{
//int start = 0;
//int end = arr1.Length - 1;
//while (start < end)
//{
//    int mid = start + (end - start) / 2;


//    if (arr1[mid] >= arr1[0])
//    {
//        start = mid + 1;
//    }
//    else
//    {
//        end = mid;
//    }
//}
//return start;
//}

//int searchRotatedSortedArray(int[] arr, int search)
//{
//    int pivot = FindPivot(arr);
//    if (search >= arr[pivot] && search < arr[arr.Length])
//    {
//        //return   binarSearch(arr)

//    }
//    else
//    {
//        //return binarySearch(arr);


//    }
//    return 0;
//}


//Find squar root using binary search

//int start = 0;
//int end = n;
//int ans = -1;
//while (start <= end)
//{
//    int mid = start + (end - start) / 2;

//    int root = mid * mid;
//    if (root == n)
//    {
//        return mid;
//    })
//    if (root < n)
//    {
//        ans = mid;

//    }
//    else
//    {
//        end = mid - 1;
//    }
//    return ans;
//}

//Console.WriteLine($"The squar root is : {root}");


