using System;
using System.Xml.Linq;

namespace Entrega1
{
    public class Reparacion
    {
        public Aparato aparato;
        //duracion = num de "medias" horas
        public int duracion;
        public float _coste;

        public Reparacion(Aparato aparato, int duracion)
        {
            this.aparato = aparato;
            this.duracion = duracion;
        }
        public Reparacion()
        {
        }

        public override string ToString()
        {
            return  this.aparato.ToString() + "|| Duracion(reparacion): " + duracion ;
        }

       /* public XElement SaveToXml()
        {
            var raizReparacion = new XElement("reparacion");

            raizReparacion.Add(
                new XElement("numSer", this.aparato.NoSerie),
                new XElement("mod", this.aparato.Modelo),
                new XElement("coste", this._coste));

            return raizReparacion;
        }*/
    }
}