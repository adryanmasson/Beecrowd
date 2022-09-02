using System; 

class URI {

    static void Main(string[] args) { 

        int tipoCha = Convert.ToInt32(Console.ReadLine());
        
        string [] respParticipantes = Console.ReadLine().Split(' ');
        
        int respCertas = 0;
        
        for(int i = 0; i < 5; i++){
            if(Convert.ToInt32(respParticipantes[i]) == tipoCha){
                respCertas += 1;
            }
        }
        
        Console.WriteLine(respCertas);

    }

}