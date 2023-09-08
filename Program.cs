using System;
using System.Collections;
using System.Collections.Generic;

namespace _001_CSharp_İntro
{
    public class Sehir : IComparable<Sehir>
    {
        public Sehir(int plakaNo, string sehirAdi)
        {
            PlakaNo = plakaNo;
            SehirAdi = sehirAdi;
        }

        public override string ToString()
        {
            return $"{PlakaNo,-5} {SehirAdi,-15}";
        }

        public int CompareTo(Sehir other) // karşılaştırılabilir olma niteliği kazandırdık.
        {
            if (this.PlakaNo<other.PlakaNo)
            {
                return -1;
            }
            else if (this.PlakaNo == other.PlakaNo)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public int PlakaNo { get; set; }
        public string SehirAdi { get; set; }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            int n = 16, sayac = 0;
            for (int i = n; i > 0; i/=2)
            {
                sayac++;
            }

            Console.WriteLine(sayac);
            //// Veri Yapıları Örnekleri
            //VeriYapilari14_HashSet();
            //VeriYapilari13_SortedSet();
            //VeriYapilari12_SortedDictionary();
            //VeriYapilari11_Dictionary();
            //VeriYapilari10_LinkedList();
            //VeriYapilari9_Queue();
            //VeriYapilari8_Stack();
            //VeriYapilari7_ListT();
            //VeriYapilari6_SortedList();
            //VeriYapilari5_HashTable();
            //VeriYapilari4_Array();
            //VeriYapilari3_Class();
            //VeriYapilari2_Struct();
            //VeriYapilari1_MaxMinsizeof();


            ////C#'a giriş örnekleri
            //Ornek21_ReferansTipleri();
            //Ornek20_DegerveReferansTipleri();
            //Ornek19_MetotOverloading();
            //Ornek18_MetotTasarimi();
            //Ornek17();
            //Ornek16();
            //Ornek15();
            //Ornek14();
            //Ornek13();
            //Ornek12();
            //Ornek11();
            //Ornek10();
            //Ornek9();
            //Ornek8();
            //Ornek7();
            //Ornek6();
            //Ornek5();
            //Ornek4();
            //Ornek3();
            //Ornek2();
            //Ornek1();
            Console.ReadKey();
        }

        private static void VeriYapilari14_HashSet()
        {
            //Hashset
            //Tanımlama
            var sesliHarf = new HashSet<char>()
            {
                'e', 'ı', 'i', 'u', 'ü', 'o', 'ö', 'b'
            };
            KoleksiyonYazdir(sesliHarf);

            //Ekleme
            sesliHarf.Add('a');
            KoleksiyonYazdir(sesliHarf);

            // Listeden Çıkarma
            sesliHarf.Remove('b');
            KoleksiyonYazdir(sesliHarf);


            //Console.WriteLine();
            //foreach (char k in sesliHarf)
            //{
            //    Console.Write($"{k, 5}");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Eleman sayisi: {0}", sesliHarf.Count);

            var alfabe = new List<char>();
            for (int i = 97; i < 123; i++)
            {
                alfabe.Add((char)i);
            }
            KoleksiyonYazdir(alfabe);


            //Türkçe'de kullanılan sesli harfler
            //sesliHarf.ExceptWith(alfabe);
            //sesliHarf.UnionWith(alfabe);
            //sesliHarf.IntersectWith(alfabe);
            sesliHarf.SymmetricExceptWith(alfabe);
            KoleksiyonYazdir(sesliHarf);
        }
        static void KoleksiyonYazdir(IEnumerable koleksiyon)
        {
            Console.WriteLine();
            int i = 0;
            foreach (char k in koleksiyon)
            {
                Console.Write($"{k,5}");
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("Eleman sayisi : {0}", i);
        }

        private static void VeriYapilari13_SortedSet()
        {
            // SortedSet<T>
            //Tanımlama
            var list = new SortedSet<string>();
            if (list.Add("Mehmet"))
            {
                Console.WriteLine("Mehmet Eklendi.");
            }
            else
            {
                Console.WriteLine("Ekleme başarisiz");
            }

            Console.WriteLine("{0}", list.Add("Ahmet") == true ? "Ahmet eklendi" : "Ekleme başarısız");

            if (list.Add("Mehmet"))
            {
                Console.WriteLine("Mehmet Eklendi.");
            }
            else
            {
                Console.WriteLine("Ekleme başarisiz");
            }

            list.Add("Sule");
            list.Add("Taha");
            list.Add("Neslihan");
            list.Add("Fahrettin");
            list.Add("Fatih");

            Console.WriteLine("\nİsimler Listesi\n");
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

            list.Remove("Sule");
            //list.RemoveWhere(deger => deger.Contains("a"));
            list.RemoveWhere(deger => deger.StartsWith("F"));
            Console.WriteLine("\nYeni İsimler Listesi\n");
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Eleman sayisi     : {0}", list.Count);

            //Sorted Set Örnek
            var sayilar = new List<int>();
            var r = new Random();
            Console.WriteLine();
            for (int i = 0; i < 1000; i++)
            {
                sayilar.Add(r.Next(5, 25));
                Console.Write($"{sayilar[i],-3}");
            }

            Console.WriteLine();

            // Listedeki benzersiz elemanlari bulmak
            var benzersizSayiListesi = new SortedSet<int>(sayilar);// SortedSet zaten benzersiz elemanların atanabildiği veri yapısı olduğu için ekstra fonksiyon yazmaya gerek yok.

            Console.WriteLine();
            Console.WriteLine("\n Benzersiz sayilarin listesi \n");
            foreach (int sayi in benzersizSayiListesi)
            {
                Console.Write($"{sayi,-3}");
            }

            Console.WriteLine("\n Benzersiz {0} sayi var \n", benzersizSayiListesi.Count);


            // SortedSet Küme İşlemleri
            //var A = new SortedSet<int>() { 1, 2, 3, 4 };
            var A = new SortedSet<int>(RastgeleSayiUret(100));
            //var B = new SortedSet<int>() { 1, 2, 5, 6 };
            var B = new SortedSet<int>(RastgeleSayiUret(100));


            Console.WriteLine();
            Console.WriteLine("A kümesi");

            foreach (int s in A)
            {
                Console.Write($"{s,5}");
            }

            Console.WriteLine();
            Console.WriteLine("B kümesi");

            foreach (int s in B)
            {
                Console.Write($"{s,5}");
            }
            Console.WriteLine();

            // Union(Birleşim)
            //A.UnionWith(B); // A ve B kümesinin unique karakterlerini birleştirir.
            //A.IntersectWith(B); // A ve B kümesinin ortak elemanlarını yazdırır.
            //A.ExceptWith(B); // Sadece A kümesinde olan elemanları ortaya çıkarır.
            A.SymmetricExceptWith(B); // Kesişim kümesi dışındaki elemanların listesini yazdırır.
            A.IsSubsetOf(B); // A, B'nin alt kümesi mi?
            //Console.WriteLine("\n\nA ve B kümesinin birleşimi");
            //foreach (int s in A)
            //{
            //    Console.Write($"{s,5}");
            //}
            //Console.WriteLine("\nToplam Eleman Sayisi: {0}", A.Count);
            //Console.WriteLine("\n\nA ve B kümesinin (Kesişimi) ortak elemanları");
            //foreach (int s in A)
            //{
            //    Console.Write($"{s,5}");
            //}
            //Console.WriteLine("\nToplam Eleman Sayisi: {0}", A.Count);
            //Console.WriteLine("\n\nSadece A kümesinin elemanları");
            //foreach (int s in A)
            //{
            //    Console.Write($"{s,5}");
            //}
            //Console.WriteLine("\nToplam Eleman Sayisi: {0}", A.Count);
            Console.WriteLine("\n\nKesişim kümesi dışındaki elemanların listesi");
            foreach (int s in A)
            {
                Console.Write($"{s,5}");
            }
            Console.WriteLine("\nToplam Eleman Sayisi: {0}", A.Count);
        }
        static List<int> RastgeleSayiUret(int n)
        {
            var list = new List<int>();
            var r = new Random();
            for (int i = 0; i < n; i++)
            {
                list.Add(r.Next(0, 1000));
            }
            return list;
        }

        private static void VeriYapilari12_SortedDictionary()
        {
            //SortedDictionary<Tkey,Tvalue>
            var kitapIndeks = new SortedDictionary<string, List<int>>()
            {
                {"HTML" , new List<int>(){8,10,12} },
                {"CSS" , new List<int>(){70,80,90} },
                {"Jquery", new List<int>(){3,5,15} },
                {"SQL", new List<int>(){70,80} },


            };

            kitapIndeks.Add("FTP", new List<int>() { 3, 5, 7 });
            kitapIndeks.Add("ASP.NET", new List<int>() { 50, 60 });
            foreach (var kavram in kitapIndeks)
            {
                Console.WriteLine(kavram.Key);
                kavram.Value.ForEach(s => Console.WriteLine($"\t > {s}"));
            }
        }

        private static void VeriYapilari11_Dictionary()
        {
            ////Dictionary<Tkey,Tvalue>
            //var telefonKodlari = new Dictionary<int, string>()
            //{
            //    {332, "Konya" },
            //    {424, "Elazığ" },
            //    {466, "Art"},
            //    {422, "Malatya" }
            //};

            ////Ekleme
            //telefonKodlari.Add(322, "Adana");
            //telefonKodlari.Add(212, "İstanbul");
            //telefonKodlari.Add(462, "Trabzon");

            //telefonKodlari[466] = "Artvin"; // Dictionarylere bu şekilde de erişilebilir.

            //// ContainKey
            //if (!telefonKodlari.ContainsKey(312))
            //{
            //    Console.WriteLine("\aAnkara'nın kod bilgisi tanımlı değil!");
            //    telefonKodlari.Add(312, "Ankara");
            //    Console.WriteLine("Yeni kod eklendi");
            //}

            //// ContainsValue
            //if (!telefonKodlari.ContainsValue("Malatya"))
            //{
            //    Console.WriteLine("\a Malatya'nın kod bilgisi tanimli değil!");
            //    telefonKodlari.Add(422, "Malatya");
            //    Console.WriteLine("Yeni kod eklendi");
            //}

            //telefonKodlari.Remove(322);

            //foreach (var s in telefonKodlari)
            //{
            //    Console.WriteLine(s);
            //}

            //Dictionary Örnek
            var personelListesi = new Dictionary<int, Personel>()
            {
                {110, new Personel("Mehmet", "Sonsoz", 7500)},
                {120, new Personel("Ahmet", "Can", 900) },
                {130, new Personel("Zeynep", "Coskun", 3000) },
            };
            personelListesi.Add(100, new Personel("Taha", "ASAN", 25000));
            foreach (var p in personelListesi)
            {
                Console.WriteLine(p);
            }
        }

        private static void VeriYapilari10_LinkedList()
        {
            // LinkedList<T> Temelleri
            //Tanımlama
            var sehirler = new LinkedList<string>();
            sehirler.AddFirst("Ordu");
            sehirler.AddFirst("Trabzon");
            sehirler.AddLast("İstanbul");
            sehirler.AddAfter(sehirler.Find("Ordu"), "Samsun");
            sehirler.AddBefore(sehirler.First.Next.Next, "Giresun");
            sehirler.AddAfter(sehirler.Last.Previous, "Sinop");
            sehirler.AddAfter(sehirler.Find("Sinop"), "Zonguldak");

            Console.WriteLine();
            Console.WriteLine("Gidiş Güzergahı");

            var eleman = sehirler.First;
            while (eleman != null)
            {
                Console.WriteLine(eleman.Value);
                eleman = eleman.Next;
            }

            Console.WriteLine();
            Console.WriteLine("Gidiş Güzergahı");
            Console.WriteLine();

            var gecici = sehirler.Last;
            while (gecici != null)
            {
                Console.WriteLine(gecici.Value);
                gecici = gecici.Previous;
            }
        }

        private static void VeriYapilari9_Queue()
        {
            //// Queue<T> 
            ////Tanımlama
            //var karakterKuyrugu = new Queue<char>();

            //// Ekleme
            //karakterKuyrugu.Enqueue('a');
            //karakterKuyrugu.Enqueue('e');
            //Console.WriteLine($"Eleman Sayısı: {karakterKuyrugu.Count}");
            //var dizi = karakterKuyrugu.ToArray();

            //// Çıkarma
            //Console.WriteLine($"Kuyruğun başındaki eleman:  { karakterKuyrugu.Peek() }");
            //Console.WriteLine($"Kuyruktan çıkartıldı:  { karakterKuyrugu.Dequeue() }");            
            //Console.WriteLine($"Eleman Sayısı: {karakterKuyrugu.Count}");
            //Console.WriteLine($"Kuyruğun başındaki eleman:  { karakterKuyrugu.Peek() }");

            // Queue Örneği
            var sesliHarfler = new List<char>()
            {
                'a','e','ı','i','o','ö','u','ü'
            };

            ConsoleKeyInfo secim;

            var kuyruk = new Queue<char>();

            foreach (char k in sesliHarfler)
            {
                Console.WriteLine();
                Console.WriteLine($"{k,-5} kuyruğa eklensin mi? [e/h]");
                secim = Console.ReadKey();
                Console.WriteLine();
                if (secim.Key == ConsoleKey.E)
                {
                    kuyruk.Enqueue(k);
                    Console.WriteLine($"\n{k,-5} kuyruğa eklendi.");
                    Console.WriteLine($"Kuyruktaki eleman sayisi: {kuyruk.Count}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Kuyruktan elemanların kaldırılması için ESC tuşuna basın");
            secim = Console.ReadKey();

            if (secim.Key == ConsoleKey.Escape)
            {
                while (kuyruk.Count > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{kuyruk.Peek(),5} kuyruktan çıkartılıyor");
                    Console.WriteLine($"{kuyruk.Dequeue(),5} kuyruktan çıktı.");
                    Console.WriteLine($"Kuyruktaki eleman sayisi {kuyruk.Count}");
                }
                Console.WriteLine("Program bitti.");
            }
        }

        private static void VeriYapilari8_Stack()
        {
            //// Stack <T>
            //// Tanımlama
            //var karakterYigini = new Stack<char>();

            ////Ekleme
            //karakterYigini.Push('a');
            //Console.WriteLine(karakterYigini.Peek());
            //karakterYigini.Push('b');
            //Console.WriteLine(karakterYigini.Peek());
            //karakterYigini.Push('c');
            //Console.WriteLine(karakterYigini.Peek());


            //// Çıkarma
            //Console.WriteLine(karakterYigini.Pop()+ " yığından çıkartıldı");
            //Console.WriteLine(karakterYigini.Pop()+ " yığından çıkartıldı");
            //Console.WriteLine(karakterYigini.Pop()+ " yığından çıkartıldı");

            //var karakterYigini = new Stack<char>();
            //for (int i = 65; i <= 90; i++)
            //{
            //    karakterYigini.Push((char)i);
            //    Console.WriteLine($"{karakterYigini.Peek()} yığına eklendi.");
            //    Console.WriteLine($"Yığındaki eleman sayisi: {karakterYigini.Count}");
            //}
            ////Ek bilgi
            //var dizi = karakterYigini.ToArray();

            //Console.WriteLine("Yığından çıkartma işlemi için bir tuşa basınız.");
            //Console.ReadKey();

            //while (karakterYigini.Count>0)
            //{
            //    Console.WriteLine($"{karakterYigini.Pop()} yığından çıkarıldı");
            //    Console.WriteLine($"Yığındaki eleman sayisi: {karakterYigini.Count}");
            //}

            // Stack Uygulaması
            Console.WriteLine("Bir sayi Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            var sayiYigini = new Stack<int>();
            while (sayi > 0)
            {
                int k = sayi % 10;
                sayiYigini.Push(k);
                sayi = sayi / 10;
            }

            int i = 0;
            int n = sayiYigini.Count - 1;
            foreach (var s in sayiYigini)
            {
                Console.WriteLine($"\t{s,7} x {Math.Pow(10, n - i),7}\t = {s * Math.Pow(10, n - i),7}");
                i++;
            }
        }

        private static void VeriYapilari7_ListT()
        {
            // List<T>
            //Tanımlama
            var sayilar = new List<int>() { 54, 33, 54, 767, 33, 43, 65, 2, 6 };
            sayilar.Sort();
            sayilar.ForEach(s => Console.WriteLine(s));

            //Sehir Listesi
            var sehirler = new List<Sehir>()
            {
                new Sehir(6, "Ankara"),
                new Sehir(34,"İstanbul"),
                new Sehir(61, "Trabzon"),
                new Sehir(28, "Giresun"),
                new Sehir(44, "Malatya"),

            };
            sehirler.Add(new Sehir(1, "Adana"));
            sehirler.Sort();
            sehirler.ForEach(s => Console.WriteLine(s));
        }

        private static void VeriYapilari6_SortedList()
        {
            // SortedList - Temeller
            // Tanımlama
            var list = new SortedList()
            {
                {1, "Bir" },
                {2, "İki" },
                {3, "Üç" },
                {8, "Sekiz" },
                {5, "Beş" },
                {6, "Altı" },
            };
            //list.Add(1, "Bir");
            //list.Add(2, "İki");
            //list.Add(3, "Üç");
            //list.Add(4, "Dört");
            //list.Add(5, "Beş");
            list.Add(4, "Dört");

            //Dolaşma
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.WriteLine("Listedeki eleman sayisi: {0}", list.Count);
            Console.WriteLine("Listenin kapasitesi: {0}", list.Capacity); // liste kapasitesi 16

            list.TrimToSize(); // Yeni eleman eklemeyeceksek, Eleman sayısına bağlı olarak kapasiteyi set eder.
            Console.WriteLine(list.Capacity); // liste kapasitesini eleman sayısına eşitledi.

            // Erişme
            // Key
            Console.WriteLine(list[4]);
            //Index
            Console.WriteLine(list.GetByIndex(0));
            // Get -> Key (Index to Key)
            Console.WriteLine(list.GetKey(3));
            // Liste sonundaki elemanın değeri(value)
            Console.WriteLine(list.GetByIndex(list.Count - 1));

            var anahtarlar = list.Keys;
            Console.WriteLine("\n Anahtarlar");
            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }

            var degerler = list.Values;
            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n Güncelleme");
            if (list.ContainsKey(1))
            {
                list[1] = "One";
            }

            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            list.Remove(list.Count - 3); // Key değeri verilen SortedList elemanını siler.
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.WriteLine("\n");

            // SortedList Uygulama
            var kitapIcerigi = new SortedList()
            {
                {11, "Başlangıç" },
                {22, "Veri Yapıları" },
                {33, "Algoritmalar" },
                {61, "Uygulama Örnekleri" },
            };
            kitapIcerigi.Add(1, "Önsöz");
            kitapIcerigi.Add(50, "Degiskenler");
            kitapIcerigi.Add(40, "Operatörler");
            kitapIcerigi.Add(60, "Döngüler");
            kitapIcerigi.Add(45, "İlişkisel Döngüler");
            Console.WriteLine("İçindekiler");
            Console.WriteLine(new String('-', 25));
            Console.WriteLine($"{"Konular",-33}  {"Sayfalar",8}");
            foreach (DictionaryEntry item in kitapIcerigi)
            {
                Console.WriteLine($"{item.Value,-33}  {item.Key,8}");
            }
        }

        private static void VeriYapilari5_HashTable()
        {
            // HASHTABLE
            var sehirler = new Hashtable();

            // Ekleme
            sehirler.Add(6, "Ankara");
            sehirler.Add(34, "İstanbul");
            sehirler.Add(61, "Trabzon");
            sehirler.Add(55, "Samsun");

            //Dolaşma
            foreach (DictionaryEntry item in sehirler)
            {
                Console.WriteLine($"{item.Key,-5} - {item.Value,-20}");
            }

            //Anahtarları Alma
            Console.WriteLine("\nAnahtarlar(Keys) ");
            var anahtarlar = sehirler.Keys;
            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }

            // Değerler
            Console.WriteLine("\nDeğerler(Value) ");
            ICollection degerler = sehirler.Values;
            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }

            // Elemana erişme
            Console.WriteLine("\nElemana erişmek:");
            Console.WriteLine(sehirler[55]); // Hashtable'da eğer bir key elimizde varsa onun Value'sunu bulabiliriz.

            // Eleman Silme
            Console.WriteLine("\n Eleman silme");
            sehirler.Remove(6);
            foreach (DictionaryEntry item in sehirler)
            {
                Console.WriteLine($"{item.Key,-5}" + $" - {item.Value,-20}");
            }

            // Hashtable uygulamasi
            //başlığı okuma (1. adım)
            Console.WriteLine("Başlık Giriniz: ");
            string baslik = Console.ReadLine();

            //küçültme (2. adım)
            baslik = baslik.ToLower();

            // HashTable (3. adım)
            var karakterSeti = new Hashtable()
            {
                {'ç', 'c'}, // anahtarlar biriciktir. Yani aynı anahtarı tekrar kullanamazsın.
                {'ı', 'i' },
                {'ö', 'o' },
                {'ü', 'u' },
                {' ', '-' },
                {'\'', '-' },
                {'.', '-' },
                {'ğ', 'g' },
                {'?', '-' },

            };
            foreach (DictionaryEntry item in karakterSeti)
            {
                baslik = baslik.Replace((char)item.Key, (char)item.Value); //Hashtable generic olmadığı için, item.Key ve item.Value object sınıfındadır. Replace metodunun için (char) yazarak unboxing yöntemini uygularız.

            }

            // Ekranda yazdir (4. adım)
            Console.WriteLine(baslik);
        }

        private static void VeriYapilari4_Array()
        {
            //// Array | Dizi | Tanımlama
            //int[] sayilar = new int[] { 5, 3, 8, 10, 2, 18, 23, 44, 55, 6, 34, 19 };         // Diziler bu şekilde de tanımlanabilir.
            //var arr = new ArrayList(sayilar);                    // Diziler bu şekilde başka dizilere de atanabilir.
            //var numbers = Array.CreateInstance(typeof(int), sayilar.Length);  //            
            ////numbers.SetValue(-5, 0);                              //
            ////numbers.SetValue(3, 1);                              //  Bu şekilde de dizi tanımlanabilir.
            ////numbers.SetValue(8, 2);                              //
            ////numbers.SetValue(10, 3);                             //
            ////numbers.SetValue(-2, 4);                             //

            ////for (int i = 0; i < sayilar.Length; i++) 
            ////{
            ////    numbers.SetValue(sayilar[i], i);
            ////}

            //sayilar.CopyTo(numbers,0);
            //Array.Sort(sayilar); // Sort sıralama işine yarar.
            //Array.Sort(numbers);
            //arr.Sort();//ArrayList yapısı olduğu için Sort fonksiyonuyla bu liste yapısını sıralayabiliriz.
            //Array.Clear(sayilar, 2, 3); // Seçilen Array'i, seçilen indexten itibaren seçilen sayı kadar indexini temizler. 0 yapar.
            //var x = Array.IndexOf(sayilar, 44); // Array içerisindeki istediğin bir değeri verip index numarasını bulabilirsin.
            //Console.WriteLine(x);               // Eğer dizi olmayan bir değeri aratırsak çıktı olarak -1 döner.


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"Sayilar[{i}] = " +
            //        $"{sayilar[i],3} - " +
            //        $"numbers[{i}] = {numbers.GetValue(i),3} " +
            //        $"arr[{i}] = " +
            //        $"{arr[i],3}");
            //}

            

        }

        private static void VeriYapilari3_Class()
        {
            //Tanımlama
            //OgretimElemani ogrGor = new OgretimElemani();

            //Atama-1
            //ogrGor.SicilNo = 101;
            //ogrGor.Adi = "Ahmet";
            //ogrGor.Soyadi = "Yalcin";
            //ogrGor.Cinsiyet = true;
            //Console.WriteLine(ogrGor);

            // Atama-2
            //OgretimElemani ogrGor = new OgretimElemani() 
            //{
            //    SicilNo = 102,
            //    Adi = "Taha",
            //    Soyadi = "ASAN",
            //    Cinsiyet = true
            //};

            // Atama-3
            //OgretimElemani ogrGor = new OgretimElemani(100, "Taha", "ASAN", true);
            //Console.WriteLine(ogrGor);

            // Tanımlama - Atama
            var liste1 = new List<OgretimElemani>()
            {
                    new OgretimElemani(100, "Ahmet", "Yalcin", true),
                    new OgretimElemani(101, "Mehmet", "Çınar", true),
                    new OgretimElemani(102, "Hasan", "Berk", true),
                    new OgretimElemani(103, "Can", "Mert", true),
                    new OgretimElemani(104, "Leyla", "Selin", false),
                    new OgretimElemani(105, "Aylin", "Aslı", false)
            };

            #region
            Console.WriteLine("Liste 1");
            liste1.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();

            var liste2 = liste1;
            Console.WriteLine("Liste 2");
            liste2.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();
            #endregion
            liste2.Add(new OgretimElemani(106, "Öner", "Han", true));
            liste1.RemoveAt(0);

            Console.WriteLine("Ekleme yapildi");

            Console.WriteLine("Liste 1");
            liste1.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();

            Console.WriteLine("Liste 2");
            liste2.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();
        }

        private static void VeriYapilari2_Struct()
        {
            var n1 = new Nokta(3, 4);
            Console.WriteLine($"n1: {n1}");
            n1.Degistir();
            Console.WriteLine($"n1: {n1}");
            var n2 = n1;
            Console.WriteLine($"n2: {n2}");
            n2.X = -1 * n2.X;
            Console.WriteLine($"n1: {n1}");
            Console.WriteLine($"n2: {n2}");


            // STRUCT 
            //Ogrenci ogr = new Ogrenci();
            //ogr.Numara = 10;
            //ogr.Adi = "Taha";
            //ogr.Soyadi = "ASAN";
            //ogr.Cinsiyet = true;
            //Console.WriteLine($"{ogr.Numara} " + $"{ogr.Adi} {ogr.Soyadi} " + $"{ogr.Cinsiyet}");

            // Alternatif kullanma
            //var ogr2 = new Ogrenci()
            //{
            //    Numara = 20,
            //    Adi = "Fatma",
            //    Soyadi = "Dag",
            //    Cinsiyet = false
            //};
            //Console.WriteLine($"{ogr2.Numara} " + $"{ogr2.Adi} {ogr2.Soyadi} " + $"{ogr2.Cinsiyet}");

            // Alternatif - 3
            //var ogr3 = new Ogrenci(30, "Mehmet", "Avşar", true);
            //Console.WriteLine($"{ogr3.Numara} " + $"{ogr3.Adi} {ogr3.Soyadi} " + $"{ogr3.Cinsiyet}");

            //var ogr4 = new Ogrenci(40, "Asaf", "Karlıdağ");
            //Console.WriteLine($"{ogr4.Numara} " + $"{ogr4.Adi} {ogr4.Soyadi} " + $"{ogr4.Cinsiyet}");

            //Console.WriteLine(ogr);
            //Console.WriteLine(ogr2);
            //Console.WriteLine(ogr3);
            //Console.WriteLine(ogr4);

            //var ogrenciListesi = new List<Ogrenci>()
            //{
            //    new Ogrenci(27, "Taha", "ASAN", true),
            //    new Ogrenci(30, "Mehmet", "Avşar", true),
            //    new Ogrenci(16, "Asaf", "Karlıdağ", true),
            //    new Ogrenci(27, "Menekşe", "Bozkır", false),
            //    new Ogrenci(27, "Taha", "ASAN", true)
            //};
            //ogrenciListesi.ForEach(o => Console.WriteLine(o));
        }

        private static void VeriYapilari1_MaxMinsizeof()
        {
            //// 8-bit integer
            //Console.WriteLine(nameof(SByte));
            //Console.WriteLine($"Alt limit:   {SByte.MinValue,20}");
            //Console.WriteLine($"Üst limit:   {SByte.MaxValue,20}");
            //Console.WriteLine($"Boyut:       {sizeof(SByte),20}");
            //Console.WriteLine();
            //Console.ReadKey();

            //// Unsigned 8-bit integer
            //Console.WriteLine(nameof(Byte));
            //Console.WriteLine($"Alt limit:   {Byte.MinValue,20}");
            //Console.WriteLine($"Üst limit:   {Byte.MaxValue,20}");
            //Console.WriteLine($"Boyut:       {sizeof(Byte),20}");
            //Console.WriteLine();
            //Console.ReadKey();

            //// Signed 16-bit integer
            //Console.WriteLine(nameof(Int16));
            //Console.WriteLine($"Alt limit:   {Int16.MinValue,20}");
            //Console.WriteLine($"Üst limit:   {Int16.MaxValue,20}");
            //Console.WriteLine($"Boyut:       {sizeof(Int16),20}");
            //Console.WriteLine();
            //Console.ReadKey();

            //// Unsigned 16-bit integer
            //Console.WriteLine(nameof(UInt16));
            //Console.WriteLine($"Alt limit:   {UInt16.MinValue,20}");
            //Console.WriteLine($"Üst limit:   {UInt16.MaxValue,20}");
            //Console.WriteLine($"Boyut:       {sizeof(UInt16),20}");
            //Console.WriteLine();
            //Console.ReadKey();

            //// Signed 32-bit integer
            //Console.WriteLine(nameof(Int32));
            //Console.WriteLine($"Alt limit:   {Int32.MinValue,20}");
            //Console.WriteLine($"Üst limit:   {Int32.MaxValue,20}");
            //Console.WriteLine($"Boyut:       {sizeof(Int32),20}");
            //Console.WriteLine();
            //Console.ReadKey();

            //// Double
            //Console.WriteLine(nameof(Double));
            //Console.WriteLine($"Alt limit:   {Double.MinValue,20}");
            //Console.WriteLine($"Üst limit:   {Double.MaxValue,20}");
            //Console.WriteLine($"Boyut:       {sizeof(Double),20}");
            //Console.WriteLine();
            //Console.ReadKey();

            //// Boolean
            //Console.WriteLine(nameof(Boolean));
            //Console.WriteLine($"Boyut:       {sizeof(Boolean),20}");
            //Console.WriteLine();
            //Console.ReadKey();
        }

        // Algoritma ve Temel C# Örnekleri

        private static void Ornek21_ReferansTipleri()
        {
            //var sehirler = new List<string>()
            //{
            //    "Ankara",
            //    "İstanbul",
            //    "Van",
            //    "Samsun",
            //    "Ordu"
            //};

            //foreach (string s in sehirler)
            //{
            //    Console.WriteLine(s);
            //}

            ////Lambda expression
            //sehirler.ForEach(s => Console.WriteLine(s));

            //Console.WriteLine(new string('-', 50)); // Bu kod satırları ayırırken 50 tane - işareti atar. ----------

            //var iller = sehirler;
            //iller.ForEach(i => Console.WriteLine(i));
            //Console.WriteLine();
            //sehirler.Add("Sinop");
            //sehirler.ForEach(s => Console.WriteLine(s));
            //Console.WriteLine();
            //iller.ForEach(i => Console.WriteLine(i));
            //iller.Remove("Ankara");
            //iller.ForEach(i => Console.WriteLine(i));
            //Console.WriteLine();
            //sehirler.ForEach(s => Console.WriteLine(s));
        }

        private static void Ornek20_DegerveReferansTipleri()
        {
            int x = 10;
            int y = 20;
            Console.WriteLine("{0},{1}", x, y);
            Degistir(x, y);
            Console.WriteLine("{0},{1}", x, y); // Değer tipli değişkenler
            Degistir(ref x, ref y);
            Console.WriteLine("{0},{1}", x, y); // Referans tipli değişkenler
        }
        private static void Degistir(int a, int b)//x ile a aynı değildir, a sadece x'in değerini tutar. x değişmez.
        {
            int gecici = a;
            a = b;
            b = gecici;
            Console.WriteLine("{0},{1}", a, b);

        }
        private static void Degistir(ref int a, ref int b)//ref anahtar sözcüğüyle x ve ynin yerine referans verdiği belli oluyor.
        {
            int gecici = a;
            a = b;
            b = gecici;
            Console.WriteLine("{0},{1}", a, b);

        }

        private static void Ornek19_MetotOverloading()
        {
            //// overload sürecinde bir metodun 1 parametre alabiliyorsa, 1 parametre verilen değere göre işlem yapar,
            //// eğer metot 2 parametre alabiliyorsa, 2 parametre verilen değere göre işlem yapar.
            //double odenecekMiktar = SatisYap(100);
            //Console.WriteLine(odenecekMiktar);

            //var odenecekMiktar2 = SatisYap(100, .1);
            //Console.WriteLine("{0,5:0.##}", odenecekMiktar2);
        }
        /// <summary>
        /// Satış yapan fonksiyon.
        /// </summary>
        /// <param name="miktar">Alış-veriş tutarı.</param>
        /// <returns>KDV eklenmiş toplam ödenecek miktar.</returns>
        static double SatisYap(double miktar)// private'ı silince internal olarak algılanır
        {
            return miktar * 1.18;
        }
        /// <summary>
        /// Satış yapan fonksiyon.
        /// </summary>
        /// <param name="miktar">Alış-veriş tutarı</param>
        /// <param name="indirim">indirim miktarı</param>
        /// <returns>KDV eklenmiş toplam ödenecek miktar.</returns>
        static double SatisYap(double miktar, double indirim)
        {
            return (miktar * (1.0 - indirim)) * 1.18;
        }

        private static void Ornek18_MetotTasarimi()
        {
            //int buyuk = Karsilastir(3, 5);
            ////Console.WriteLine(buyuk); // Output: 5
            ////Console.WriteLine(Karsilastir(5,7)); // Output: 7
            ////Console.WriteLine(KareAl(3));
            ////var x = KareAl(5);
            ////double y = KareAl(x);

            ////Console.WriteLine(x);
            ////Console.WriteLine(y);

            //double toplam = SeriToplami(5.52, 15.12, 25.54, 13.13);
            //Console.WriteLine("{0,5:0.##}", toplam);
        }
        private static double SeriToplami(params double[] seri)
        {
            double toplam = 0;
            foreach (double s in seri)
            {
                toplam += s;
            }
            return toplam;
        }
        public static int Karsilastir(int A, int B)
        {
            if (A > B)
            {
                return A;
            }
            else
            {
                return B;
            }
            return A > B ? A : B;
        }
        static double KareAl(double sayi)
        {
            double kare = sayi * sayi;
            return kare;
        }

        private static void Ornek17()
        {
            ////Tanımlama
            //List<int> sayilar = new List<int>() { 10, 15, 20 };

            //int x = 55;
            //int[] seri = new int[] { 70, 80, 90 };
            ////Ekleme
            //sayilar.Add(x);
            //sayilar.AddRange(seri);// seri dizisini sayilar listesine ekler. int olduğu için bu mümkün.
            //sayilar.AddRange(new int[] { 40, 50, 60 });

            ////Araya ekleme
            //sayilar.Insert(3, 0);
            //sayilar.InsertRange(4, new int[] { 80, 90 });

            //sayilar.RemoveAt(3);
            //sayilar.RemoveAt(sayilar.IndexOf(55));



            //foreach (int s in sayilar)
            //{
            //    Console.WriteLine($"{s,-5}");
            //}
        }

        private static void Ornek16()
        {
            ////Tanımlama
            //var arrayList = new ArrayList()
            //{
            //    10, "BTK Akademi", true, 'e'
            //};//aynı çıktı elde edilir.

            //// Ekleme
            //arrayList.Add(10); // boxing //int
            //arrayList.Add("BTK Akademi"); //string
            //arrayList.Add(true); //bool
            //arrayList.Add('e'); //char
            //                    //arrayListe koyduğumuz tüm elemanların türünü object olarak tutar. Ondan dolayı string ve inti beraber alabiliyoruz

            ////dolaşma
            //foreach (var e in arrayList)
            //{
            //    Console.Write($"{e} ");
            //}

            //int[] sayilar = new int[] { 23, 44, 55 };
            //arrayList.AddRange(sayilar);
            //// ArrayList'e başka bir dizide eklenebilir. Output: 10 BTK Akademi True e 10 BTK Akademi True e 23 44 55
            ////dolaşma
            //foreach (var e in arrayList)
            //{
            //    Console.Write($"{e} ");
            //}
            //Console.WriteLine(arrayList[4]); // Output: 23

            //// Elemana erişme - atama
            //int x = (int)arrayList[0]; // arrayList in 0. indeksi olan 10 int olduğu için onu bir x değerine atarken mutlaka (int) olduğunu söylemeliyiz
            //Console.WriteLine(x + 10);

            //// Eleman silme
            ////arrayList.Remove(10);//ArrayList içerisindeki 10 elemanını siler
            ////arrayList.RemoveAt(1);//ArrayList içerisindeki 1. indexteki elemanı siler.
            //arrayList.RemoveRange(3, 3);//ArrayList içerisindeki 3. indexte bulunan elemandan dahil 3 eleman siler.
            ////dolaşma
            //foreach (var e in arrayList)
            //{
            //    Console.Write($"{e} ");
            //}// Output: BTK Akademi e 23 44 55
        }

        private static void Ornek15()
        {
            // random bir dizi boyutu seçerek dizi elemanlarını otomatik atatmak
            //Console.WriteLine("Dizi boyutunu giriniz: ");
            //int boyut = Convert.ToInt32(Console.ReadLine());
            //int[] sayilar = new int[boyut];
            //var r = new Random();
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    sayilar[i] = r.Next(1, 10);
            //}

            //foreach (int s in sayilar)
            //{
            //    Console.WriteLine($"{s,5} {s * s,5}");
            //}

            //Çok boyutlu dizi örneği
            //double[,] matris = new double[,] { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } };

            //double toplam = 0;

            //for (int i = 0; i < matris.GetLength(0); i++)// GetLength() fonksiyonu çok boyutlu dizilerin boyutlarını almak için kullanılır.
            //{
            //    for (int j = 0; j < matris.GetLength(1); j++)
            //    {
            //        if (i == j)
            //        {
            //            matris[i, j] = -1;
            //        }
            //        else if (matris[i, j] % 2 == 0)
            //        {
            //            matris[i, j] = 0;
            //        }
            //        toplam += matris[i, j];
            //        Console.WriteLine($"{matris[i, j],5}");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine($"Toplam: {toplam}");
        }

        private static void Ornek14()
        {
            ////tanımlama & başlatma & atama
            ////int[] numaralar = new int[3] { 3, 5, 7 };
            //int[] numaralar = new int[] { 3, 5, 7, 8, 10 }; // bir sınır belirtilmediği için bu dizi dinamiktir.


            //for (int i = 0; i < numaralar.Length; i++)
            //{
            //    Console.WriteLine($"numaralar[{i}] = " + $"{numaralar[i]}");
            //}
        }

        private static void Ornek13()
        {
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());

            //for (int i = a; i <= b; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        continue;// 3 ve 3ün katlarını aldığı anda i'nin değerini 1 arttırır.
            //    }
            //    else if (i == 100)
            //        break;
            //    Console.Write("{0,3}", i);
            //}

            //for (int i = 100; i >= 0; i -= 5)
            //{
            //    Console.WriteLine(i);
            //}

            //int n = 5;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(" * ");
            //    }
            //    Console.WriteLine();
            //}

            //int n = 5;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(" {0},{1} ", i, j);
            //    }
            //    Console.WriteLine();
            //}

            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write(" * ");
            //    }
            //    Console.WriteLine();
            //}
        }

        private static void Ornek12()
        {
            //// do - while // do koşula bakmaksızın 1 kez kesin çalışır.
            //Console.WriteLine("Bir sayi giriniz: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int i = 2;
            //do
            //{
            //    Console.WriteLine("{0,3}", i);


            //    i += 2;
            //} while (i <= n);
        }

        private static void Ornek11()
        {
            //// while - 1
            //int i = 0;
            //int sayac = 0;
            //while (i < 10)
            //{
            //    sayac++;
            //    Console.WriteLine($"{i + 1}. Döngü Bloğu ve sayaç: {sayac}");
            //    i++;
            //}
            //Console.WriteLine("Döngü sonu");

            //// while - 2
            //int sayac = 1;
            //while (sayac <= 10)
            //{
            //    Console.WriteLine(sayac);
            //    Console.Write(sayac + "\t "); // sayıları yanyana yazar
            //    Console.Write("{0,5}\t", sayac); // sayıları aynı satırda aralarında 4(5-1) boşluk olacak şekilde yazar
            //    Console.Write("{0,5}", sayac); // 5 sayıları sağa hizalı, -5 sayıları sola hizalı şekilde yerleştirir.
            //    Console.WriteLine("{0,5}   {1,-3}", sayac, sayac * sayac); // sayilarin yanına karelerini yazar.
            //    sayac++;
            //}

            //// while - 3
            //int sayac2 = 10;
            //while (sayac2 > 0)
            //{
            //    Console.WriteLine(sayac2);
            //    Console.Write(sayac2 + " "); // sayıları yanyana yazar
            //    Console.Write("{0,5}", sayac2); // sayıları aynı satırda aralarında 4(5-1) boşluk olacak şekilde yazar
            //    Console.Write("{0,-5}", sayac2); // 5 sayıları sağa hizalı, -5 sayıları sola hizalı şekilde yerleştirir.
            //    Console.WriteLine("{0,-3}   {1,-3}", sayac2, sayac2 * sayac2); // sayilarin yanına karelerini yazar.
            //    sayac2 -= 1;
            //}
        }

        private static void Ornek10()
        {
            //    enum Islemler //enum yapısını Main fonksiyonun üzerine yazılmalı. Main içine yazılırsa hata verir.
            //{
            //    Toplama = 1,
            //    Cikarma = 2,
            //    Carpma = 3,
            //    Bolme = 4,
            //    Mod = 5
            //}
            //int A = 10, B = 20;
            //Islemler secim = (Islemler)(new Random().Next(1, 5));

            //switch (secim)
            //{
            //    case Islemler.Toplama:
            //        Console.WriteLine($"{A} + {B} = {A + B}");
            //        break;
            //    case Islemler.Cikarma:
            //        Console.WriteLine($"{A} - {B} = {A - B}");
            //        break;
            //    case Islemler.Carpma:
            //        Console.WriteLine($"{A} * {B} = {A * B}");
            //        break;
            //    case Islemler.Bolme:
            //        Console.WriteLine($"{A} / {B} = {A / B}");
            //        break;
            //    case Islemler.Mod:
            //        Console.WriteLine($"{A} % {B} = {A % B}");
            //        break;
            //    default:
            //        Console.WriteLine("\a Geçersiz işlem!");
            //        break;
            //}
        }

        private static void Ornek9()
        {
            ////tek-mi? çift-mi?
            //Console.WriteLine("Bir sayi giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine($"{sayi} Cift sayidir!");
            //}
            //else
            //{
            //    Console.WriteLine($"{sayi} tek sayidir!");
            //}

            ////Mutlak değer
            //int n = Convert.ToInt32(Console.ReadLine());
            //if (n < 0)
            //{
            //    Console.WriteLine($"|{n}| = {n * -1}");
            //}
            //else
            //{
            //    Console.WriteLine($"|{n}| = {n}");
            //}

            //// Karakter
            //var k = (char)Console.Read(); // Console.Read() sayısal değer alır(int), character in ASCII değeri alır.

            //if (char.IsDigit(k))
            //{
            //    Console.WriteLine("Rakamdır!");
            //}
            //else if (char.IsLower(k))
            //{
            //    Console.WriteLine("Kucuk Karakter.");
            //}
            //else if (char.IsUpper(k))
            //{
            //    Console.WriteLine("Büyük karakter");
            //}
            //else
            //{
            //    Console.WriteLine("Bilinmeyen karakter");
            //}
        }

        private static void Ornek8()
        {
            //int A = 20, B = 10;

            ////Aritmetik Operatörler
            //Console.WriteLine(A + B);
            //Console.WriteLine(A - B);
            //Console.WriteLine(A * B);
            //Console.WriteLine(A / B);
            //Console.WriteLine(A % B);

            ////ilişkisel Operatörler
            //Console.WriteLine(A > B);
            //Console.WriteLine(A < B);
            //Console.WriteLine(A >= B);
            //Console.WriteLine(A <= B);
            //Console.WriteLine(A == B);
            //Console.WriteLine(A != B);

            ////Koşul Operatörleri
            //Console.WriteLine(!(A > B && A < 5));
            //Console.WriteLine(A < B || A > 5);
        }

        private static void Ornek7()
        {
            //var metin = " Merhaba programlama dünyası. ";
            //Console.WriteLine(metin);
            //Console.WriteLine(metin.Length);
            //Console.WriteLine(metin.ToUpper());
            //Console.WriteLine(metin.ToLower());
            //Console.WriteLine(metin.TrimStart());
            //Console.WriteLine(metin.TrimEnd());
            //Console.WriteLine(metin.Trim());
            //Console.WriteLine(metin[0]);
            //Console.WriteLine(metin[1]);
            //Console.WriteLine(metin[metin.Length - 1]);
        }

        private static void Ornek6()
        {
            ////örtülü değişken tanımı
            //var ifade = Console.ReadLine(); // ReadLine in türü stringtir.

            //var ifade2 = Console.ReadKey();
            ////var ifade = Console.ReadKey(); // ReadKey in türü ConsoleKeyInfo'dur.

            //Console.WriteLine(ifade2.Key);
            //Console.WriteLine(ifade2.KeyChar);
            //Console.WriteLine(ifade.Key);       //hata verir
            //Console.WriteLine(ifade.KeyChar);   //hata verir
        }

        private static void Ornek5()
        {
            //string ifade = "\nBTK \nAkademi \nProgramlama \nOgreniyorum."; //newLine
            //Console.WriteLine(ifade);
            //string ifade2 = "\tBTK \tAkademi \tProgramlama \tOgreniyorum."; // Tab
            //Console.WriteLine(ifade2);
            //string ifade3 = "\aBTK \aAkademi \aProgramlama \aOgreniyorum."; // Alert
            //Console.WriteLine(ifade3);
            //string ifade4 = "C:\\user\\tasan"; // yada ifade = @"C:\user\tasan";
            //Console.WriteLine(ifade4);
        }

        private static void Ornek4()
        {
            //int sayi = 2;
            //Console.WriteLine(sayi);
            //Console.WriteLine(sayi + 2);
            //Console.WriteLine(sayi * sayi);
            //Console.WriteLine(sayi - 5);
        }

        private static void Ornek3()
        {
            //string isim = "Ahmet";
            //Console.WriteLine("Merhaba " + isim + ".");
            //isim = "Mehmet";
            //Console.WriteLine("Merhaba Sayin " + isim + ".");
        }

        private static void Ornek2()
        {
            //int sayi1;
            //double pi = 3.14;
            //char secim = 'e';
            //string isim = "taha";
            //bool dogruMu = false;
        }

        private static void Ornek1()
        {
            //var x = 2.5;
            //var y = 3.2;
            //var z = x + y;
            //Console.WriteLine(z);
            //Console.WriteLine(z.GetType());
        }
    }
}
