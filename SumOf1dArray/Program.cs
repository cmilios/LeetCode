namespace RunningSumOf1dArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4 };
            int[] result = RunningSum(nums);
        }

        public static int[] RunningSum(int[] nums)
        {

            int[] result = new int[nums.Length];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                result[i] = sum;
            }
            return result;
        }
    }
}