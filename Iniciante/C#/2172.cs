using System; 

class URI {

    static void Main(string[] args) { 

        int X = 1;
        int M = 1;
        
        while(X != 0 && M != 0){
            string[] XM = Console.ReadLine().Split(' ');
            
            X = Convert.ToInt32(XM[0]);
            M = Convert.ToInt32(XM[1]);
            
            if(X != 0 && M != 0){
                Console.WriteLine(X*M);
            }
        }

    }

}
