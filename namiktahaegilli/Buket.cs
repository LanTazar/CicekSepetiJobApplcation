using System.Collections.Generic;

namespace namiktahaegilli
{
    public enum Cesit
    {
        GulBahcesi,
        GelinlikliGuller,
        OrkideBuketi
    };

    public enum Boyut
    {
        Kucuk,
        Orta,
        Buyuk
    };

    public class Buket
    {
        public int fiyat;

        public Cesit cesit;
        public Boyut boyut;
        public List<Malzemeler> GulListesi = new List<Malzemeler>();
        public List<Malzemeler> PapatyaListesi = new List<Malzemeler>();
        public List<Malzemeler> OrkideListesi = new List<Malzemeler>();
        public List<Malzemeler> SuslemelerListesi = new List<Malzemeler>();

        public Buket(Cesit c, Boyut b)
        {
            cesit = c;
            boyut = b;
            fiyat = FiyatBelirleme(cesit, boyut);
        }

        private int FiyatBelirleme(Cesit c, Boyut b)
        {
            int tempfiyat = 0; 
            if (c == Cesit.GulBahcesi)
            { 
                switch (b)
                {
                    case Boyut.Kucuk: tempfiyat = 10;
                        for (int g = 1; g <= 10; g++)
                        {
                            GulListesi.Add(new Malzemeler("Gül", true, true, true));
                        }
                        for (int p = 1; p <= 5; p++)
                        {
                            PapatyaListesi.Add(new Malzemeler("Papatya", true, false, true));
                        }
                        break;
                    case Boyut.Orta: tempfiyat = 15;
                        for (int g = 1; g <= 25; g++)
                        {
                            GulListesi.Add(new Malzemeler("Gül", true, true, true));
                        }
                        for (int p = 1; p <= 10; p++)
                        {
                            PapatyaListesi.Add(new Malzemeler("Papatya", true, false, true));
                        }
                        break;
                    case Boyut.Buyuk: tempfiyat = 20;
                        for (int g = 1; g <= 50; g++)
                        {
                            GulListesi.Add(new Malzemeler("Gül", true, true, true));
                        }
                        for (int p = 1; p <= 15; p++)
                        {
                            PapatyaListesi.Add(new Malzemeler("Papatya", true, false, true));
                        }
                        break;
                }
            }
            else if (c == Cesit.GelinlikliGuller)
            {
                switch (b)
                {
                    case Boyut.Kucuk: tempfiyat = 12;
                        for (int g = 1; g <= 5; g++)
                        {
                            GulListesi.Add(new Malzemeler("Gül", true, true, true));
                        }
                        for (int p = 1; p <= 20; p++)
                        {
                            PapatyaListesi.Add(new Malzemeler("Papatya", true, false, true));
                        }
                        for (int s = 1; s <= 5; s++)
                        {
                            SuslemelerListesi.Add(new Malzemeler("Süsleme", false, false, true));
                        }
                        break;
                    case Boyut.Orta: tempfiyat = 16;
                        for (int g = 1; g <= 7; g++)
                        {
                            GulListesi.Add(new Malzemeler("Gül", true, true, true));
                        }
                        for (int p = 1; p <= 20; p++)
                        {
                            PapatyaListesi.Add(new Malzemeler("Papatya", true, false, true));
                        }
                        for (int s = 1; s <= 10; s++)
                        {
                            SuslemelerListesi.Add(new Malzemeler("Süsleme", false, false, true));
                        }
                        break;
                    case Boyut.Buyuk: tempfiyat = 20;
                        for (int g = 1; g <= 10; g++)
                        {
                            GulListesi.Add(new Malzemeler("Gül", true, true, true));
                        }
                        for (int p = 1; p <= 20; p++)
                        {
                            PapatyaListesi.Add(new Malzemeler("Papatya", true, false, true));
                        }
                        for (int s = 1; s <= 15; s++)
                        {
                            SuslemelerListesi.Add(new Malzemeler("Süsleme", false, false, true));
                        }
                        break;
                }
            }
            else if (c == Cesit.OrkideBuketi)
            {
                switch (b)
                {
                    case Boyut.Kucuk:
                        tempfiyat = 20;
                        for (int o = 1; o <= 1; o++)
                        {
                            OrkideListesi.Add(new Malzemeler("Orkide", false, false, true));
                        }
                        break;
                    case Boyut.Orta:
                        tempfiyat = 25;
                        for (int o = 1; o <= 2; o++)
                        {
                            OrkideListesi.Add(new Malzemeler("Orkide", false, false, true));
                        }
                        break;
                    case Boyut.Buyuk:
                        tempfiyat = 30;
                        for (int o = 1; o <= 3; o++)
                        {
                            OrkideListesi.Add(new Malzemeler("Orkide", false, false, true));
                        }
                        break;
                }
            }
            return tempfiyat;
        }
    }
}
