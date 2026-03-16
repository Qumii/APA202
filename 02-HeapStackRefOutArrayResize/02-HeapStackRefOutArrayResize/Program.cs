class Program
{
    public static void Main()
    {
        int[] numbers = { 11, 27, 38 };

        ArrayResize(numbers, 14, 25, 12, 17,7);
    }

    public static void ArrayResize (int[] numbers, params int[] arr)
    {
        int[] newArr = new int[numbers.Length + arr.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            newArr[i] = numbers[i];
        }

        for (int i = 0; i < arr.Length; i++)
        {
            newArr[newArr.Length - arr.Length] = arr[i];
        }

        newArr[newArr.Length-arr.Length]=arr[0];
        newArr[newArr.Length-arr.Length+1]=arr[1];
        newArr[newArr.Length-arr.Length+2]=arr[2];
        newArr[newArr.Length-arr.Length+3]=arr[3];
        newArr[newArr.Length-arr.Length+4]=arr[4];
  

        numbers = newArr;

        for (int i = 0; i < newArr.Length; i++)
        {
            Console.Write($"{newArr[i]}, ");
        }
        
    }
}