
using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Pilih Menu dibawah:");
        Console.WriteLine("1. buku");
        Console.WriteLine("2. baju");
        Console.WriteLine("Masukkan Angka : ");
        int x = Convert.ToInt32(Console.ReadLine());

        switch (x)
        {
            case 1:
                Console.WriteLine("kamu pilih produk buku");
                break;
            case 2:
                Console.WriteLine("Kamu pilih Produk Baju");
                break;
            
            default :
                Console.WriteLine("Pilihan Produk Tidak ada");
                break;
        }
    }
}