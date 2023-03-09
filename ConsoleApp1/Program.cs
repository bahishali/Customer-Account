//Console.WriteLine("Hello, World!");


class Program1
{
    public static void Main()
    {
        Musteri m1=new Musteri();
        m1.MusteriNo = 1;
        m1.Ad = "Hasan";
        m1.Soyad = "Demir";
        m1.Bakiye = 100;

        Musteri m2 = new Musteri();
        m2.MusteriNo = 1;
        m2.Ad = "Ayşe";
        m2.Soyad = "Fidan";
        m2.Bakiye = 200;

        Console.WriteLine(m1);
        Console.WriteLine(m1.IndirimYap(50));
        Console.WriteLine(m2);
        Console.WriteLine(m2.IndirimYap(60));

        int j = 5;//Int16  veya Int32 veya Int64 i=5;
        if (j == 5)
        {
            Console.WriteLine("Eşit");

        }
        else {
            Console.WriteLine("Eşit Değil");
        }
        for (int i = 0; i < j; i++) //i=i+2
        {
            Console.WriteLine(i);
        }

    } //End Main
}


