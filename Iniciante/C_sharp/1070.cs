using System; 

class URI {

    static void Main(string[] args) { 

        int X = Convert.ToInt32(Console.ReadLine());
        int Y = X + 12;
        if(X%2!=0){
            Y = X + 11;
        }
            
        
        for(int i = X; i < Y; i++){
            if(i%2!=0){
                Console.WriteLine(i);
            }
        }

    }

}