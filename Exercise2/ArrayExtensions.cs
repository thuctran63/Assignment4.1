using System.Collections;

namespace Exercise2
{
    public static class ArrayExtensions
    {
        public static int[] RemoveDuplicates(this int[] arr)
        {
            if (arr.Length == 0 || arr.Length == 1)
            {
                return arr;
            }

            ArrayList arrayList = new ArrayList();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!arrayList.Contains(arr[i]))
                {
                    arrayList.Add(arr[i]);
                }
            }

            return (int[])arrayList.ToArray(typeof(int));

        }


        public static T[] RemoveDuplicates<T>(this T[] arr)
        {
            if (arr.Length == 0 || arr.Length == 1)
            {
                return arr;
            }

            ArrayList arrayList = new ArrayList();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!arrayList.Contains(arr[i]))
                {
                    arrayList.Add(arr[i]);
                }
            }

            return (T[])arrayList.ToArray(typeof(T));
        }

    }
}
