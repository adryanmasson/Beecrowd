using System; 

class URI {

    static void Main(string[] args) { 

        string[] NS = Console.ReadLine().Split();
        int N = Convert.ToInt32(NS[0]);
        int valorAtual = Convert.ToInt32(NS[1]);
        int menorValor = valorAtual;
        
        for(int i = 0; i < N; i++){
            int mov = Convert.ToInt32(Console.ReadLine());
            
            valorAtual += mov;
            
            if(valorAtual < menorValor){
                menorValor = valorAtual;
            }
        }
        
        Console.WriteLine(menorValor);

    }

}
