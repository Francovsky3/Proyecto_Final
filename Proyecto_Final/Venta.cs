﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    internal class Venta
    {
        private int _id;
        private string _comentarios;
        private int _idUsuario;

        public Venta()
        {

        }

        public Venta(int id, string comentarios, int idusuario)
        {
            this._id = id;
            this._comentarios = comentarios;
            this._idUsuario = idusuario;
        }

        public int id { get { return _id; } set { _id = value; } }
        public string comentarios { get { return _comentarios; } set { _comentarios = value; } }
        public int idUsuario { get { return _idUsuario; } set { _idUsuario = value; } }
    }
}
