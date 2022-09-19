using System; 

class URI {

    static void Main(string[] args) { 

        int N = Convert.ToInt32(Console.ReadLine());
        int ano = N/365;
        int mes = (N%365)/30;
        int dia = (N%365)%30;
        
        Console.WriteLine(ano + " ano(s)");
        Console.WriteLine(mes + " mes(es)");
        Console.WriteLine(dia + " dia(s)");

    }

}