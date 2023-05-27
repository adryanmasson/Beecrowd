using System; 

class URI {


    static void Main(string[] args) { 

        int N = Convert.ToInt32(Console.ReadLine());
        int i = 1;
        
        while(i <= N){
            int resto = N % i;
            if(resto == 0){
                Console.WriteLine(i);
            }
            i++;
        }

    }

}
