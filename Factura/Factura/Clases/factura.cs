using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura.Clases
{
    public class factura
    {
        public factura(int numero, int fecha, cliente cliente, List<Productoporfactura> listaproductoporfactura, int descuentoingre, float subtotal)
        {
            Numero = numero;
            Fecha = fecha;
            Cliente = cliente;
            Listaproductoporfactura = listaproductoporfactura;
            Descuentoingre = descuentoingre;
            Subtotal = subtotal;
        }
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private int fecha;

        public int Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private cliente cliente;

        public cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        private List<Productoporfactura> listaproductoporfactura;

        public List<Productoporfactura> Listaproductoporfactura
        {
            get { return listaproductoporfactura; }
            set { listaproductoporfactura = value; }
        }
        private int descuentoingre;

        public int Descuentoingre
        {
            get { return descuentoingre; }
            set { descuentoingre = value; }
        }
        private float subtotal;

        public float Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }
        private float descuento;

        public float Descuento
        {
            get { return ((Subtotal*Descuentoingre)/100); }
        }
        private float subdescuento;

        public float Subdescuento
        {
            get { return  Subtotal-Descuento; }
        }

        private float iva;

        public float Iva
        {
            get { return ((Subdescuento*12)/100); }
            
        }
        private float total;

     

        public float Total
        {
            get { return Subdescuento+Iva; }
        }




    }
}
