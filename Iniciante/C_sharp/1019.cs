using System; 

class URI {

    static void Main(string[] args) { 
        
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(N/3600 + ":" + (N%3600)/60 + ":" + (N%3600)%60);

    }

}