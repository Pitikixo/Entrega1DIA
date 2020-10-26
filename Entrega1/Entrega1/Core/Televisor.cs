namespace Entrega1
{
    public class Televisor : Aparato
    {
        private int pulgadas;
        public Televisor(int noSerie, string modelo, float precioReperacion, int pulgadas) : base(noSerie, modelo, precioReperacion)
        {
            this.pulgadas = pulgadas;
            this.precioReparacion = 10;
            this.type = "TV";
            this.extra = pulgadas.ToString();
        }
        
        public int Pulgadas
        {
            get { return pulgadas; }
            set { pulgadas = value; }
        }

        public override string ToString()
        {
            return "T_Televisor - " + base.ToString();
        }
    }
}