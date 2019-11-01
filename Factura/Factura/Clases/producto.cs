using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura.Clases
{
    public class producto
    {
        public producto(int codigo, string descripcion, float precio)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Precio = precio;
        }
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }

        }
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private float precio;

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
