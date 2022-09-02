using System;
using System.Linq;

class URI {

    public static string Reverse(string Input) { 
     
    char[] charArray = Input.ToCharArray(); 
     
    string stringinvertida = String.Empty; 
     
    for(int i = charArray.Length - 1; i > -1; i--) 
    { 
        stringinvertida += charArray[i]; 
    }
     
    return stringinvertida;
} 

    static void Main(string[] args) { 

        string [] qntfrulin = Console.ReadLine().Split(' ');
        string frutainvertida;
        
        
        string[] fruta = new string[Convert.ToInt32(qntfrulin[0])];
        string[] lista = new string[Convert.ToInt32(qntfrulin[1])];
        
        for(int i = 0; i < Convert.ToInt32(qntfrulin[0]); i++){
            fruta[i] = Console.ReadLine();
        }
        
        for(int i = 0; i < Convert.ToInt32(qntfrulin[1]); i++){
            lista[i] = Console.ReadLine();
        }
        
        lista = Array.ConvertAll(lista, d => d.ToLower());
        
        for(int i = 0; i < Convert.ToInt32(qntfrulin[0]); i++){
            frutainvertida = Reverse(fruta[i]);
            if (lista.Any(s => s.Contains(fruta[i].ToLower())) || lista.Any(s => s.Contains(frutainvertida.ToLower()))){
                Console.WriteLine("Sheldon come a fruta " + fruta[i].ToLower());
            }else{
                Console.WriteLine("Sheldon detesta a fruta " + fruta[i].ToLower());
            }
        }

    }

}