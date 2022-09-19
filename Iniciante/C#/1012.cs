using System; 

class URI {

    static void Main(string[] args) { 
        
        const double pi = 3.14159;

        string [] medString = Console.ReadLine().Split(' ');
        
        double [] med = new double[3];
        
        for(int i = 0; i < 3; i++){
            med[i] = Convert.ToDouble(medString[i]);
        }
        
        Console.WriteLine("TRIANGULO: " + (med[0] * med[2] / 2).ToString("0.000"));
        Console.WriteLine("CIRCULO: " + (pi * med[2] * med[2]).ToString("0.000"));
        Console.WriteLine("TRAPEZIO: " + ((med[0] + med[1]) * med[2] / 2).ToString("0.000"));
        Console.WriteLine("QUADRADO: " + (med[1] * med[1]).ToString("0.000"));
        Console.WriteLine("RETANGULO: " + (med[0] * med[1]).ToString("0.000"));


    }

}