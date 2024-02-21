namespace MethodHomeTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Sum(25,120,45));
            //SeasonOfMonth(5);
            //SeasonOfMonth(11);
            Console.WriteLine(ProductOfDigits(231));

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

        static void SeasonOfMonth(int n)
        {
            switch (n)
            {
                case 1:
                    Console.WriteLine("qisdir");
                    break;
                case 2:
                    Console.WriteLine("qisdir");
                    break;
                case 3:
                    Console.WriteLine("yazdir");
                    break;
                case 4:
                    Console.WriteLine("yazdir");
                    break;
                case 5:
                    Console.WriteLine("yazdir");
                    break;
                case 6:
                    Console.WriteLine("yaydir");
                    break;
                case 7:
                    Console.WriteLine("yaydir");
                    break;
                case 8:
                    Console.WriteLine("yaydir");
                    break;
                case 9:
                    Console.WriteLine("payizdir");
                    break;
                case 10:
                    Console.WriteLine("payizdir");
                    break;
                case 11:
                    Console.WriteLine("payizdir");
                    break;
                case 12:
                    Console.WriteLine("qisdir");
                    break;
                default:
                    Console.WriteLine("Duzgun eded daxil edilmeyib");
                    break;
            }
        }

        static int ProductOfDigits(int n)
        {
            int result = 1;
            while (n > 0)
            {
                int a = n % 10;
                result *= a;
                n /= 10;
            }
            return result;
        }
    }
}