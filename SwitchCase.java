/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package branching;

import java.util.Scanner;
public class SwitchCase {
    public static void main(String[] args){
    Scanner command = new Scanner(System.in);
    String mobil;
    String ulang = "y";
    
    do{
    System.out.print("Masukkan perintah untuk mobil = ");
    mobil = command.nextLine();
    
    switch(mobil){
        case "nyalakan":
            System.out.println("Mobil dinyalakan");
            break;
        case "jalankan":
            System.out.println("Mobil mulai berjalan");
            break;
        case "belok kanan":
            System.out.println("Mobil berbelok ke kanan");
            break;
        case "belok kiri":
            System.out.println("Mobil berbelok ke kiri");
            break;
        case "berhenti":
            System.out.println("Mobil berhenti");
            break;
        case "matikan":
            System.out.println("Mobil dimatikan");
            break;
        default:
            System.out.println("Perintah belum bisa dimengerti");
    }
    System.out.print("Mau masukkan perintah lain?[y/n] = ");
    ulang = command.nextLine();
    }while (ulang.equals("y"));
    }    
}
