using System;

class Program
{
    static void Main()
    {
        // Minta pengguna untuk memasukkan angka
        Console.Write("Masukkan sebuah angka: ");
        
        // Membaca input dari pengguna dan mengonversinya menjadi integer
        string input = Console.ReadLine();
        int angka;
        
        // Memeriksa apakah input valid
        if (int.TryParse(input, out angka))
        {
            // Mengecek apakah angka positif, negatif, atau nol
            if (angka > 0)
            {
                Console.WriteLine("Angka tersebut adalah positif.");
            }
            else if (angka < 0)
            {
                Console.WriteLine("Angka tersebut adalah negatif.");
            }
            else
            {
                Console.WriteLine("Angka tersebut adalah nol.");
            }
        }
        else
        {
            // Menangani input yang tidak valid
            Console.WriteLine("Input tidak valid. Harap masukkan angka yang benar.");
        }
    }
}
