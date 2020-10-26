namespace MethodsLibrary.Methods
{
    public class NumberOfStepsToZero
    {
        public static int NumberOfSteps(int num)
        {
            int steps = 0;

            while (num > 0)
            {
                if (num % 2 != 0)
                {
                    num--;
                }
                else
                {
                    num = num >> 1;
                }
                steps++;
            }

            return steps;
        }
    }
}
