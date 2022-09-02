using System; 

class URI {

    static void Main(string[] args) { 

        int N = Convert.ToInt32(Console.ReadLine());
        int fatorial = N;
        
        for(int i = 1; i < N; i++){
            fatorial *= (N-i);
        }
        
        Console.WriteLine(fatorial);

    }

}