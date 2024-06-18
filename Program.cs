namespace Assignment_7._2._1
//incorporate a shell sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = UserInputArray();

            Console.WriteLine("Original array: ");
            Console.WriteLine(string.Join(",", array));

            ShellSort(array);

            Console.WriteLine("Sorted array");
            Console.WriteLine(string.Join(",", array));



        }
        //Method to take user input
        static int[] UserInputArray()
        {
            Console.WriteLine("Enter The number of elements in the array");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            Console.WriteLine($"Enter {n} intergers:");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}:");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        // this sorts the array
        static void ShellSort(int[] array)
        {
            int n = array.Length;

            for (int pass = n / 2; pass > 0; pass /= 2)
            {
                for (int i = pass; i < n; i++)
                {
                    int temp = array[i];
                    int j;

                    for (j = i; j >= pass && array[j - pass] > temp; j -= pass)
                    {
                        array[j] = array[j - pass];
                    }

                    array[j] = temp;
                }
            }



        }
    }
}
