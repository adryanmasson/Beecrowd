using System; 

class URI {

    static void Main(string[] args) { 

        string[] AB = Console.ReadLine().Split();
        
        int A = Convert.ToInt32(AB[0]);
        int B = Convert.ToInt32(AB[1]);
        
        if(A == B){
            Console.WriteLine(A);
        }
        else if(A > B){
            Console.WriteLine(A);
        }
        else{
            Console.WriteLine(B);
        }

    }

}
