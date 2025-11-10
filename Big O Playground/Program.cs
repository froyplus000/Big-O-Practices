#region Q1
void PrintPairs(int[] arr)
{
    /* 
        n: length of array
        T: O(n^2) -> consider a worst case scenario
    */
    int n = arr.Length;

    for (int i = 0; i < n; i++) // runs n times -> O(n)
    {
        for (int j = 0; j < n; j++) // for each i, runs n times -> O(n^2)
        {
            Console.WriteLine($"{arr[i]}, {arr[j]}"); // Constant time -> O(1)
        }
    }
    // Total operations n x n = n^2 
}
#endregion
#region Q2
void PrintUpperTriangle(int[] arr)
{
    /*
        n: length of array
        T: O(n^2)
    */
    int n = arr.Length;

    for (int i = 0; i < n; i++) // runs n times -> O(n)
    {
        for (int j = i; j < n; j++) // runs (n - i) times
        {
            Console.WriteLine($"{arr[i]}, {arr[j]}"); // constant time -> O(1)
        }
    }
}
#endregion