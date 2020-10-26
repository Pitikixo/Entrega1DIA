using System;
using System.Buffers.Text;
using System.Xml.Linq;

namespace Entrega1
{
    public class ReparacionCompleja : Reparacion
    {
        public ReparacionCompleja(Aparato aparato, int duracion) : base(aparato, duracion)
        {
            _coste = CalcularCoste();
            //Console.WriteLine(_coste);
        }
        public ReparacionCompleja() : base()
        {
        }
        
        private float CalcularCoste()
        {
            //Console.WriteLine(aparato.PrecioReparacion + " " + duracion + " " + (10+((float)(aparato.PrecioReparacion * 1.25) * (duracion))));
            float f = 10 + ((float)(aparato.PrecioReparacion * 1.25) * (duracion));
            return f;
        }

        public float Coste
        {
            get { return _coste; }
            set { _coste = value; }
        }
        
        public override string ToString()
        {
            return "Reparacion compleja-" + base.ToString() + "|| TOTAL:" + _coste;
        }
        
        public  XElement SaveToXml()
        {
            var raizReparacion = new XElement("Reparacion");

            raizReparacion.Add( new XElement("type", "Compleja"),
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