namespace MethodHomeTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(25,120,45));
        }
        static int Sum(params int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 10 && arr[i]<=100)
                {
                    result += arr[i];
                }
            }
            return result;
        }
    }
}