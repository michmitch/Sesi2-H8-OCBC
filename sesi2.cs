using System;
using System.Collections.Generic;

public class Sesi2 
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("LUAS");
        // double p, l;
        // Console.Write("Panjang : ");
        // p = double.Parse(Console.ReadLine());

        // Console.Write("Lebar : ");
        // l = double.Parse(Console.ReadLine());

        // Console.WriteLine("Luas : " + (p * l));

        // Console.WriteLine("=================================");

        // Console.WriteLine("BOOL");

        // bool nilai1 = true, nilai2 = false;
        // Console.WriteLine("Nilai 1 : " + nilai1);
        // Console.WriteLine("Nilai 2 : " + nilai2);

        // Console.WriteLine("=================================");

        // Console.WriteLine("==PROGRAM PENDAFTARAN PENDUDUK==");
        // Console.Write("Masukkan Nama : ");
        // string nama = Console.ReadLine();
        
        // Console.Write("Masukkan Alamat : ");
        // string alamat = Console.ReadLine();

        // Console.Write("Masukkan Umur : ");
        // int umur = int.Parse(Console.ReadLine());

        // Console.WriteLine("Terimakasih!");
        // Console.WriteLine("Data Berikut");
        // Console.WriteLine("Nama: " + nama);
        // Console.WriteLine("Alamat: " + alamat);
        // Console.WriteLine("Umur: " + umur + " tahun");
        // Console.WriteLine($"Umur: {umur}");
        // Console.WriteLine("SUDAH DISIMPAN!");

        // Console.WriteLine("=================================");

        // Console.WriteLine("==Menghitung Nilai==");
        // Console.Write("Masukkan Nilai PERTAMA : ");
        // int nilaipertama = int.Parse(Console.ReadLine());

        // Console.Write("Masukkan Nilai KEDUA : ");
        // int nilaikedua = int.Parse(Console.ReadLine());

        // Console.Write("Masukkan Nilai KETIGA : ");
        // int nilaiketiga = int.Parse(Console.ReadLine());

        // double totalnilai = nilaipertama + nilaikedua + nilaiketiga;
        // double rataratanilai = totalnilai / 3.0;

        // Console.WriteLine("Total Nilai Adalah : " + totalnilai);
        // Console.WriteLine("Rata-Rata Nilai Adalah : " + rataratanilai);

        // // Hitung Nilai 2
        // int nilai1 = 10;
        // int nilai2 = 8;

        // nilai1 = 15;
        // nilai2 += 6;

        // Console.WriteLine("Nilai 1 : " + nilai1);
        // Console.WriteLine("Nilai 2 : " + nilai2);

        // // Hitung Nilai 3
        // int nilai1, nilai2;
        // Console.Write("Nilai 1 : ");
        // nilai1 = int.Parse(Console.ReadLine());
        // Console.Write("Nilai 2 : ");
        // nilai2 = int.Parse(Console.ReadLine());

        // Console.WriteLine("Nilai Perbandingan");
        // Console.WriteLine($"nilai1 > nilai2 : {nilai1 > nilai2}");
        // Console.WriteLine($"nilai1 >= nilai2 : {nilai1 >= nilai2}");
        // Console.WriteLine($"nilai1 < nilai2 : {nilai1 < nilai2}");
        // Console.WriteLine($"nilai1 <= nilai2 : {nilai1 <= nilai2}");
        // Console.WriteLine($"nilai1 == nilai2 : {nilai1 == nilai2}");
        // Console.WriteLine($"nilai1 != nilai2 : {nilai1 != nilai2}");

        // Hitung Nilai 4
        Console.Write("Username : ");
        string username = Console.ReadLine();

        Console.Write("Password : ");
        string password = Console.ReadLine();

        Console.Write("Age : ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Gender (l/p) : ");
        string gender = Console.ReadLine();

        Console.Write("Marriage Status (y/n) : ");
        string statusNikah = Console.ReadLine();
        

        bool checkAge = age > 18;
        bool checkPass = password == "OCBC";
        bool checkUsername = username == "michael";

        if(checkAge && checkPass && checkUsername){
            Console.WriteLine("WELCOME TO THE CLUB!");
            Console.Write("Masukkan Nilai PERTAMA : ");
            int nilaipertama = int.Parse(Console.ReadLine());

            Console.Write("Masukkan Nilai KEDUA : ");
            int nilaikedua = int.Parse(Console.ReadLine());

            Console.Write("Masukkan Nilai KETIGA : ");
            int nilaiketiga = int.Parse(Console.ReadLine());

            double totalnilai = nilaipertama + nilaikedua + nilaiketiga;
            double rataratanilai = totalnilai / 3.0;

            Console.WriteLine();
            Console.WriteLine("Output Akhir");
            Console.WriteLine("Umur : " + age);
            Console.WriteLine("Username : " + username);
            
            if(gender == "l"){
                Console.WriteLine("Jenis Kelamin : Laki-Laki");
            }
            else if(gender == "p"){
                Console.WriteLine("Jenis Kelamin : Perempuan");
            }

            bool checkNikah = true;

            if(statusNikah == "y"){
                checkNikah = true;
            }
            else if(statusNikah == "n"){
                checkNikah = false;
            }

            Console.WriteLine("Status Nikah : " + checkNikah);

            Console.WriteLine("Total Nilai Adalah : " + totalnilai);
            Console.WriteLine("Rata-Rata Nilai Adalah : " + rataratanilai);

        }
        else{
            Console.WriteLine("Sorry, try again!");
        }

        
        // Console.WriteLine("Hello World");
        // Console.WriteLine("Hello Mic");
        // Console.WriteLine("Selamat Datang di Program Bootcamp OCBC");
        // Console.WriteLine("Tahap 1 saya akan belajar C#");

        // String namaCustomer = "Coeg";
        // List<double> harga = new List<double>();
        // harga.Add(10.000);
        // harga.Add(5.000);
        // harga.Add(20.000);

        // foreach (var item in harga)
        // {
        //     Console.WriteLine(item);
        // }

        // // for (int i=0; i<harga.Count; i++){
        // //     Console.WriteLine(harga[i]);
        // // }

        // double harga1 = 10.000, harga2 = 5.000, harga3 = 20.000;
        // int jum1 = 10, jum2 = 7, jum3 = 13;

        // double total1 = harga1 * jum1;
        // double total2 = harga2 * jum2;
        // double total3 = harga3 * jum3;

        // int jumAll = jum1 + jum2 + jum3;
        // double totalAll = total1 + total2 + total3;

        // Console.WriteLine("Nama Customer : " + namaCustomer);
        // Console.WriteLine("Barang 1 berjumlah " + jum1 + " dengan harga yang harus dibayar " + total1);
        // Console.WriteLine("Barang 2 berjumlah " + jum2 + " dengan harga yang harus dibayar " + total2);
        // Console.WriteLine("Barang 3 berjumlah " + jum3 + " dengan harga yang harus dibayar " + total3);

        // Console.WriteLine("Jumlah Total Semua Barang : " + jumAll);
        // Console.WriteLine("Harga Total Semua Barang : " + totalAll);
    }
}