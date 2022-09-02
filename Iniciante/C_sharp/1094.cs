using System; 

class URI {

    static void Main(string[] args) { 

        int N = Convert.ToInt32(Console.ReadLine());
        int coelhos = 0;
        int sapos = 0;
        int ratos = 0;
        
        
        
        for(int i = 0; i < N; i++){
            string [] qnttipo = Console.ReadLine().Split(' ');
            if(qnttipo[1] == "C"){
                coelhos += Convert.ToInt32(qnttipo[0]);
            }else if(qnttipo[1] == "R"){
                ratos += Convert.ToInt32(qnttipo[0]);
            }else{
                sapos += Convert.ToInt32(qnttipo[0]);
            }
            
        }
    
        double total = coelhos + sapos + ratos;
        double percoelho = (coelhos/total)*100;
        double perrato = (ratos/total)*100;
        double persapo = (sapos/total)*100;
        
        
        
        
        
        Console.WriteLine("Total: " + total + " cobaias");
        Console.WriteLine("Total de coelhos: " + coelhos);
        Console.WriteLine("Total de ratos: " + ratos);
        Console.WriteLine("Total de sapos: " + sapos);
        Console.WriteLine("Percentual de coelhos: " + percoelho.ToString("0.00") + " %");
        Console.WriteLine("Percentual de ratos: " + perrato.ToString("0.00") + " %");
        Console.WriteLine("Percentual de sapos: " + persapo.ToString("0.00") + " %");
    }
        
}