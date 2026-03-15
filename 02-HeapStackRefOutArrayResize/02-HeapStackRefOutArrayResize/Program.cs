class Program
{
    public static void Main()
    {
        int[] numbers = { 11, 27, 38 };

        int[] result = ArrayResize(numbers, 14, 25, 12, 17);

        for (int i = 0; i < result.Length; i++)
        {
            Console.Write($"{result[i]}, ");
        }
    }

    public static int[] ArrayResize(int[] numbers, params int[] arr)
    {
        int[] result = new int[numbers.Length + arr.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            result[i] = numbers[i];
        }

        for (int i = 0; i < arr.Length; i++)
        {
            result[numbers.Length + i] = arr[i];
        }
        return result;
    }
}