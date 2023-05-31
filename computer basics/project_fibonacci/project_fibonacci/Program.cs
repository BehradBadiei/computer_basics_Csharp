namespace project_fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write the n sequence of the fibonacci sequence you want: ");
            int n = int.Parse(Console.ReadLine());  //گرفتن تعداد دنباله های خواسته شده برای نوشتن دنباله فیبوناچی

            Console.WriteLine("the "+n+"th sequence of the fibonacci sequence is: "); //تایتل خروجی آخر
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }

            Console.ReadLine();
        }

        static int Fibonacci(int n)  //تابع فیبوناجی
        {
            if (n <= 1) 
                return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}