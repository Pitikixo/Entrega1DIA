using System;
using System.Xml.Linq;

namespace Entrega1
{
    public class Sustitucion : Reparacion
    {
        public Sustitucion(Aparato aparato, int duracion) : base(aparato, duracion)
        {
            _coste=CalcularCoste();
        }
        public Sustitucion() : base()
        {
        }

       /* public Sustitucion(Reparacion reparacion) //: base(aparato, duracion)
        {
            CalcularCoste();
        }*/

        private float CalcularCoste()
        {
            //Console.WriteLine(aparato.PrecioReparacion + " " + duracion);
            float f = 10 + ((aparato.PrecioReparacion) * (duracion));
            return f;
            

        }
        
        public float Coste
        {
            get { return _coste; }
            set { _coste = value; }
        }
        
        public override string ToString()
        {
            return "Sustitucion-" + base.ToString() + "|| TOTAL:" + _coste;
        }
        
        
        public  XElement SaveToXml()
        {
            var raizReparacion = new XElement("Sustitucion");

            raizReparacion.Add( new XElement("type", "Sustitucion"),
                new XElement("aparato", this.aparato.type),
                new XElement("numSer", this.aparato.NoSerie),
                new XElement("mod", this.aparato.Modelo),
                new XElement("ext", this.aparato.Extra),
                new XElement("duracion", this.duracion),
                new XElement("coste", _coste));
            

            return raizReparacion;
        }
    }
}