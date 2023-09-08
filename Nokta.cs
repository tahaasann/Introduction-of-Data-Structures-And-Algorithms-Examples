namespace _001_CSharp_İntro
{
    public struct Nokta
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"{X},{Y}";
        }
        //Default constructor
        public Nokta(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Yapımıza yeni üye -> Metot.
        public void SetOrigin()
        {
            this.X = 0;
            this.Y = 0;
        }
        public void Degistir()
        {
            var gecici = this.X;
            X = Y;
            Y = gecici;
        }

    }
}
