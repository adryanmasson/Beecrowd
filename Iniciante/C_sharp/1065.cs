using System; 

class URI {

    static void Main(string[] args) { 
        
        int pares =0;
        
        for (int i = 0; i < 5; i++){
            int num = Convert.ToInt32(Console.ReadLine()) % 2;
            if(num == 0){
                pares += 1;
            }
        }
        
        Console.WriteLine(pares + " valores pares");
    }
}