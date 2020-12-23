namespace Estrutura.CSharp.Search
{
    public static class BinarySearch
    {
        public static bool HasNumber(this int[] array, int number)
        {
            bool found = false;
            int start = 0;
            int end = array.Length - 1;
            int middle;
            while (start <= end)
            {
                middle = (int)((start + end) / 2);
                if (array[middle] == number)
                {
                    found = true;
                    break;
                }
                else if (array[middle] < number)
                {
                    start = middle + 1;
                }
                else
                {
                    end = middle - 1;
                }

            }

            return found;

        }
    }
}
