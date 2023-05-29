using System; 

class URI {

    static void Main(string[] args) { 

        string[] N = Console.ReadLine().Split(' ');

        int P1 = Convert.ToInt32(N[0]);
        int C1 = Convert.ToInt32(N[1]);
        int P2 = Convert.ToInt32(N[2]);
        int C2 = Convert.ToInt32(N[3]);
        
        if(P1 * C1 == P2 * C2){
            Console.WriteLine("0");
        }
        else if(P1 * C1 > P2 * C2){
            Console.WriteLine("-1");
        }
        else{
            Console.WriteLine("1");
        }

    }

}
