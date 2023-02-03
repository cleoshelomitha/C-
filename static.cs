using System;

public class HelloWorld
{
    static public void Main ()
    {
        
         Rumus.tampil();
         Rumus hallo = new Rumus();
         Console.Write("Masukkan jari jari:");
       int p =       Convert.ToInt16(Console.ReadLine());
         hallo.set(p);
         Console.Write($"luas lingkaran dengan r : {p} adalah :");
         hallo.get();
    }
    


    class Rumus 
    {

        public double hasil;

        public static void tampil(){
            Console.WriteLine("belajar static");
        }

        public double set(int a){
      return this.hasil = a * a * 3.14;
        }

        public void get(){
            Console.WriteLine(this.hasil);
        }
    }



}
