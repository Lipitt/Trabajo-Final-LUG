using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EE
{
    public class VentaEE
    {
        public int Id_Venta { get; set; }
        public string Marca { get; set; }
        public string Articulo { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public int Total { get; set; }
        public ClienteEE Cliente = new ClienteEE();

        public override string ToString()
        {
            if (Articulo != null)
            {
                return "Id_Venta: " + Id_Venta + " Marca: " + Marca.Trim() + " Articulo: " + Articulo.Trim() +
                " Cantidad: " + Cantidad + " Precio: " + Precio + " Total: " + Total;
            }
            else
            {
                return "Marca: " + Marca.Trim() + " Total: " + Total;
            }
        }
    }
}
