using System; 

class URI {

    static void Main(string[] args) { 

        int x = 1;
        string total = "";
        
        while(x != 0){
            total = "";
            x = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= x; i++){
                if(i != x){
                    total += (i + " ");
                    
                }else{
                    total += i;
                    Console.WriteLine(total);
                }
            }
        }

    }

}