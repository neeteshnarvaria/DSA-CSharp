using DSA.Arrays;
using DSA.General;
using DSA.LinkedList;
using DSA.Sorting;

namespace DSA;

class Program
{
    public static void Main(string[] args)
    {
        /*OrderQueue queue = new OrderQueue();

        queue.Enqueue("Pizza");
        queue.Enqueue("Burger");
        queue.Enqueue("Sandwich");

        Console.WriteLine($"next order to process: {queue.Peek()}");

        queue.Dequeue();
        queue.Dequeue();

        Console.WriteLine($"next order to process: {queue.Peek()}");

        queue.Dequeue();
        queue.Dequeue();*/
        //FindUsernames.Run();

        /*int[] numbers = { 64, 25, 12, 22, 11 };
        string[] stringArray = { "banana", "apple", "date", "cherry"};
        Console.WriteLine("Original array:");
        Console.WriteLine(string.Join(", ", numbers));
        SelectionSort selectionSort = new SelectionSort();
        selectionSort.Sort(numbers);

        Console.WriteLine("Sorted array:");
        Console.WriteLine(string.Join(", ", numbers));


        Console.WriteLine("Original String array:");
        Console.WriteLine(string.Join(", ", stringArray));
        
        
        selectionSort.Sort(stringArray);

        Console.WriteLine("Sorted String array:");
        Console.WriteLine(string.Join(", ", stringArray));*/
        
        Console.WriteLine("Sum is: "+Utilities.Sum([1,2,4,5]));

        Console.WriteLine("Count is: "+Utilities.CountItems([1,2,4,5],0));

        Console.WriteLine("Max is: "+Utilities.FindMax([1,2,4,5], 0));

        Console.WriteLine("Item exist at index: "+Utilities.RecursiveBinarySearch([1,2,4,5], 0));

        Console.WriteLine("Item exist at index: "+Utilities.RecursiveBinarySearch([1,2,4,5], 4));
    }
}
