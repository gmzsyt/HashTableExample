using System;
using System.Collections;

namespace HashTableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable Sozluk = new Hashtable();
            Sozluk.Add("Araba", "Car");
            Sozluk.Add("Bilgisayar", "Computer");
            Sozluk["Kitap"] = " Book";
            ICollection anahtarlar = Sozluk.Keys;

             foreach (string anahtar in anahtarlar)
               Console.WriteLine(anahtar + " " + Sozluk[anahtar]);

           /* IDictionaryEnumerator ide = Sozluk.GetEnumerator();
            while(ide.MoveNext())
                Console.WriteLine(ide.Key + " "+ ide.Value);  */
        }
    }
}
