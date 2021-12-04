using System;

namespace Class_Metot_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();
            Musteri musteri3 = new Musteri();

            musteri1.Id = 123456;
            musteri1.TCNO = "123456789";
            musteri1.Name = "Habibe";
            musteri1.Surname = "Eraslan";
            musteri1.Age = 26;
            musteri1.Job = "Computer Engineer";

            musteri2.Id = 654321;
            musteri2.TCNO = "987654321";
            musteri2.Name = "Yaşar";
            musteri2.Surname = "Eraslan";
            musteri2.Age = 23;
            musteri2.Job = "Civil Engineer";

            musteri3.Id = 135246;
            musteri3.TCNO = "123456780";
            musteri3.Name = "Üveyis";
            musteri3.Surname = "Eraslan";
            musteri3.Age = 22;
            musteri3.Job = "Student";
            

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.add(musteri1);
            musteriManager.add(musteri2);
            musteriManager.add(musteri3);

            Console.WriteLine("****************");

            musteriManager.list(musteriler);

            Console.WriteLine("****************");

            musteriManager.delete(musteri1);
            musteriManager.delete(musteri2);
            musteriManager.delete(musteri3);



        }
    }
}
