namespace SortingApp
{
    public static class Tools
    {
        public static void SwapValues(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
