namespace Entrega1
{
    public class AdaptadorTDT : Aparato
    {
        public AdaptadorTDT(int noSerie, string modelo, float precioReperacion, int maxGrab) : base(noSerie, modelo, precioReperacion)
        {
            this.maxGrab = maxGrab;
            this.precioReparacion = 5;
            this.type = "TDT";
            this.extra = maxGrab.ToString();
        }

        public int maxGrab
        {
            get { return maxGrab; }
            set { maxGrab = value; }
        }

        public override string ToString()
        {
            return "T_Adaptador - " + base.ToString();
        }
    }
}