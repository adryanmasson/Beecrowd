using System; 

class URI {

    static void Main(string[] args) { 

        int N = Convert.ToInt32(Console.ReadLine());
        
        
        int m100 = N/100;
        int m50 = N%100/50;
        int m20 = N%100%50/20;
        int m10 = N%100%50%20/10;
        int m5 = N%100%50%20%10/5;
        int m2 = N%100%50%20%10%5/2;
        int m1 = N%100%50%20%10%5%2;

        Console.WriteLine(N);
        Console.WriteLine("{0} nota(s) de R$ 100,00", m100);
        Console.WriteLine("{0} nota(s) de R$ 50,00", m50);
        Console.WriteLine("{0} nota(s) de R$ 20,00", m20);
        Console.WriteLine("{0} nota(s) de R$ 10,00", m10);
        Console.WriteLine("{0} nota(s) de R$ 5,00", m5);
        Console.WriteLine("{0} nota(s) de R$ 2,00", m2);
        Console.WriteLine("{0} nota(s) de R$ 1,00", m1);

    }

}