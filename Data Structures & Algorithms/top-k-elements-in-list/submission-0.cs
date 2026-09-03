public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var count = new Dictionary<int, int>();
        foreach(var num in nums){
            if(count.ContainsKey(num)){
                count[num]++;
            }
            else{
                count[num] = 1;
            }
        }

        var arr = count.Select(c => new int[]{c.Value, c.Key}).ToList();
        arr.Sort((a,b) => b[0].CompareTo(a[0]));
        var res = new int[k];
        for(int i = 0; i <k; i++){
            res[i] = arr[i][1];
        }

        return res;
    }
}
