using System; 

class URI {

    static void Main(string[] args) { 

        string [] NString = Console.ReadLine().Split('.');
        
        int N = Convert.ToInt32(NString[0]);
        
        int NCents = Convert.ToInt32(NString[1]);
        
        
        
        int m100 = N/100;
        int m50 = N%100/50;
        int m20 = N%100%50/20;
        int m10 = N%100%50%20/10;
        int m5 = N%100%50%20%10/5;
        int m2 = N%100%50%20%10%5/2;
        
        NCents += (N%100%50%20%10%5%2) * 100;
        
        int cents100 = NCents/100;
        int cents50 = NCents%100/50;
        int cents25 = NCents%100%50/25;
        int cents10 = NCents%100%50%25/10;
        int cents5 = NCents%100%50%25%10/5;
        int cents1 = NCents%100%50%25%10%5/1;
        
        Console.WriteLine("NOTAS:");
        Console.WriteLine("{0} nota(s) de R$ 100.00", m100);
        Console.WriteLine("{0} nota(s) de R$ 50.00", m50);
        Console.WriteLine("{0} nota(s) de R$ 20.00", m20);
        Console.WriteLine("{0} nota(s) de R$ 10.00", m10);
        Console.WriteLine("{0} nota(s) de R$ 5.00", m5);
        Console.WriteLine("{0} nota(s) de R$ 2.00", m2);
        
        Console.WriteLine("MOEDAS:");
        Console.WriteLine("{0} moeda(s) de R$ 1.00", cents100);
        Console.WriteLine("{0} moeda(s) de R$ 0.50", cents50);
        Console.WriteLine("{0} moeda(s) de R$ 0.25", cents25);
        Console.WriteLine("{0} moeda(s) de R$ 0.10", cents10);
        Console.WriteLine("{0} moeda(s) de R$ 0.05", cents5);
        Console.WriteLine("{0} moeda(s) de R$ 0.01", cents1);

    }

}