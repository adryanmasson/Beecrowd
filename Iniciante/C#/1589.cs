using System; 

class URI {

    static void Main(string[] args) { 

        int N = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 0; i < N; i++){
            string[] test = Console.ReadLine().Split();
            Console.WriteLine(Convert.ToInt32(test[0]) + Convert.ToInt32(test[1]));
        }

    }

}
