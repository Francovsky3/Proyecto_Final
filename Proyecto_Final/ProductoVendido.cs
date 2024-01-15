using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    internal class ProductoVendido
    {
        private int _Id;
        private int _IdProducto;
        private int _Stock;
        private int _IdVenta;

        public ProductoVendido()
        {

        }

        public ProductoVendido(int id, int idProducto, int stock, int idVenta)
        {
            this._Id = id;
            this._IdProducto = idProducto;
            this._Stock = stock;
            this._IdVenta = idVenta;
        }

        public int Id { get { return _Id; } set { _Id = value; } }
        public int IdProducto { get { return _IdProducto; } set { _IdProducto = value; } }
        public int Stock { get { return _Stock; } set { _Stock = value; } }
        public int IdVenta { get { return _IdVenta; } set { _IdVenta = value; } }
    }
}
