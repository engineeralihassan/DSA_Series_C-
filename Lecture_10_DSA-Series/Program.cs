using System.Collections.Generic;

Console.WriteLine("Hello Ali Leet code problems solving series are started ");
// Problem 1   reverse the arrays
//int[] ar = { 2, 5, 7, 9, 8, 6, 34 ,45};
//for(int i=0;i <ar.Length; i=i+2)
//{
//    if (i + 1 < ar.Length-1)
//    {
//        int temp = ar[i];
//        ar[i] = ar[i+1];
//        ar[i+1] = temp;
//    }
//}
//for (int i = 0; i < ar.Length; i++)
//{
//    Console.WriteLine($" erray i : {i} {ar[i]}");
//}

// example 2

//int[] nums = { 5, 7, 10, 22, -2, -2, 0 };
//Array.Reverse(nums, 1, 3);
//for (int i = 0; i < nums.Length; i++)
//{
//    Console.WriteLine(nums[i]);
//}

// Problem no 2 = find unique 
//int findUnique(int[] arr)
//{
//    int ans = 0;
//    for( int i=0; i<arr.Length; i++)
//    {
//        ans =ans^arr[i];
//    }
//    return ans;
//}
//int[] arr = { 12, 34, 56, 65, 56, 34, 12 };
//Console.WriteLine(findUnique(arr));
// unique number of occrences 
// bool UniqueOccurrences(int[] arr)
//{
//    Array.Sort(arr);
//    List<int> allCount = new List<int>();

//    for (int i = 0; i < arr.Length;)
//    {
//        int count = Array.FindAll(arr, el => el == arr[i]).Length;
//        if (allCount.Contains(count)) return false;
//        else allCount.Add(count);
//        i += count;
//    }
//    return true;
//}

// Find duplicate on leet code 
// find commons 
// Solve this in the 2 pointers approach its mean not used loop inside loop used i loop 

//int[] arr1 = { 12, 23, 45, 12, 56,89,67,54,321 };
//int[] arr2 = { 12, 23, 45, 12, 56 };
//int[] findCommons()
//{
//    List<int> list = new List<int>();
//    for (int i=0; i<arr1.Length; i++)
//    {
//        for(int  j=0; j<arr2.Length; j++)
//        {
//            if (arr1[i] == arr2[j])
//            {
//                list.Add(arr1[i]);
//                break;
//            }
//        }
//    }
//    return list.ToArray();
//}
//int[] a = findCommons();
//for(int i=0; i<a.Length; i++)
//{
//    Console.WriteLine(a[i]);
//}

// Find the Sum by Pair 
//int[] arr1 = { 12, 23, 45, 12,25,2, 56, 89, 67, 54, 321 };
//List<int> list = new List<int>();
//int s = 25;
//for (int i = 0; i < arr1.Length; i++)
//{
//    for (int j = i + 1; j < arr1.Length; j++)
//    {
//        if (arr1[i]+ arr1[j]==s)
//        {
//            list.Add(arr1[i]);
//            list.Add(arr1[j]);
//        }
//    }
//}
//for(int i = 0;i < list.Count; i++)
//{
//    Console.WriteLine(list[i]);
//}


//  Triplets with given sum 
//int[] arr1 = { 12, 23, 45, 12,25,2, 56, 89, 67, 54, 321 };
//List<int> list = new List<int>();
//int s = 25;
//for (int i = 0; i < arr1.Length; i++)
//{
//    for (int j = i + 1; j < arr1.Length; j++)
//    {
//        if (arr1[i]+ arr1[j]==s)
//        {
//            list.Add(arr1[i]);
//            list.Add(arr1[j]);
//        }
//    }
//}
//for(int i = 0;i < list.Count; i++)
//{
//    Console.WriteLine(list[i]);
//}

// sort the 0011 form
int[] arr = { 1, 0, 0, 0, 1, 1, 1, 0 };
SortArray(arr);

Console.WriteLine("Sorted array: " + string.Join("", arr));
    

    static void SortArray(int[] arr)
{
    int countZeros = 0;
    int countOnes = 0;

    // Count the number of zeros and ones in the array
    foreach (int num in arr)
    {
        if (num == 0)
            countZeros++;
        else if (num == 1)
            countOnes++;
    }

    // Update the array with the sorted pattern
    for (int i = 0; i < arr.Length; i++)
    {
        if (countZeros > 0)
        {
            arr[i] = 0;
            countZeros--;
        }
        else if (countOnes > 0)
        {
            arr[i] = 1;
            countOnes--;
        }
    }
}