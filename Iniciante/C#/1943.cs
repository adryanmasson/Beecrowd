using System; 

class URI {

    static void Main(string[] args) { 

        int K = Convert.ToInt32(Console.ReadLine());
        
        if(K == 1){
            Console.WriteLine("Top 1");
        }else if(K >= 2 && K <= 3){
            Console.WriteLine("Top 3");
        }else if(K >= 4 && K <= 5){
            Console.WriteLine("Top 5");
        }else if(K >= 6 && K <= 10){
            Console.WriteLine("Top 10");
        }else if(K >= 11 && K <= 25){
            Console.WriteLine("Top 25");
        }else if(K >= 26 && K <= 50){
            Console.WriteLine("Top 50");
        }else{
            Console.WriteLine("Top 100");
        }

    }

}