using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Metot_Demo
{
    class MusteriManager
    {
        public void add(Musteri musteri)
        {
            Console.WriteLine("Tebrikler müşteri eklendi:" + musteri.Name +" "+musteri.Surname);
        }
        public void list(Musteri[] musteriler)
        {
            foreach(var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Id: " + musteri.Id);
                Console.WriteLine("Müşteri Tc Kimlik No: " + musteri.TCNO);
                Console.WriteLine("Müşteri Adı: " + musteri.Name);
                Console.WriteLine("Müşteri Soyadı: " + musteri.Surname);
                Console.WriteLine("Müşteri Yaşı: " + musteri.Age);
                Console.WriteLine("Müşteri Mesleği: " + musteri.Job);
                Console.WriteLine("-------------------------------");
            }
        }
        public void delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.Surname + " isimli müşteri silindi.");
        }
    }
}
