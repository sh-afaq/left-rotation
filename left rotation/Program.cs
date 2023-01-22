namespace left_rotation
{
    internal class Program
    {
        static int temp = 0;
        static void left(int[] arr,int number)
        {
            {
                for (int j = 0; j < number; j++)
                {
                    temp = arr[0];
                    for (int i = 0; i <= arr.Length - 1; i++)
                    {
                        if (i == arr.Length - 1)
                        {
                            arr[i] = temp;
                        }
                        else
                        {
                            arr[i] = arr[i + 1];
                        }


                    }
                }
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int number_of_iterations = 2;
            left(array,number_of_iterations);
           
        }
    }
}