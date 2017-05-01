using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsLibrary.Methods
{
    public class MoveZeroes
    {
        public static void moveZeroes(int[] nums)
        {
            if(nums == null || nums.Length == 0)
            {
                return;
            }
            int updater = 0;
            int scanner = 0;
            while (scanner < nums.Length)
            {
                if (nums[scanner] != 0)
                {
                    nums[updater] = nums[scanner];
                    updater++;
                    scanner++;
                }
                else
                {
                    scanner++;
                }
            }

            while (updater < nums.Length)
            {
                nums[updater++] = 0;
            }

        }
    }
}
