using System;

class URI {

    
    static void Main(string[] args) { 
        

        int N = Convert.ToInt32(Console.ReadLine());
        int distTotal = 0;
        for (int i = 0; i < N; i++){
            string[] info = Console.ReadLine().Split();
            distTotal += Convert.ToInt32(info[0]) * Convert.ToInt32(info[1]);
        }
        Console.WriteLine(distTotal);

    }

}
