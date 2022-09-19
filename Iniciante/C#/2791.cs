using System; 

class URI {

    static void Main(string[] args) { 

        string [] C = Console.ReadLine().Split(' ');
        
        for(int i = 0; i < 4; i++){
            if(C[i] != "0" ){
                Console.WriteLine(i+1);
            }
        }

    }

}