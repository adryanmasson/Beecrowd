using System; 

class URI {

    static void Main(string[] args) { 

        int cur = Convert.ToInt32(Console.ReadLine());
        int boit = Convert.ToInt32(Console.ReadLine());
        int boto = Convert.ToInt32(Console.ReadLine());
        int mapi = Convert.ToInt32(Console.ReadLine());
        int lara = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine((225 + cur * 300 + boit * 1500 + boto * 600 + mapi * 1000 + lara * 150));

    }

}
