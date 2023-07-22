
using System.Security.Cryptography;

Console.WriteLine("Binary search  Advance Problems solving sections");
bool isPossible(int[]Length, students, mid)
{

}
int BookAlocation(int[] arr, int students )
{
    int start = 0;
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }int end = sum;
    int ans = -1;
    while (start<=end)
    {
        int mid = start + (end - start) / 2;
        if (isPossible(arr, arr.Length, students, mid){
            ans = mid;
            end = mid - 1;
        }
        else
        {
            students = mid + 1;
        }
        return ans;
    }


}





