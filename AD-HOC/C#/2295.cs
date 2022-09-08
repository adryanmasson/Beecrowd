using System;



class URI {



   static void Main(string[] args) {



       string [] AeG = Console.ReadLine().Split(' ');
        
        double relacaoalcool = Convert.ToDouble(AeG[0])/Convert.ToDouble(AeG[2]);
        double relacaogasolina = Convert.ToDouble(AeG[1])/Convert.ToDouble(AeG[3]);
        
        
        if(relacaoalcool < relacaogasolina){
            Console.WriteLine("A");
        }else{
            Console.WriteLine("G");
        }



   }



}