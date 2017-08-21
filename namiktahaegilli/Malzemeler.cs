namespace namiktahaegilli
{

    public class Malzemeler
    {
        public Malzemeler(string Adi,bool Cicekli, bool Dikenli, bool Yaprakli)
        {
            this.Adi = Adi;
            this.Cicekli = Cicekli;
            this.Dikenli = Dikenli;
            this.Yaprakli = Yaprakli;
        }
        public string Adi { get; set; }
        public bool Cicekli { get; set; }
        public bool Dikenli { get; set; }
        public bool Yaprakli { get; set; }
    }
}
