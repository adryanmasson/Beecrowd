using System; 

class URI {

    static void Main(string[] args) { 

        string[] NM = Console.ReadLine().Split();

        int abas = Convert.ToInt32(NM[0]);
        
        for(int i = 0; i < Convert.ToInt32(NM[1]); i++){
            if(Console.ReadLine() == "fechou"){
                abas += 1;
            }
            else{
                abas -= 1;
            }
        }
        
        Console.WriteLine(abas);

    }

}
