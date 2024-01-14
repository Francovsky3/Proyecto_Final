using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    public class Usuario
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _nombreUsuario;
        private string _contraseña;
        private string _mail;

        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contraseña, string mail)
        {
            this._id = id;
            this._nombre = nombre;
            this._apellido = apellido;
            this._nombreUsuario = nombreUsuario;
            this._contraseña = contraseña;
            this._mail = mail;
        }

        public int id { get { return _id; } set { _id = value; } }
        public string nombre { get { return _nombre; } set { _nombre = value; } }
        public string apellido { get { return _apellido; } set { _apellido = value; } }
        public string nombreUsuario { get { return _nombreUsuario; } set { _nombreUsuario = value; } }
        public string contraseña { get { return _contraseña; } set { _contraseña = value; } }
        public string mail { get { return _mail; } set { _mail = value; } }
    }
}
