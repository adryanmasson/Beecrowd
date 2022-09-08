using System; 

class URI {

    static void Main(string[] args) { 

        int N = Convert.ToInt32(Console.ReadLine());
        int Npow2 = 0;
        int Npow3 = 0;
        
        for (int i = 1; i <= N; i++){
            
            Npow2 = i*i;
            Npow3 = i*i*i;
            
            Console.WriteLine(i + " " + Npow2 + " " + Npow3);
            Console.WriteLine(i + " " + (Npow2+1) + " " + (Npow3+1));
        }

    }

}