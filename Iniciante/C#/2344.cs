using System; 

class URI {

    static void Main(string[] args) { 

        int nota = Convert.ToInt32(Console.ReadLine());
        
        if(nota >= 1 && nota <= 35){
            Console.WriteLine("D");
        }
        else if(nota >= 36 && nota <= 60){
            Console.WriteLine("C");
        }
        else if(nota >= 61 && nota <= 85){
            Console.WriteLine("B");
        }
        else if(nota >= 86 && nota <= 100){
            Console.WriteLine("A");
        }
        else{
            Console.WriteLine("E");
        }

    }

}
