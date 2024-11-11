using System;

class Program
{
    static void Main(string[] args)
    {
        // Minta user memasukkan jumlah elemen Fibonacci yang ingin dihitung
        Console.Write("Masukkan jumlah elemen Fibonacci: ");
        int n = int.Parse(Console.ReadLine());

        // Memanggil fungsi Fibonacci untuk menampilkan hasil
        Fibonacci(n);
    }

    static void Fibonacci(int n)
    {
        int firstNumber = 0, secondNumber = 1, nextNumber;

        // Jika n = 1, hanya cetak elemen pertama
        if (n == 1)
        {
            Console.WriteLine("Fibonacci: " + firstNumber);
        }
        else
        {
            Console.Write("Fibonacci: " + firstNumber + " " + secondNumber + " ");

            // Hitung elemen Fibonacci berikutnya hingga mencapai n elemen
            for (int i = 2; i < n; i++)
            {
                nextNumber = firstNumber + secondNumber;
                Console.Write(nextNumber + " ");

                // Update nilai untuk dua elemen sebelumnya
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }
        }
        Console.WriteLine(); // Pindah ke baris berikutnya setelah selesai mencetak
    }
}

