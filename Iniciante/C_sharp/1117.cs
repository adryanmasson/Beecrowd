using System; 

class URI {

    static void Main(string[] args) { 
        
        double Y = 0;
        
        for(int i = 0; i < 2; i++){
            double X = -1;
            while(X < 0.00 || X > 10.00){
                X = Convert.ToDouble(Console.ReadLine());
                if(X < 0.00 || X > 10.00){
                    Console.WriteLine("nota invalida");
                }
            }
            Y += X;
        }
        
        Console.WriteLine("media = " + Math.Round((Y/2), 2));
       
    }

}