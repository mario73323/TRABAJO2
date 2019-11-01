using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura.Clases
{
    public class cliente
    {
        public cliente(string identificacion, string nombre, string direccion, int telefono, List<factura> listafactura)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Listafactura = listafactura;
        }
        private string identificacion;

        public string Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }

        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private int telefono;

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        private List<factura> listafactura;

    

        public List<factura> Listafactura
        {
            get { return listafactura; }
            set { listafactura = value; }
        }

    }
}
