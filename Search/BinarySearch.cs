namespace DSA.Search;

public class BinarySearch{

    /// <summary>
    /// 
    /// </summary>
    /// <param name="list">This should be sorted list</param>
    /// <param name="item">item to be found</param>
    /// <returns></returns>
    public int Search(int[] list, int item){

        int low = 0;
        int high = list.Length -1;

        while(low <= high){
            int mid = (low +high)/2;
            var guess = list[mid];
            if(guess == item){
                return guess;
            }
            if(guess > item){
                high = mid -1;
            }else{
                low = mid +1;
            }
        }

        return -1;
    }

    public int Search(string[] list, string name){
        int low = 0;
        int high = list.Length -1;

        while(low <= high){
            int mid = (low + high)/2;
            string guessName = list[mid];
            if(guessName.Equals(name,StringComparison.OrdinalIgnoreCase)){
                return mid;
            }
            if(string.Compare(guessName, name,StringComparison.OrdinalIgnoreCase) < 0){
                low = mid+1;
            }else{
                high = mid-1;
            }
        }

        return -1;
    }


    public int Search(List<Tuple<string,string>> list, string targetPhoneNumber){
        for(int i = 0; i< list.Count -1 ; i++){
            var entry = list[i];
            if(entry.Item2 == targetPhoneNumber){
                return i;
            }
        }
        return -1;
    }
}