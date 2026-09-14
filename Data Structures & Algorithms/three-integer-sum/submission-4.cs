public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
var res = new HashSet<List<int>>();
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] > 0)
    {
        break;
    }
    if (i > 0 && nums[i - 1] == nums[i])
    {
        continue;
    }
    var l = i + 1;
    var r = nums.Length - 1;
    while (l < r)
    {
        var sum = nums[i] + nums[l] + nums[r];

        if (sum > 0)
        {
            r--;
        }
        else if (sum < 0)
        {
            l++;
        }
        else
        {
            var li = new List<int> { nums[i], nums[l], nums[r] };
            if (!res.Any(x => x.SequenceEqual(li)))
            {
                res.Add(li);
            }

            while (l < r && nums[l] == nums[l - 1])
            {
                l++;
            }
            r--;
        }
    }
}

return res.ToList();
    }
}
