using DSA.Search;

namespace DSA.General;

public class Utilities{
    public static int Sum(int[] numbers){
        int total =0 ;
        foreach(int number in numbers){
            total+=number;
        }
        return total;
    }

    public static int CountItems<T>(List<T> items, int index){
        if(index >= items.Count){
            return 0;
        }else{
            return 1 + CountItems(items, index+1);
        }
    }

    public static int FindMax(List<int> items, int index){
        if(index == items.Count-1){
            return items[index];
        }
        int maxOfRest = FindMax(items, index+1);
        return Math.Max(items[index], maxOfRest);
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="arr"> this should be sorted array</param>
    /// <param name="target">item to find
    /// </param>
    /// <returns></returns>
    public static int RecursiveBinarySearch(int[] arr, int target){
        int left = 0;
        int right = arr.Length -1;

        return BinarySearch(arr, target, left, right);
    }

    private static int BinarySearch(int[] arr, int target, int left, int right)
    {
        if(left > right){
            return -1;
        }

        int mid = (left+right)/2;

        if(arr[mid] == target){
            return mid;
        }
        else if(arr[mid] > target){
            return BinarySearch(arr, target,left, mid-1);
        }
        else{
            return BinarySearch(arr, target, mid+1, right);
        }
    }
}