using System; 

class URI {

    static void Main(string[] args) { 

        string[] CN = Console.ReadLine().Split();
        
        Console.WriteLine(Convert.ToInt32(CN[0]) % Convert.ToInt32(CN[1]));

    }

}
