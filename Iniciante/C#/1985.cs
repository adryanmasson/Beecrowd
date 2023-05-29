using System; 

class URI {

    static void Main(string[] args) { 
        
        double valor = 0;
        
        int entradas = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < entradas; i++){
            string[] pq = Console.ReadLine().Split(' ');
            int P = Convert.ToInt32(pq[0]);
            double Q = Convert.ToInt32(pq[1]);
            
            switch (P){
                case 1001:
                    valor += 1.5 * Q;
                    break;
                
                case 1002:
                    valor += 2.5 * Q;
                    break;
                
                case 1003:
                    valor += 3.5 * Q;
                    break;
                
                case 1004:
                    valor += 4.5 * Q;
                    break;
                
                case 1005:
                    valor += 5.5 * Q;
                    break;
            }
        }
        
        Console.WriteLine(valor.ToString("0.00"));

    }

}
