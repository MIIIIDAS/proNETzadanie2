using System;

class Samochod
{
    private string marka;
    private string model;
    private int iloscDrzwi;
    private int pojemnoscSilnika;
    private double srednieSpalanie;

    public Samochod(string marka_, string model_, int iloscDrzwi_, int pojemnoscSilnika_, double srednieSpalanie_)
    {
        marka = marka_;
        model = model_;
        iloscDrzwi = iloscDrzwi_;
        pojemnoscSilnika = pojemnoscSilnika_;
        srednieSpalanie = srednieSpalanie_;
    }

    public void WypiszInfo()
    {
        Console.WriteLine("Marka: " + marka);
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Ilość drzwi: " + iloscDrzwi);
        Console.WriteLine("Pojemność silnika: " + pojemnoscSilnika);
        Console.WriteLine("Średnie spalanie: " + srednieSpalanie + "\n");
    }
}

class Garaz
{
    private string adres;
    private int pojemnosc;
    private int liczbaSamochodow = 0;
    private Samochod[] samochody;

    public string Adres
    {
        get { return adres; }
        set { adres = value; }
    }

    public int Pojemnosc
    {
        get { return pojemnosc; }
        set
        {
            pojemnosc = value;
            samochody = new Samochod[pojemnosc];
        }
    }

    public Garaz()
    {
        adres = "nieznany";
        pojemnosc = 0;
    }

    public Garaz(string adres_, int pojemnosc_)
    {
        adres = adres_;
        pojemnosc = pojemnosc_;
        samochody = new Samochod[pojemnosc];
    }

    public void WprowadzSamochod(Samochod samochod)
    {
        if (liczbaSamochodow < pojemnosc)
        {
            samochody[liczbaSamochodow] = samochod;
            liczbaSamochodow++;
        }
        else
        {
            Console.WriteLine("Garaż jest pełny, nie można dodać więcej samochodów.");
        }
    }

    public Samochod WyprowadzSamochod()
    {
        if (liczbaSamochodow > 0)
        {
            Samochod ostatniSamochod = samochody[liczbaSamochodow - 1];
            samochody[liczbaSamochodow - 1] = null;
            liczbaSamochodow--;
            return ostatniSamochod;
        }
        else
        {
            Console.WriteLine("Garaż jest pusty, nie ma samochodów do wyprowadzenia.");
            return null;
        }
    }

    public void WypiszInfo()
    {
        Console.WriteLine("\nInformacje o garażu:");
        Console.WriteLine("Adres garażu: " + adres);
        Console.WriteLine("Pojemność garażu: " + pojemnosc);
        Console.WriteLine("Liczba samochodów w garażu: " + liczbaSamochodow);
        Console.WriteLine();

        Console.WriteLine("Informacje o samochodach w garażu:");
        for (int i = 0; i < liczbaSamochodow; i++)
        {
            Console.WriteLine("Samochód " + (i + 1) + ":");
            samochody[i].WypiszInfo();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Samochod s1 = new Samochod("Fiat", "126p", 2, 650, 6.0);
        Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6);

        Garaz g1 = new Garaz();
        g1.Adres = "ul. Garażowa 1";
        g1.Pojemnosc = 1;
        g1.WprowadzSamochod(s1);
        g1.WypiszInfo();
        g1.WprowadzSamochod(s2);

        Garaz g2 = new Garaz("ul. Garażowa 2", 2);
        g2.WprowadzSamochod(s2);
        g2.WprowadzSamochod(s1);
        g2.WypiszInfo();

        g2.WyprowadzSamochod();
        g2.WypiszInfo();
        g2.WyprowadzSamochod();
        g2.WyprowadzSamochod();

        Console.ReadKey();
    }
}
