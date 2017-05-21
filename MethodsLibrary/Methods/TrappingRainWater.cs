using System;

namespace MethodsLibrary.Methods
{
    public class TrappingRainWater
    {
        public static int Trap(int[] height)
        {
            if (height == null || height.Length == 0)
            {
                return 0;
            }
            int max = 0;
            int maxLeft = 0;
            int maxRight = 0;
            int index1 = 0;
            int index2 = height.Length - 1;
            while(index1 < index2)
            {
                maxLeft = Math.Max(maxLeft, height[index1]);
                maxRight= Math.Max(maxRight, height[index2]);
                if(maxLeft < maxRight)
                {
                    max += maxLeft - height[index1++];
                }
                else
                {
                    max += maxRight - height[index2--];
                }
            }
            return max;
        }
    }
}