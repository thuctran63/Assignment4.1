namespace Exercise3
{
    public static class ArrayyExtensions
    {
        public static int ListIndexOf<T>(this T[] arr, T value)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] != null)
                {
                    if (arr[i].Equals(value))
                    {
                        return i;
                    }
                }
                
            }

            return -1;
        }
    }
}
