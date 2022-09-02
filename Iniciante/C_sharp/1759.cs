using System;

class URI
{

    static void Main(string[] args)
    {

        int N = 0;

        while (N <= 0 || N > 1000000)
        {
            N = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < (N - 1); i++)
        {
            Console.Write("Ho ");
        }

        Console.WriteLine("Ho!");
    }
}