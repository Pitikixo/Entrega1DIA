using System.Buffers.Text;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml.Linq;

namespace Entrega1
{
    public class Radio : Aparato
    {
        private string banda;

        public Radio(int noSerie, string modelo, float precioReparacion, string banda) : base(noSerie, modelo, precioReparacion)
        {
            this.banda = banda;
            this.precioReparacion = 5;
            this.type = "Radio";
            this.extra = (string) this.banda;
        }

        public string Banda
        {
            get { return banda; }
            set { banda = value; }
        }

        public override string ToString()
        {
            return "T_Radio - " + base.ToString();
        }
        
    }
}