using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCircular
{
    class Base
    {
        public string nombre { get { return _nombre; } }
        private string _nombre { get; }
        public int minutos { get { return _minutos; } }
        private int _minutos { get; }
        public Base siguienteBase { get; set; }

        public Base(string nombre, int minutos)
        {
            this._nombre = nombre;
            this._minutos = minutos;
            siguienteBase = null;
        }

        public override string ToString()
        {
            string contenidoBase = "";
            contenidoBase = "Nombre: " + nombre + Environment.NewLine + "Minutos para llegar " + minutos;
            return contenidoBase;
        }
    }
}
