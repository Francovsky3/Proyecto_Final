﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    public class Producto
    {
        private int _id;
        private string _descripcion;
        private double _costo;
        private double _precioVenta;
        private int _stock;
        private int _idUsuario;

        public Producto(int id, string descripcion, double costo, double precioVenta, int stock, int idUsuario)
        {
            this._id = id;
            this._descripcion = descripcion;
            this._costo = costo;
            this._precioVenta = precioVenta;
            this._stock = stock;
            this._idUsuario = idUsuario;
        }
        public int id { get { return _id; } set { _id = value; } }
        public string descripcion { get { return _descripcion; } set { _descripcion = value; } }
        public double costo { get { return _costo; } set { _costo = value; } }
        public double precioVenta { get { return _precioVenta; } set { _precioVenta = value; } }
        public int stock { get { return _stock; } set { _stock = value; } }
        public int idUsuario { get { return _idUsuario; } set { _idUsuario = value; } }
    }
}
