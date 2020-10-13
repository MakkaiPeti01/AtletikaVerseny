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
            Egyesulet = adat[1];
            Ugras = int.Parse(adat[2]);
        }
        public string Nev()
        {
            string[] nev = sor.Split(' ');
            VezNev = nev[0];//Ez a kettő egy
            KerNev = nev[1];
        }
    }
}