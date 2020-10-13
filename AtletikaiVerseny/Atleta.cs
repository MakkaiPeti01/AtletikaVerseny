namespace AtletikaiVerseny
{
    internal class Atleta
    {
        public string Rajtszam { get; private set; }
        public string VezNev { get; private set; }
        public string KerNev { get; private set; }
        public string Egyesulet { get; private set; }
        public int Ugras { get; private set; }
        public Atleta(string sor)
        {
            string[] adat = sor.Split(';');
            Rajtszam = adat[0];
            VezNev = adat[1];//Ez a kettő egy
            KerNev = adat[2];
            Egyesulet = adat[3];
            Ugras = int.Parse(adat[4]);
        }
        public string Nev
        {
            get { return VezNev + " " + KerNev; }
        }
    }
}