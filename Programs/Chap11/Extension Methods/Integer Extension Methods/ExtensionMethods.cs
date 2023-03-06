namespace ExtensionMethods
{
    public static class Extensions
    {
        public static bool IsEven(this int i)
        {
            return (i % 2) == 0;
        }

        public static bool IsMultipleOf(this int a, int b)
        {
            return (a % b) == 0;
        }

        public static bool IsWholeNumber(this double d)
        {
            return (d - (int)d) == 0;
        }
    }
}