#include <iostream>

using namespace std;

int main()
{
    system("color 2");
    float a,b,c,rerata;
    char nama[100],kelas[100];
    int absen ;

    printf("Masukkan Biodata");
    printf("\nMasukkan Nama  = "); gets(nama);
    printf("Masukkan Kelas   = "); gets(kelas);
    printf("Masukkan No Absen= "); scanf ("%d", &absen);


    cout <<"\nMasukkan Nilai Bhs Indonesia = "; cin >> a;
    cout <<"Masukkan Nilai Matematika    = "; cin >> b;
    cout <<"Masukkan Nilai Bhs Inggris   = "; cin >> c;
    rerata = (a + b + c) / 3;

    printf("\nNama %s Berada di Kelas %s dengan nomor absen %d",nama,kelas,absen);
    cout << " dan memiliki nilai rata-rata = " << rerata; "\n";

}
