
namespace MethodsLibrary
{
    using System;

    public class VideoStitchingClass
    {
        public int VideoStitching(int[][] clips, int T)
        {
            int[] dp = new int[T + 1];
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = int.MaxValue - 1;
            }
            dp[0] = 0;

            for (int i = 1; i <= T; i++)
            {
                for (int j = 0; j < clips.Length; j++)
                {
                    if (clips[j][0] < i && clips[j][1] >= i)
                    {
                        dp[i] = Math.Min(dp[i], dp[clips[j][0]] + 1);
                    }
                }
            }
            return dp[T] == int.MaxValue - 1 ? -1 : dp[T];
        }
    }
}
