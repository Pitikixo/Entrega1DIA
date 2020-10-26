using System.Xml.Linq;

namespace Entrega1
{
    public class Aparato
    {
        private int noSerie;
        private string modelo;
        public float precioReparacion;
        public string type;
        public string extra;

        public Aparato(int noSerie, string modelo, float precioReparacion)
        {
            this.noSerie = noSerie;
            this.modelo = modelo;
            this.precioReparacion = precioReparacion;
        }
        public Aparato()
        {
        }

        public int NoSerie
        {
            get { return noSerie;  }
            set { noSerie = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public float PrecioReparacion
        {
            get { return precioReparacion; }
            set { precioReparacion = value; }
        }
        
        public string Extra
        {
            get { return extra; }
            set { extra = value; }
        }

        public override string ToString()
        {
            return "Nº: " + noSerie + "|| Modelo: " + modelo + "|| Precio/Hora: " + precioReparacion;
        }
        
    }
}