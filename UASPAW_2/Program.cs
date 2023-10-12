using System;

namespace UASPAW_2
{
    public class Program
    {
        static public  void Main(string[] args)
        {
            string pilihan, kasir,pelanggan;
            Console.WriteLine("==================================================== ");
            Console.WriteLine("                 Cafe Kenangan ");
            Console.WriteLine("==================================================== ");
            //menambhakan waktu dan tanggal
            Console.WriteLine("Time: " +DateTime.Now);
            //memasukan nama kasir
            Console.Write("Kasir:");
            kasir = Convert.ToString(Console.ReadLine());
            //memasukkan nama pelanggan 
            Console.Write("Pelanggan:");
            pelanggan = Convert.ToString(Console.ReadLine());
            //menampilkan menu yang ada di kafe kenangan 
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("              Menu Pilihan");
            Console.WriteLine("=====================================");
            Console.WriteLine(" 1. Nachos            = Rp. 25.000");
            Console.WriteLine(" 2. Chicken Fingers   = Rp. 18.000");
            Console.WriteLine(" 3. Roti Bakar        = Rp. 15.000");
            Console.WriteLine(" 4. Milk Tea          = Rp. 18.000");
            Console.WriteLine(" 5. Speciality Coffe  = Rp. 25.000");

            //memasukan harga pada menu dengan kata kunci uint
            byte jmlbeli;
            uint Na = 25000, ck = 18000, rb = 15000;
            uint mt = 18000, sc = 25000;
            uint th,tunai,kembalian=0;

            //memasukan no menu yang di beli
            Console.WriteLine();
            Console.Write("Masukkan Pilihan Menu: ");
            pilihan = Convert.ToString(Console.ReadLine());

            //jika pilihan 1
            if (pilihan == "1")
            {
                Console.WriteLine();
                //memasukan jumlah menu yang akan di beli
                Console.Write("Jumlah :");
                jmlbeli = Convert.ToByte(Console.ReadLine());

                //menghitung jumlah menu yang di beli dengan harga satuan dan menghasilkan total harga
                th = Na * jmlbeli;
                //menampilkan hasil pembelian 
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("              Menu Pilihan");
                Console.WriteLine("=====================================");
                Console.WriteLine(" Jumlah      Menu            Harga      Total");
                Console.WriteLine(jmlbeli + "  Nachos     =" +    Na         +th);
                Console.WriteLine("   0       Chicken Fingers  = 0");
                Console.WriteLine("  0       Roti Bakar       = 0");
                Console.WriteLine("  0       Milk Tea         = 0");
                Console.WriteLine("   0       Speciality Coffe = 0");
                Console.WriteLine(jmlbeli + "\tTotal                     =" + th);

                //menghitung tunai dan kembalian 
                Console.Write("          Tunai: Rp ");
                tunai = Convert.ToUInt32(Console.ReadLine());
                kembalian = tunai - th;
                Console.WriteLine("      Kembalian: Rp"+ kembalian);
                Console.WriteLine(" ================================== ");
                Console.WriteLine();
            }
            if (pilihan == "2")
            {

                //memasukan jumlah menu yang akan di beli
                Console.WriteLine();
                Console.Write("Jumlah :");
                jmlbeli = Convert.ToByte(Console.ReadLine());

                //menghitung jumlah menu yang di beli dengan harga satuan dan menghasilkan total harga
                th = ck * jmlbeli;
                //menampilkan hasil pembelian 
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("              Menu Pilihan");
                Console.WriteLine("=====================================");
                Console.WriteLine(" Jumlah      Menu            Harga      Total");
                Console.WriteLine("  0        Nachos             = 0");
                Console.WriteLine(jmlbeli + "   Chicken Fingers    =" + ck + th);
                Console.WriteLine("  0        Roti Bakar         = 0");
                Console.WriteLine("  0        Milk Tea           = 0");
                Console.WriteLine("  0        Speciality Coffe   = 0");
                Console.WriteLine(jmlbeli + "\tTotal                     =" + th);

                //menghitung tunai dan kembalian 
                Console.Write("          Tunai: Rp ");
                tunai = Convert.ToUInt32(Console.ReadLine());
                kembalian = tunai - th;
                Console.WriteLine("      Kembalian: Rp" + kembalian);
                Console.WriteLine(" ================================== ");
                Console.WriteLine();
                
            }
            if (pilihan =="3")
            {

                //memasukan jumlah menu yang akan di beli
                Console.WriteLine();
                Console.Write("Jumlah :");
                jmlbeli = Convert.ToByte(Console.ReadLine());

                //menghitung jumlah menu yang di beli dengan harga satuan dan menghasilkan total harga
                th = rb * jmlbeli;
                //menampilkan hasil pembelian 
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("              Menu Pilihan");
                Console.WriteLine("=====================================");
                Console.WriteLine(" Jumlah      Menu            Harga      Total");
                Console.WriteLine("  0        Nachos             = 0");
                Console.WriteLine("  0        Chicken Fingers    = 0");
                Console.WriteLine(jmlbeli + "Roti Bakar         =" + rb + th);
                Console.WriteLine("  0        Milk Tea           = 0");
                Console.WriteLine("  0        Speciality Coffe   = 0");
                Console.WriteLine(jmlbeli + "\tTotal                     =" + th);

                //menghitung tunai dan kembalian 
                Console.Write("          Tunai: Rp ");
                tunai = Convert.ToUInt32(Console.ReadLine());
                kembalian = tunai - th;
                Console.WriteLine("      Kembalian: Rp" + kembalian);
                Console.WriteLine(" ================================== ");
                Console.WriteLine();

                
            }
            if (pilihan == "4")
            {
                //memasukan jumlah menu yang akan di beli
                Console.WriteLine();
                Console.Write("Jumlah :");
                jmlbeli = Convert.ToByte(Console.ReadLine());

                //menghitung jumlah menu yang di beli dengan harga satuan dan menghasilkan total harga
                th = mt * jmlbeli;
                //menampilkan hasil pembelian 
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("              Menu Pilihan");
                Console.WriteLine("=====================================");
                Console.WriteLine(" Jumlah      Menu            Harga      Total");
                Console.WriteLine("  0        Nachos             = 0");
                Console.WriteLine("  0        Chicken Fingers    = 0");
                Console.WriteLine("  0        Roti Bakar         = 0");
                Console.WriteLine(jmlbeli + "   Milk Tea         = " + mt + th);
                Console.WriteLine("  0        Speciality Coffe   = 0" );
                Console.WriteLine(jmlbeli + "\tTotal                     =" + th);

                //menghitung tunai dan kembalian 
                Console.Write("          Tunai: Rp ");
                tunai = Convert.ToUInt32(Console.ReadLine());
                kembalian = tunai - th;
                Console.WriteLine("      Kembalian: Rp" + kembalian);
                Console.WriteLine(" ================================== ");
                Console.WriteLine();

            }
            if (pilihan == "5")
            {
                //memasukan jumlah menu yang akan di beli
                Console.WriteLine();
                Console.Write("Jumlah :");
                jmlbeli = Convert.ToByte(Console.ReadLine());

                //menghitung jumlah menu yang di beli dengan harga satuan dan menghasilkan total harga
                th = sc * jmlbeli;
                //menampilkan hasil pembelian 
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("              Menu Pilihan");
                Console.WriteLine("=====================================");
                Console.WriteLine(" Jumlah      Menu            Harga      Total");
                Console.WriteLine("  0        Nachos             = 0");
                Console.WriteLine("  0        Chicken Fingers    = 0");
                Console.WriteLine("  0        Roti Bakar         = 0");
                Console.WriteLine("  0        Milk Tea           = 0");
                Console.WriteLine(jmlbeli + "   Speciality Coffe =" + sc + th);
                Console.WriteLine(jmlbeli + "\tTotal                     =" + th);

                //menghitung tunai dan kembalian 
                Console.Write("          Tunai: Rp ");
                tunai = Convert.ToUInt32(Console.ReadLine());
                kembalian = tunai - th;
                Console.WriteLine("      Kembalian: Rp" + kembalian);
                Console.WriteLine(" ================================== ");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
            }

            //penutup
            Console.WriteLine();
            Console.WriteLine(" ====================================================");
            Console.WriteLine();
            Console.WriteLine("   Terima kasih Telah Berkunjung di Cafe Kenangan !! ");
            Console.WriteLine("                Semoga Selalu di Kenang!!            ");


        }
    }
}





























                









































        


    
