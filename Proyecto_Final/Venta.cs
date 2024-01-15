using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    internal class Venta
    {
        private int _Id;
        private string _Comentarios;
        private int _IdUsuario;

        public Venta()
        {

        }

        public Venta(int id, string comentarios, int idusuario)
        {
            this._Id = id;
            this._Comentarios = comentarios;
            this._IdUsuario = idusuario;
        }

        public int Id { get { return _Id; } set { _Id = value; } }
        public string Comentarios { get { return _Comentarios; } set { _Comentarios = value; } }
        public int IdUsuario { get { return _IdUsuario; } set { _IdUsuario = value; } }
    }
}
