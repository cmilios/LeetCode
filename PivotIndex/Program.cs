namespace PivotIndex
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 7, 3, 6, 5, 6 };
            int result = PivotIndex(nums);
            Console.WriteLine(result);

        }

        public static int PivotIndex(int[] nums)
        {
            int sum = 0;
            int leftsum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (leftsum == sum - leftsum - nums[i])
                {
                    return i;
                }
                leftsum += nums[i];
            }
            return -1;
        }
    }
}