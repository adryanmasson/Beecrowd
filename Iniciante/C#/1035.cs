using System; 

class URI {

    static void Main(string[] args) { 

        string [] abcdstring = Console.ReadLine().Split(' ');
        
        int [] abcd = new int[4];
        
        for(int i = 0; i < 4; i++){
            abcd[i] = Convert.ToInt32(abcdstring[i]);
        }
        
        if(abcd[1] > abcd[2] && abcd[3] > abcd[0] && abcd[2] + abcd[3] > abcd[0] + abcd[1] && abcd[2] > 0 && abcd[3] > 0 && abcd[0] % 2 == 0){
            Console.WriteLine("Valores aceitos");
        }else{
            Console.WriteLine("Valores nao aceitos");
        }
    }
}