using System; 

class URI {

    static void Main(string[] args) { 

        string [] peca1 = Console.ReadLine().Split(' ');
        string [] peca2 = Console.ReadLine().Split(' ');
        
        double valor1 = Convert.ToInt32(peca1[1]) * Convert.ToDouble(peca1[2]);
        double valor2 = Convert.ToInt32(peca2[1]) * Convert.ToDouble(peca2[2]);
        double valortotal = valor1 + valor2;
        
        Console.WriteLine("VALOR A PAGAR: R$ " + valortotal.ToString("0.00"));

    }

}