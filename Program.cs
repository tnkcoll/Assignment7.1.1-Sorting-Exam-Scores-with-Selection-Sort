namespace Assignment7._1._1_Sorting_Exam_Scores_with_Selection_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = { 10, 55, 42, 77, 84, 63, 97, 28 };

            PrintArray(scores);

            scores = SortAscendingArray(scores);

            PrintArray(scores);

        }

        static int[] SortAscendingArray(int[] ints)
        {
            for (int i = 0; i < ints.Length - 1; i++) 
            {
                //This is a temporary variable to hold the index of the smallest number in the array.
                //It is initialized to the first unsorted element.
                int smallestNumberIndex = i;
                
                //This loop interates through the entire unsorted portion of the array.
                for (int j = i + 1; j < ints.Length; j++)
                {
                    if (ints[j] < ints[smallestNumberIndex])
                        
                        //Store the index number j in the smallestNumberIndex variable.
                        smallestNumberIndex = j;
                }

                //Switch the values in index ints[i] and index ints[smallestNumberIndex].
                int temp = ints[i];
                ints[i] = ints[smallestNumberIndex];
                ints[smallestNumberIndex] = temp;
            }

            return ints;
        }

        static void PrintArray(int[] ints)
        {
            foreach (int i in ints)
            {
                //Print the array passed into this method.
                Console.Write($"{i} ");
            }
            
            Console.WriteLine();
        }
    }
}
