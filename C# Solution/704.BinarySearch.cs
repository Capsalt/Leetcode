public class Solution {
    public int Search(int[] nums, int target) {
         for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]==target)
                {
                    return i;
                }
             
            }
        return -1;
    }
}


//Second Solution

public class Solution {
    public int Search(int[] nums, int target) {
         
            int end = nums.Length - 1;
            int begin = 0;
            int ort = (end + begin) / 2;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[ort] == target) return ort;

                if (nums[ort]>target)
                {
                    end = ort - 1;
                    
                }
                if (nums[ort]<target)
                {
                    begin = ort + 1;
                    
                }
                ort = (end + begin) / 2;
            }
            return -1;
    }
}
