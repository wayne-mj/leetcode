// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Solution s = new();
int[] nums1 = {1,2};
int[] nums2 = {3,4};

Console.WriteLine(s.FindMedianSortedArrays(nums1,nums2));

public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] combined = nums1.Concat(nums2).ToArray();
        double val = 0.0;

        Array.Sort(combined);
        int n = combined.Length;
        if (n % 2 != 0)
        {
            val = combined[(int)Math.Floor(n / 2.0)];
        }
        else if (n % 2 == 0)
        {
            int mid = n / 2;
            val = (combined[mid] + combined[mid-1]) /2.0;
        }

        return val;
    }
}


