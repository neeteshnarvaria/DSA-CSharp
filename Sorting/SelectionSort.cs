
namespace DSA.Sorting;

public class SelectionSort{
    public void Sort(int[] array){
        int n = array.Length;

        for(int i = 0; i< n -1; i++){
            int minIndex = i;

            //inner loop
            for(int j=i+1;j<n; j++){
                if(array[j] < array[minIndex]){
                    minIndex = j;
                }
            }

            //swap the found minimum element with first element of unsorted part
            if( minIndex != i){
                Swap(array, i, minIndex);
            }
        }
    }

    private void Swap(int[] array, int i, int minIndex)
    {
        int temp = array[i];
        array[i] = array[minIndex];
        array[minIndex] = temp;
    }

    public void Sort<T>(T[] array) where T :IComparable<T>
    {
        int n = array.Length;

        for(int i = 0; i < n-1; i++){
            int minIndex = i;
            for(int j=i+1; j< n; j++){
                if(array[j].CompareTo(array[minIndex]) < 0){
                    minIndex = j;
                }
            }

            if(minIndex != i ){
                Swap(array,i,minIndex);
            }
        }
    }

    private void Swap<T>(T[] array, int i, int minIndex)
    {
        T temp = array[i];
        array[i] = array[minIndex];
        array[minIndex] = temp;
    }
}