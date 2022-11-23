
int[] BubbleSort(int[] testArr, out int comparisons, out int swaps)
{
    int[] arr = new int[10];
    Array.Copy(testArr, arr, 10);
    comparisons = 0;
    swaps = 0;

    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = 0; j < arr.Length - i - 1; j++)
        {
            comparisons++;
            if (arr[j] > arr[j+1])
            {
                swaps++;
                int temp = arr[j];
                arr[j] = arr[j+1];
                arr[j+1] = temp;
            }
        }
    }

    return arr;
}

int[] BubbleSortOptimized(int[] testArr, out int comparisons, out int swaps)
{
    int[] arr = new int[10];
    Array.Copy(testArr, arr, 10);
    bool swapped;
    comparisons = 0;
    swaps = 0;

    for (int i = 0; i < arr.Length - 1; i++)
    {
        swapped = false;
        for (int j = 0; j < arr.Length - i - 1; j++)
        {
            comparisons++;
            if (arr[j] > arr[j+1])
            {
                swaps++;
                int temp = arr[j];
                arr[j] = arr[j+1];
                arr[j+1] = temp;
                swapped = true;
            }
        }

        if(!swapped) break;
    }

    return arr;
}

void BubbleSortRecursion(int[] arr, int n)
{
    if (n == 0 || n == 1) return;

    for (int i = 0; i < n - 1; i++)
    {
        if (arr[i] > arr[i + 1])
        {
            int temp = arr[i];
            arr[i] = arr[i + 1];
            arr[i + 1] = temp;
        }
    }

    BubbleSortRecursion(arr, n - 1);

}



int[] best = {1,2,3,4,5,6,7,8,9,10};
int[] worst = {10,9,8,7,6,5,4,3,2,1};
int[] ave = {3,6,9,2,4,10,1,8,7,5};
int[] sorted = new int[10];

int comparisons;
int swaps;

Console.WriteLine();
Console.WriteLine("Basic Implementation: ");
Console.WriteLine();
Console.WriteLine("Ave sort");
PrintArray(ave);
sorted = BubbleSort(ave, out comparisons, out swaps);
PrintResults(sorted, comparisons, swaps);
Console.WriteLine();

Console.WriteLine("Worst sort");
PrintArray(worst);
sorted = BubbleSort(worst, out comparisons, out swaps);
PrintResults(sorted, comparisons, swaps);
Console.WriteLine();

Console.WriteLine("Best sort");
PrintArray(best);
sorted = BubbleSort(best, out comparisons, out swaps);
PrintResults(sorted, comparisons, swaps);
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Optimized Implementation: ");
Console.WriteLine();
Console.WriteLine("Ave sort");
PrintArray(ave);
sorted = BubbleSortOptimized(ave, out comparisons, out swaps);
PrintResults(sorted, comparisons, swaps);
Console.WriteLine();

Console.WriteLine("Worst sort");
PrintArray(worst);
sorted = BubbleSortOptimized(worst, out comparisons, out swaps);
PrintResults(sorted, comparisons, swaps);
Console.WriteLine();

Console.WriteLine("Best sort");
PrintArray(best);
sorted = BubbleSortOptimized(best, out comparisons, out swaps);
PrintResults(sorted, comparisons, swaps);
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Recursion: ");
BubbleSortRecursion(ave, ave.Length);
PrintArray(ave);
BubbleSortRecursion(worst, worst.Length);
PrintArray(worst);
BubbleSortRecursion(best, best.Length);
PrintArray(best);

void PrintArray(int[] arr)
{
    foreach(int num in arr)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}

void PrintResults(int[] arr, int comparisons, int swaps)
{
    PrintArray(arr);
    Console.WriteLine();
    Console.WriteLine("# of Comparisons: " + comparisons);
    Console.WriteLine("# of Swaps: " + swaps);
}
