using System; 

class URI {

    static void Main(string[] args) { 


        const double pi = 3.14159;
        int R = Convert.ToInt32(Console.ReadLine());
        double volume = (4/3.0) * pi * R*R*R;
        
        
        Console.WriteLine("VOLUME = " + volume.ToString("0.000"));

    }

}