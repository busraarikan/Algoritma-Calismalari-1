namespace _1.Algoritma_Görevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.soru

            //bir ürüne ait fiyatı klavyeden alan ve ürünün kar oranını belirleyip
            //satış fiyatını belirleyen C# dilinde kod.
            //klavyeden alınan veriler ondalık değerde olabileceği için double değer atandı

            {
                Console.Write("Fiyatını girin:");
                double fiyat = double.Parse(Console.ReadLine());
                Console.Write("Kar oranını girin:");
                double karOranı = double.Parse(Console.ReadLine());

                double satisFiyati = fiyat + fiyat * (karOranı / 100);
                Console.WriteLine("Satış fiyatı: " + satisFiyati);


            }

            #endregion

            #region 2.soru

            //Bir dikdörtgene ait olan kenar uzunluklarını isteyip alan ve
            //çevre ve alan değerlerini döndüren C# konsol uygulaması program kodu yazıldı.
            //klavyeden alınan veriler ondalık değerde olabileceği için double değer atandı
	   
            {
                Console.WriteLine("Alanı ve çevresi hesaplanacak olan dikdörtgen için;");
                int kisakenar = int.Parse(Console.ReadLine());
                int uzunkenar = int.Parse(Console.ReadLine());
                double alan = kisakenar * uzunkenar;
                double cevre = 2 * (kisakenar + uzunkenar);
                Console.WriteLine("kisakenar: " + kisakenar);
                Console.WriteLine("uzunkenar: " + uzunkenar);
                Console.WriteLine("dikdörtgenin alanı=" + alan);
                Console.WriteLine("dikdörtgenin çevresi=" + cevre);
            }



            #endregion

            #region 3.soru

            //istenen ürün birim fiyatı ve adedi klavyeden alınacak şekilde
            //toplam tutar hesaplanarak ekrana yazdırıldı.
            //birimfiyatı ve tutar ondalık değer döndürebileceği için double veri tipinde girildi.

            {
                Console.Write("Birim fiyatı:");
                double birimFiyati = int.Parse(Console.ReadLine());
                Console.Write("Adet:");
                int adet = int.Parse(Console.ReadLine());
                double toplamTutar = birimFiyati * adet;
                Console.WriteLine("Toplam tutar:" + toplamTutar);




            }



            #endregion

            #region 4.soru

             // klavyeden alınan sayının karesini hesaplayan kod C# dilinde yazdırıldı.
             //klavyeden değerler ondalık alınabileceği için double veri tipinde giriş yapıldı.
           
            {
                Console.Write("Sayı:");
                double sayi = double.Parse(Console.ReadLine());
                double karesi = sayi * sayi;
                Console.WriteLine("Karesi:" + karesi);




            }

            #endregion

            #region 5.soru

            //klavyeden alınan sayıların iki kare farkını hesaplayan C# dilinde kod


            {
                Console.Write("X:");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Y:");
                double y = double.Parse(Console.ReadLine());
                double ikiKareFarkı = x * x - y * y;
                Console.WriteLine("X ve Y değerlerinin kareleri farkı:" + ikiKareFarkı);



            }




            #endregion

            #region 6.soru

            //klavyeden alınan a,b,c değerlerinin diskriminant değerlerini hesaplayan kod


            {
                Console.Write("a=");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b=");
                double b = double.Parse(Console.ReadLine());
                Console.Write("c=");
                double c = double.Parse(Console.ReadLine());
                double diskriminant = 2 * b - 4 * a * c ;
                Console.WriteLine("2b-4ac:" + diskriminant);



            }




            #endregion

            #region 7.soru

            //klavyeden alınan bilgiler ile yaş hesaplanarak ehliyet alma durumu if,else yapıları ile
            //konrolü sağalanarak ekrana yazdırılmıştır

            {
                Console.Write("Doğum yılı: ");
                int dogumYılı = int.Parse(Console.ReadLine());
                double yas = 2023 - dogumYılı;
                if (yas > 17)
                {
                    Console.WriteLine("Ehliyet alabilir.");
                }
                else if (yas < 17)
                {
                    Console.WriteLine("Ehliyet alamaz.");
                }



            }



            #endregion




        }
    }
}
