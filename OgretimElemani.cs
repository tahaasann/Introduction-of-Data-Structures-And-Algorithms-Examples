namespace _001_CSharp_İntro
{
    public class OgretimElemani
    {
        public int SicilNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }
        
        //Default Constructor - herhangi bir parametresi yoktur. Sonradan istenirse parametre eklenebilir.
        public OgretimElemani()
        {
            System.Console.WriteLine("Otomatik calisti");
        }

        public OgretimElemani(int sicilNo, string adi, string soyadi, bool cinsiyet)
        {
            SicilNo = sicilNo;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }

        public override string ToString()
        {
            return $"{SicilNo,-5}" + 
                $"{Adi,-10}" + 
                $"{Soyadi,-10}" + 
                string.Format("{0,-8}", Cinsiyet == true ? "Bay" : "Bayan");
        }
    }
}
