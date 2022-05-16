using System;

namespace Lesson06.Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int[] array1 = new[] {1 ,2 ,3 ,4 ,5};
            int[] array2 = {1 ,2 ,3 ,4 ,5};

            var range = array[2..4];

            array1[0] = 1;

            var index = new Index(0);
            array1[index] = 1;

            array1[1] = 2;
            array1[2] = 3;

            Print(array);

            int i = 0;
            for (i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            Print(array);

            for(i = 0; i < array.Length; i++)
            {
                array[i] = i * 2;
            }
            Print(array);

            var randomArray = GetArray(10);
            Print(randomArray);

            MultipleBy(randomArray, 2);
            Print(randomArray);

            var copiedArray = Copy(randomArray);
            MultipleBy(copiedArray, 10);
            Print(randomArray);
            Print(copiedArray);

            /*Sort(randomArray);
            Print(randomArray);*/
            Console.WriteLine("Homework: ");
            int[] arraySelection = new[] {5, 1, 3, -2, -1, 0, 6, 12, 10, 8};
            int[] arrayBubble = new[] { 10, 2, 8, 1, 6, 3, 5 };
            int[] arrayInsertion = new[] { 25, 5, 3, 10, 15, 7, 11, 1 };
            int[] sortAlgorithmTypeSelection = new[] { 100, 50, 45, 30, 20, 90, 35, 25, 10, 75, 40 };
            int[] sortAlgorithmTypeInsertion = new[] { 100, 50, 45, 30, 20, 90, 35, 25, 10, 75, 40 };
            int[] sortAlgorithmTypeBubble = new[] { 100, 50, 45, 30, 20, 90, 35, 25, 10, 75, 40 };
            int[] arraySelectionOrderBy = new[] { 5, 1, 3, -2, -1, 0, 6, 12, 10, 8 };
            int[] arrayBubbleOrderBy = new[] { 10, 2, 8, 1, 6, 3, 5 };
            int[] arrayInsertionOrderBy = new[] { 25, 5, 3, 10, 15, 7, 11, 1 };
            Console.WriteLine($"{Environment.NewLine}Selection unsorted");
            Print(arraySelection);
            SortSelectionAsc(arraySelection);
            Console.WriteLine($"Selection sorted");
            Print(arraySelection);

            Console.WriteLine($"{Environment.NewLine}Bubble unsorted: ");
            Print(arrayBubble);
            SortBubbleAsc(arrayBubble);
            Console.WriteLine($"Bubble sorted: ");
            Print(arrayBubble);

            Console.WriteLine($"{Environment.NewLine}Insertion unsorted: ");
            Print(arrayInsertion);
            SortInsertionAsc(arrayInsertion);
            Console.WriteLine($"Insertion sorted: ");
            Print(arrayInsertion);

            SortAlgorithmType Selection = SortAlgorithmType.SortSelection;
            SortAlgorithmType Insertion = SortAlgorithmType.SortInsertion;
            SortAlgorithmType Bubble = SortAlgorithmType.SortBubble;
            Console.WriteLine($"{Environment.NewLine}SortAlgorithmType unsorted: ");
            Console.WriteLine($"{Environment.NewLine}SortAlgorithmType sorted by Selection: ");
            Print(sortAlgorithmTypeSelection);
            Sort(sortAlgorithmTypeSelection, Selection);
            Print(sortAlgorithmTypeSelection);

            Console.WriteLine($"{Environment.NewLine}SortAlgorithmType sorted by Insertion: ");
            Print(sortAlgorithmTypeInsertion);
            Sort(sortAlgorithmTypeInsertion, Insertion);
            Print(sortAlgorithmTypeInsertion);

            Console.WriteLine($"{Environment.NewLine}SortAlgorithmType sorted by Bubble: ");
            Print(sortAlgorithmTypeBubble);
            Sort(sortAlgorithmTypeBubble, Bubble);
            Print(sortAlgorithmTypeBubble);

            OrderBy Asc = OrderBy.Asc;
            OrderBy Desc = OrderBy.Desc;

            Console.WriteLine($"{Environment.NewLine}OrderBy unsorted: ");
            Console.WriteLine($"{Environment.NewLine}OrderBy sorted by Selection: ");
            Print(arraySelectionOrderBy);
            Sort(arraySelection, arraySelectionOrderBy, Asc, Desc);
            Print(arraySelection);
            Print(arraySelectionOrderBy);

            Console.WriteLine($"{Environment.NewLine}OrderBy sorted by Insertion: ");
            Print(arrayInsertionOrderBy);
            Sort(arrayInsertion, arrayInsertionOrderBy, Asc, Desc);
            Print(arrayInsertion);
            Print(arrayInsertionOrderBy);

            Console.WriteLine($"{Environment.NewLine}OrderBy sorted by Bubble: ");
            Print(arrayBubbleOrderBy);
            Sort(arrayBubble, arrayBubbleOrderBy, Asc, Desc);
            Print(arrayBubble);
            Print(arrayBubbleOrderBy);

        }
        //Selection asc
        private static void SortSelectionAsc(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }

        }

        //Selection desc
        private static void SortSelectionDesc(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }

        }

        //Insertion asc
        private static void SortInsertionAsc(int [] array)
        {
            int n = array.Length;
            for(int i = 1; i < n; ++i)
            {
                int key = array[i];
                int j = i - 1;

                while(j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
        }

        //Insertion desc
        private static void SortInsertionDesc(int[] array)
        {
            int n = array.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] < key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
        }

        //Bubble asc
        private static void SortBubbleAsc(int[] array)
        {
            int n = array.Length;
            for(int i = 0; i < n-1; i++)
            {
                for(int j = 0; j < n-i-1; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        //Bubble desc
        private static void SortBubbleDesc(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public enum SortAlgorithmType
        {
            SortSelection,
            SortInsertion,
            SortBubble
        }

        private static void Sort(int[] array, SortAlgorithmType SAT)
        {
            SortSelectionAsc(array);
            SortInsertionAsc(array);
            SortBubbleAsc(array);
        }

        private static void Sort(int[] arrayAsc, int[] arrayDesc, OrderBy Asc, OrderBy Desc)
        {
            SortSelectionAsc(arrayAsc);
            SortInsertionAsc(arrayAsc);
            SortBubbleAsc(arrayAsc);

            SortSelectionDesc(arrayDesc);
            SortInsertionDesc(arrayDesc);
            SortBubbleDesc(arrayDesc);

        }

        public enum OrderBy
        {
            Asc,
            Desc
        }
        //Selection
        // 4, 2, 8, 3, 7, 1 
        // 1, 4, 2, 8, 3, 7
        // 1, 2, 4, 8, 3, 7
        // 1, 2, 4, 3, 8, 7
        // 1, 2, 4, 3, 7, 8
        /*private static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }

        }*/
        // 4, 2, 8, 3, 7, 1
        // 4, 2, 8, 3, 7, 1
        // 2, 4, 8, 3, 7, 1
        // 2, 3, 4, 8, 7, 1
        // 2, 3, 4, 7, 8, 1
        // 1, 2, 3, 4, 7, 8

        private static int[] Copy(int[] array)
        {
            int[] copyArray = new int [array.Length];
            for(int i = 0;i < array.Length; i++)
            {
                copyArray[i] = array[i];
            }
            return copyArray;
        }

        private static void MultipleBy(int[] array, int multiplier)
        {
            for(int i = 0; i < array.Length; i++)
            {
                array[i] *= multiplier;
            }
        }

        private static int[] GetArray(int length)
        {
            int maxValue = 100;
            Random random = new Random();
            var array = new int[length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-maxValue, maxValue);
            }
            return array;
        }

        private static void Print(int[] array)
        {
            foreach (var items in array)
            {
                Console.Write($"{items} ");
            }
            Console.Write(Environment.NewLine);
        }
    }
}
