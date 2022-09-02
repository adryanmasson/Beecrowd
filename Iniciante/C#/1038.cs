using System; 

class URI {

    static void Main(string[] args) { 

        string [] sale = Console.ReadLine().Split(' ');
        int codigo = int.Parse(sale[0]);
        int qntd = int.Parse(sale[1]);
        double t = 0.00;
        
        switch(codigo){
            case 1:
            t = qntd*4.00;
            break;
            case 2:
            t = qntd*4.50;
            break;
            case 3:
            t = qntd*5.00;
            break;
            case 4:
            t = qntd*2.00;
            break;
            case 5:
            t = qntd*1.50;
            break;
        }
        
        Console.WriteLine("Total: R$ " + t.ToString("0.00"));

    }

}