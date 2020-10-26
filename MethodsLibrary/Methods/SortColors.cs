namespace MethodsLibrary.Methods
{
    public class SortColors
    {
        public void SortColorsMethod(int[] nums)
        {
            int i0 = 0;
            int i2 = nums.Length-1;

            for (int i = 0; i < nums.Length; i++)
            {
                while (i<i2 && nums[i] == 2)
                {
                    int temp = nums[i];
                    nums[i] = nums[i2];
                    nums[i2] = temp;

                    i2--;
                }

                if (nums[i] == 0)
                {
                    int temp = nums[i0];
                    nums[i0] = nums[i];
                    nums[i] = temp;

                    i0++;
                }
            }
        }
    }
}
