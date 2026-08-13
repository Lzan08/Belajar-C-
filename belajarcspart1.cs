
using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine ("Start small. Ship something.");
        string hai = Console.ReadLine();
        Console.WriteLine("Kamu nulis {0}", hai);

        Console.WriteLine("MAsukan angka 1 :");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("MAsukan angka 2 :");
        int y = Convert.ToInt32(Console.ReadLine());
       int total = x+y;
       Console.WriteLine("jumlah total inventory adalah : {0}", total);       
        if ( total == 100){
            Console.WriteLine("Inventori penuh");
        }
        else if( total>= 50 && total < 100){
            Console.WriteLine("Inventory banyak");
        }
        else {
            Console.WriteLine("Inventory sedikit");
        }
    }
}