using System;
using System.Collections.Generic;

namespace RegexTestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 10, 7, 1, 4, 8, 13, 51, 22, 36, 9, 6, 17, 88, 43, 28 };
            Output(array);

            Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();
            stack.Push(new Tuple<int, int>(0, array.Length - 1));
            while (stack.Count > 0)
            {
                var item = stack.Pop();
                var i = item.Item1;
                var j = item.Item2;
                var pivot = i;
                var floor = i;
                var ceil = j;
                while (i < j)
                {
                    if (pivot < j)
                    {
                        if (array[pivot] > array[j])
                        {
                            Swap(array, i, j);
                            pivot = j;
                            i++;
                        }
                        else
                        {
                            j--;
                        }
                    }

                    if (pivot > i)
                    {
                        if (array[pivot] < array[i])
                        {
                            Swap(array, i, j);
                            pivot = i;
                            j--;
                        }
                        else
                        {
                            i++;
                        }
                    }
                }

                if (floor < pivot - 1)
                {
                    stack.Push(new Tuple<int, int>(floor, pivot - 1));
                }

                if (pivot + 1 < ceil)
                {
                    stack.Push(new Tuple<int, int>(pivot + 1, ceil));
                }
            }
            Output(array);
            Console.Read();
        }

        static void Output(Array array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Swap(int[] array, int index1, int index2)
        {
            var temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}
