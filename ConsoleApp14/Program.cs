namespace bmm_a_kmm
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("enter first number :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("bmm is   " + bmm(num1, num2) + "  kmm is " + kmm(num1, num2));

        }
        private static int bmm(int a, int b)
        {
            int temp = 0;
            if (b > a)
            {
                temp = a;
                a = b;
                b = temp;
            }
            while (b != 0)
            {
                int d = a % b;
                if (d == 0)
                {
                    Console.WriteLine("bmm is 0"); break;
                }
                else
                {
                    a = b;
                    b = d;
                }
            }

            return b;
        }

        private static int kmm(int a, int b)
        {
            return ((a * b) / bmm(a, b));
        }

    }

}


