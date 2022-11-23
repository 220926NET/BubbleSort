# Bubble Sort

Bubble sort is a sorting algorithm that compares two adjacent elements and swaps them if they are out of order. Bubble sort should only be used for simple cases or educational purposes. Also known as "Sinking Sort" as elements "sink down" or "bubble up" to the end of the array. Large elements quickly move to the end of the array, known as "rabbits", while smaller elements slowly move to front, known as "turtles". Other sorting alogrithms have been developed to improve the speed of turtles in Bubble Sort such as Cocktail sort and Comb sort.

## Time Complexity
    - Worst/Ave: O(n<sup>2</sup>)
    - Best Case: O(n)

## Space Complexity
    - O(1) or O(2)

## Examples

### Basic

```C#
void BubbleSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = 0; j < arr.Length - i - 1; j++)
        {
            if (arr[j] > arr[j+1])
            {
                int temp = arr[j];
                arr[j] = arr[j+1];
                arr[j+1] = temp;
            }
        }
    }
}
```

### Optimized

```C#
void BubbleSortOptimized(int[] arr)
{
    bool swapped;

    for (int i = 0; i < arr.Length - 1; i++)
    {
        swapped = false;
        for (int j = 0; j < arr.Length - i - 1; j++)
        {
            if (arr[j] > arr[j+1])
            {
                int temp = arr[j];
                arr[j] = arr[j+1];
                arr[j+1] = temp;
                swapped = true;
            }
        }

        if(!swapped) break;
    }
}
```

### Recursion

```C#
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
```

## Links
- Visualize: https://www.hackerearth.com/practice/algorithms/sorting/bubble-sort/visualize/
- Codewars - Bubble Sort Once Problem: https://www.codewars.com/kata/56b97b776ffcea598a0006f2
- LeetCode - Merge Sorted Array: https://leetcode.com/problems/merge-sorted-array/
