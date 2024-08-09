namespace Exercise4
{
    public static class ArrayExtensions
    {
        public static int ElementOfOrder2(this int[] array)
        {
            if (array.Length == 0)
            {
                return -1;
            }

            int max1 = 0;
            int max2 = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (max1 < array[i])
                {
                    max2 = max1;
                    max1 = array[i];
                }
            }

            return max2;
        }

        static T[] RemoveAt<T>(T[] source, int index)
        {
            if (index < 0 || index >= source.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(T), "Chỉ mục nằm ngoài phạm vi của mảng.");
            }

            T[] dest = new T[source.Length - 1];
            if (index > 0)
            {
                Array.Copy(source, 0, dest, 0, index);
            }
            if (index < source.Length - 1)
            {
                Array.Copy(source, index + 1, dest, index, source.Length - index - 1);
            }

            return dest;
        }

        public static T ElementOfOrder<T>(this T[] array, int orderLargest) {
            
            if (orderLargest > array.Length)
            {
                throw new System.ArgumentException("Order is greater than the length of the array");
            }
            array = array.Distinct().ToArray();

            for(int i = 1; i < orderLargest; i++)
            {
                array = RemoveAt(array, System.Array.IndexOf(array, array.Max()));
            }

            return array.Max();
        }
    }
}
