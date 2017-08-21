using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace namiktahaegilli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GulBahcesiPrint(Buket buket0, Buket buket1, Buket buket2)
        {
            textBox1.Text = "Gül Bahçesi : " + Environment.NewLine + " Küçük Boy :" + Environment.NewLine + "  İçerik : " + buket0.GulListesi.Count + " adet gül" + " + " + "süslemeler" + Environment.NewLine + "  Fiyat : " + buket0.fiyat;
            textBox1.Text += Environment.NewLine + " Orta Boy :" + Environment.NewLine + "  İçerik : " + buket1.GulListesi.Count + " adet gül" + " + " + "süslemeler" + Environment.NewLine + "  Fiyat : " + buket1.fiyat;
            textBox1.Text += Environment.NewLine + " Büyük Boy :" + Environment.NewLine + "  İçerik : " + buket2.GulListesi.Count + " adet gül" + " + " + "süslemeler" + Environment.NewLine + "  Fiyat : " + buket2.fiyat;
        }

        private void GelinlikGullerPrint(Buket buket3, Buket buket4, Buket buket5)
        {
            textBox1.Text += Environment.NewLine + Environment.NewLine + "Gelinlikli Güller : " + Environment.NewLine + " Küçük Boy :" + Environment.NewLine + "  İçerik : " + buket3.GulListesi.Count + " adet gül" + " + " + buket3.PapatyaListesi.Count + " adet papatya" + " + " + "süslemeler" + Environment.NewLine + "  Fiyat : " + buket3.fiyat;
            textBox1.Text += Environment.NewLine + " Orta Boy :" + Environment.NewLine + "  İçerik : " + buket4.GulListesi.Count + " adet gül" + " + " + buket4.PapatyaListesi.Count + " adet papatya" + " + " + "süslemeler" + Environment.NewLine + "  Fiyat : " + buket4.fiyat;
            textBox1.Text += Environment.NewLine + " Büyük Boy :" + Environment.NewLine + "  İçerik : " + buket5.GulListesi.Count + " adet gül" + " + " + buket5.PapatyaListesi.Count + " adet papatya" + " + " + "süslemeler" + Environment.NewLine + "  Fiyat : " + buket5.fiyat;
        }

        private void OrkideBuketiPrint(Buket buket6, Buket buket7, Buket buket8)
        {
            textBox1.Text += Environment.NewLine + Environment.NewLine + "Orkide : " + Environment.NewLine + " Küçük Boy :" + Environment.NewLine + "  İçerik : " + buket6.OrkideListesi.Count + " adet orkide" + Environment.NewLine + "  Fiyat : " + buket6.fiyat;
            textBox1.Text += Environment.NewLine + " Orta Boy :" + Environment.NewLine + "  İçerik : " + buket7.OrkideListesi.Count + " adet orkide" + Environment.NewLine + "  Fiyat : " + buket7.fiyat;
            textBox1.Text += Environment.NewLine + " Büyük Boy :" + Environment.NewLine + "  İçerik : " + buket8.OrkideListesi.Count + " adet orkide" + Environment.NewLine + "  Fiyat : " + buket8.fiyat;
        }

        public List<Buket> BuketListesi = new List<Buket>();

    private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    BuketListesi.Add(new Buket((Cesit)i, (Boyut)j));
                }
            }

            GulBahcesiPrint(BuketListesi[0], BuketListesi[1], BuketListesi[2]);
            GelinlikGullerPrint(BuketListesi[3], BuketListesi[4], BuketListesi[5]);
            OrkideBuketiPrint(BuketListesi[6], BuketListesi[7], BuketListesi[8]);
        }
    }
}
