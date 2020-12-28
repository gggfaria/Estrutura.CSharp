using System.Collections.Generic;

namespace Estrutura.CSharp.Sort
{
    public static class BubbleSort
    {
        public static int[] Sort(this int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
                }
            }

            return array;
        }
    }
}
