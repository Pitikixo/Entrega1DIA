namespace Entrega1
{
    public class Reproductor : Aparato
    {
        private string blueRay;
        public Reproductor(int noSerie, string modelo, float precioReperacion, string blueRay) : base(noSerie, modelo, precioReperacion)
        {
            this.extra = blueRay;
            this.precioReparacion = 10;
            this.type = "Reproductor";
            this.extra = blueRay;
        }

        public string BlueRay
        {
            get { return blueRay; }
            set { blueRay = value; }
        }

        public override string ToString()
        {
            return "T_Reproductor - " + base.ToString();
        }
        
    }
}