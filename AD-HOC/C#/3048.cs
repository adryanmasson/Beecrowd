using System; 

class URI {

    static void Main(string[] args) { 

        int N = Convert.ToInt32(Console.ReadLine());
        
        int[] V = new int[N];
        
        int circulado = 1;
        
        for(int i = 0; i < N; i++){
            V[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        for(int i = 0; i < N - 1; i++){
            if(V[i] != V[i+1]){
                circulado += 1;
            }
        }
        
        Console.WriteLine(circulado);
        
    }

}