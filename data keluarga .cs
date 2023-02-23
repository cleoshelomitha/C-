using System; 
  
 public class HelloWorld 
 { 
         static public void Main() 
         { 
                  
                 familyhobi family = new familyhobi(); 
                 familyhobi ayah = new Ayah(); 
                 familyhobi ibu = new Ibu(); 
                 familyhobi saya = new Saya(); 
                 familyhobi adik = new Adik(); 
  
                 familydata ayahku = new familydata("Yanuar Pribadi", 48, +6281998046408); 
                 familydata ibuku = new familydata("Luluk Yuliati", 46, +6285780147289); 
                 familydata aku = new familydata("Cleo Shelomitha Ocsavitri", 16, +62895336390929); 
                 familydata adikku = new familydata("Chella Vega Aurora", 11, 0); 
  
  
                 Console.WriteLine("data ayah:\n" + ayahku.nama + "\n" + ayahku.umur + "\n" + ayahku.nohp); 
                 ayah.Hobi(); 
                 Console.WriteLine(); 
                  
                 Console.WriteLine("data ibu:\n" + ibuku.nama + "\n" + ibuku.umur + "\n" + ibuku.nohp); 
                 ibu.Hobi(); 
                 Console.WriteLine(); 
                  
                 Console.WriteLine("data saya:\n" + aku.nama + "\n" + aku.umur + "\n" + aku.nohp); 
                 saya.Hobi(); 
                 Console.WriteLine(); 
                  
                 Console.WriteLine("data adik:\n" + adikku.nama + "\n" + adikku.umur + "\n" + adikku.nohp); 
                 adik.Hobi(); 
  
         } 
          
         class familydata 
         { 
                 public string nama; 
                 public int umur; 
                 public long nohp; 
  
                 public familydata(string Nama, int Umur, long Nohp) 
                 { 
                         nama = Nama; 
                         umur = Umur; 
                         nohp = Nohp; 
                 } 
         } 
          
         class familyhobi 
         { 
                 public virtual void Hobi() 
                 { 
                         Console.WriteLine("Hobi"); 
                 } 
         } 
          
         class Ayah : familyhobi 
         { 
                 public override void Hobi() 
                 { 
                         Console.WriteLine("memancing dan menggambar"); 
                 } 
         } 
          
         class Ibu : familyhobi 
         { 
                 public override void Hobi() 
                 { 
                         Console.WriteLine("memasak dan membaca"); 
                 } 
         } 
          
         class Saya : familyhobi 
         { 
                 public override void Hobi() 
                 { 
                         Console.WriteLine("menulis dan membaca"); 
                 } 
         } 
          
         class Adik : familyhobi 
         { 
                 public override void Hobi() 
                 { 
                         Console.WriteLine("bersepeda"); 
                 } 
         } 
  
 }