namespace FindMaxNumber
{
    public class FindMaximumNumber
    {
        public int FindMaxInteger(int a, int b, int c)
        {
            if (a > b && a > c)
                return a;
            else if (b > a && b > a)
                return b;
            else
                return c;
        }

    }
}