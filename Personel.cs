namespace _001_CSharp_İntro
{
    public class Personel
    {
        public Personel(string adi, string soyadi, decimal maas)
        {
            Adi = adi;
            Soyadi = soyadi;
            Maas = maas;
        }

        public int SicilNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public decimal Maas { get; set; }

        public override string ToString()
        {
            return $"{Adi,-20} {Soyadi,-15} {Maas,-10}";
        }
    }
}
