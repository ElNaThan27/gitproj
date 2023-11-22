string ulang = "y";
do{
Console.WriteLine("=============================");
Console.WriteLine("Selamat Datang di DJANTUR FC");
Console.WriteLine("=============================");
Console.WriteLine("Menu Makanan");
Console.WriteLine("1. Bakso = 12.000");
Console.WriteLine("2. Mie Ayam = 15.000");
Console.WriteLine("3. Soto = 18.000");
Console.WriteLine("4. Nasi Goreng = 14.000");
Console.Write("Masukkan pilihan makan anda= ");
int makan = Convert.ToInt32(Console.ReadLine());
int a= 12000;
int b= 15000;
int c= 18000;
int d= 14000;
switch(makan)
{
    case 1:
    Console.WriteLine($"Anda Memilih Bakso dengan harga {a}");
    makan = a;
    break;
    case 2:
    Console.WriteLine($"Anda Memilih Mie Ayam dengan harga {b}");
    makan = b;
    break;

    case 3:
    Console.WriteLine($"Anda Memilih Soto dengan harga {c}");
    makan = c;
    break;

    case 4:
    Console.WriteLine($"Anda Memilih Nasi Goreng dengan harga {d}");
    makan = d;
    break;

    default:
    Console.WriteLine("Menu tidak ada mohon baca ulang!!!");
    break;
}
Console.WriteLine("Menu Minuman");
Console.WriteLine("1. Es Teh Manis = 4.000");
Console.WriteLine("2. Es Teh Tawar = 2.000");
Console.WriteLine("3. Es Jeruk = 5.000");
Console.WriteLine("4. Air Putih = 1.000");
Console.Write("Masukkan pilihan minum anda= ");
int minum = Convert.ToInt32(Console.ReadLine());
int e = 4000;
int f = 2000;
int g = 5000;
int h = 1000;
switch(minum)
{
    case 1:
    Console.WriteLine($"Anda Memilih Es Teh Manis dengan harga {e}");
    minum = e;
    break;

    case 2:
    Console.WriteLine($"Anda Memilih Es Teh Tawar dengan harga {f}");
    minum = f;
    break;

    case 3:
    Console.WriteLine($"Anda Memilih Es Jeruk dengan harga {g}");
    minum = g;
    break;

    case 4:
    Console.WriteLine($"Anda Memilih Air Putih dengan harga {h}");
    minum = h;
    break;

    default:
    Console.WriteLine("Menu tidak ada mohon baca ulang!!!");
    break;
}
int total = makan + minum;
Console.WriteLine($"Total Harga {makan} + {minum} = {total}");
Console.WriteLine("\n1. Tunai");
Console.WriteLine("2. Debit");
Console.WriteLine("3. Uang Digital (GoPay,Ovo,Dana,M-Banking)");
Console.Write("Bayar Menggunakan=");
int bayar = Convert.ToInt32(Console.ReadLine());
switch (bayar)
{
    case 1:
    Console.WriteLine("Anda akan membayar menggunakan Tunai");
    break;

    case 2:
    Console.WriteLine("Anda akan membayar menggunakan Debit");
    break;

    case 3:
    Console.WriteLine("Anda akan membayar menggunakan uang digital");
    break;

    default:
    Console.WriteLine("Pilih yg bnr! Jangan Ngutang");
    break;
}
Console.Write ("Pesan Lagi? [y/n] =");
ulang = Console.ReadLine();
Console.WriteLine();
}while (ulang == "y");
