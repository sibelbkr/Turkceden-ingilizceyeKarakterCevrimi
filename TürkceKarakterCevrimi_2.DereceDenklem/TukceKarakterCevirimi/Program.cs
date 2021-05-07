using System;

namespace TukceKarakterCevirimi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("TÜRKÇE KARAKTERLER İÇEREN BİR METİN GİRİNİZ:");
            string newstring = Convert.ToString(Console.ReadLine());

            Console.WriteLine("GİRİLEN METİN=" + newstring);


            newstring = newstring.Replace('ı', 'i');
            newstring = newstring.Replace('ç', 'c');
            newstring = newstring.Replace('ğ', 'g');
            newstring = newstring.Replace('ö', 'o');
            newstring = newstring.Replace('ş', 's');
            newstring = newstring.Replace('ü', 'u');
            newstring = newstring.Replace('Ç', 'Ç');
            newstring = newstring.Replace('Ğ', 'G');
            newstring = newstring.Replace('Ö', 'O');
            newstring = newstring.Replace('Ş', 'S');
            newstring = newstring.Replace('Ü', 'U');

            string editstring = newstring;
            Console.WriteLine("DÜZENLENEN METİN=" + editstring);

            Console.ReadKey();

        }
    }
}
