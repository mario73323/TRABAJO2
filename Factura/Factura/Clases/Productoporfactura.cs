using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura.Clases
{
    public class Productoporfactura
    {
        public Productoporfactura(int cantidad, float precio, List<producto> listaproducto, factura factura)
        {
            Cantidad = cantidad;
            Precio = precio;
            Listaproducto = listaproducto;
            Factura = factura;
        }
        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        private float precio;

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private float total;

        public float Total
        {
            get { return Cantidad*Precio; }
        }


        private List<producto> listaproducto;

        public List<producto> Listaproducto
        {
            get { return listaproducto; }
            set { listaproducto = value; }
        }

        private factura factura;

     

        public  factura Factura
        {
            get { return factura; }
            set { factura = value; }
        }

    }
}
