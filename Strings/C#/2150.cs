using System; 
using System.Linq;

class URI {

    static void Main(string[] args) { 

        while (true){
            
            string vogAlien = Console.ReadLine();
            
            if (string.IsNullOrEmpty(vogAlien)){
                break;
            }
            char[] vogais = vogAlien.ToCharArray();
                
                
            int qntdVogais = 0;
                
            string texto = Console.ReadLine();
                
            for(int i = 0; i < vogais.Length; i++){
                qntdVogais += texto.Count(x => x == vogais[i]);
            }
                
            Console.WriteLine(qntdVogais);
        }
        
    }

}
