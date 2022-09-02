using System; 

class URI {

    static void Main(string[] args) { 

        int N = 0;

        while(N <= 2 || N >= 1000){
            N = Convert.ToInt32(Console.ReadLine());
        }
        
        for(int i = 1; i <= 10; i++){
            Console.WriteLine(i + " x " + N + " = " + i*N);
        }

    }

}