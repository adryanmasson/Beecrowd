using System;

class URI
{

    static void Main(string[] args)
    {

        double pi = 3.14159;
        double R = Convert.ToDouble(Console.ReadLine());
        double A = pi * (R * R);

        Console.WriteLine("A=" + A.ToString("0.0000"));
    }

}