using System;

namespace Tugas
{
    class PBO
    {
        static void Main(string[] args)
        {
            // Menampilkan nama
            string name = "Rodifa";
            Console.WriteLine(name);

            // Deklarasi variabel
            int myInt = 29;
            double myDouble = 2.900;
            bool myBool = false;

            // Konversi dan tampilkan hasil konversi
            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToDouble(myInt));
            Console.WriteLine(Convert.ToInt32(myDouble));
            Console.WriteLine(Convert.ToString(myBool));

            // Deklarasi dan tampilkan elemen array
            string[] food = { "Bakmi", "Mie ayam", "Nasi Goreng" };

            for (int i = food.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(food[i]);
            }

            // Input dan tampilkan usia pengguna
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);

            // Tampilkan hasil akar kuadrat
            Console.WriteLine(Math.Sqrt(100));

            // Kondisi untuk waktu
            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("It is before 10 AM.");
            }
            else
            {
                Console.WriteLine("It is 10 AM or later.");
            }

            // Deklarasi dan Inisialisasi array
            string[] fruits = { "Apel", "Pisang", "Ceri", "Durian" };

            // Iterasi dan cetak elemen-elemen array menggunakan foreach
            int j = fruits.Length - 1;
             while ( j >= 0)
            {
                Console.WriteLine(fruits[j]);
                j--;
            }

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
}
