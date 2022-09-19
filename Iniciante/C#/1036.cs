using System; 

class URI {

    static void Main(string[] args) { 

        string [] abcString = Console.ReadLine().Split(' ');
        
        double [] abc = new double[3];
        
        for(int i = 0; i < 3; i++){
            abc[i] = Convert.ToDouble(abcString[i]);
        }
        
        if(abc[0] == 0){
            Console.WriteLine("Impossivel calcular");
        }else{
            double delta = (abc[1] * abc[1]) - 4*abc[0]*abc[2];
        
            if(delta < 0){
                Console.WriteLine("Impossivel calcular");
            }else{
                double R1 = (-abc[1] + Math.Sqrt(delta))/(2*abc[0]);
                double R2 = (-abc[1] - Math.Sqrt(delta))/(2*abc[0]);
                
                Console.WriteLine("R1 = " + R1.ToString("0.00000"));
                Console.WriteLine("R2 = " + R2.ToString("0.00000"));
            }
            
    
        }
        
        
        

    }

}