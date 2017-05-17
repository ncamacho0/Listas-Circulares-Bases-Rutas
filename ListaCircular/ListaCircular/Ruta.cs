using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCircular
{
    class Ruta
    {
        private Base inicio=null, final=null;
        int total,bandera;
        string datos = "";
        DateTime duracion = new DateTime();


        public void agregar(Base nueva)
        {
            if (inicio == null)
            {
                inicio = nueva;
                inicio.siguienteBase = inicio;
                final = inicio;
            }
            else
            {
                final.siguienteBase = nueva;
                nueva.siguienteBase = inicio;
                final = nueva;
                total++;
            }
        }

        public void agregarInicio(Base nueva)
        {
            if (inicio == null)
            {
                inicio = nueva;
                inicio.siguienteBase = inicio;
                final = inicio;
            }
            else
            {
                nueva.siguienteBase = inicio;
                inicio = nueva;
                final.siguienteBase = inicio;
            }
        }

        public Base buscar(string nombre)
        {
            bandera = 0;
            Base baseActual = inicio;
            while (bandera != total)
            {
                if (baseActual.nombre == nombre)
                    return baseActual;
                else
                    baseActual = baseActual.siguienteBase;
                bandera++;
            }
            return null;
        }

        public void insertar(string nombre, Base miBase)
        {
            bandera = 0;
            Base actual = inicio, nuevaBase = miBase, anterior = null, siguente = null;

            if (inicio == null)
                inicio = nuevaBase;
            while (bandera != total)
            {
                if (actual.nombre == nombre)
                {
                    if (actual.siguienteBase == inicio)
                        final = nuevaBase;
                    anterior = actual;
                    siguente = actual.siguienteBase;
                    anterior.siguienteBase = nuevaBase;
                    nuevaBase.siguienteBase = siguente;
                    total++;
                    break;
                }
                else
                    actual = actual.siguienteBase;
                bandera++;
            }
        }

        public void eliminarInicio()
        {
            inicio = inicio.siguienteBase;
            final.siguienteBase = inicio;
            total--;
        }

        public void eliminar(string nombre)
        {
            bandera = 0;
            Base baseActual = inicio;
            Base anterior = null;

            while (bandera != total)
            {
                if (baseActual.nombre == nombre)
                {
                    if (baseActual == inicio)
                    {
                        eliminarInicio();
                    }
                    else if (baseActual == final)
                    {
                        anterior.siguienteBase = inicio;
                        total--;
                    }
                    else
                    {
                        anterior.siguienteBase = baseActual.siguienteBase;
                        total--;
                    }

                    break;
                }
                else
                    anterior = baseActual;
                baseActual = baseActual.siguienteBase;
                bandera++;
            }
        }

        public string recorrido(string nombre, DateTime horaInicio, DateTime horaFinal)
        {
            bandera = 0;
            duracion = horaInicio;
            Base actual = inicio, actual2, inicioRuta;
            string recorrido = "";
            while (bandera != total)
            {
                if (actual.nombre == nombre)
                    break;
                else
                    actual = actual.siguienteBase;
                bandera++;
            }
            actual2 = actual.siguienteBase;
            inicioRuta = actual;
            bandera = 0;
            while (bandera != total)
            {
                recorrido += actual.nombre + "                     ";
                actual = actual.siguienteBase;
                bandera++;
            }
            recorrido += Environment.NewLine;

            while (duracion <= horaFinal)
            {
                if (actual2 == inicioRuta.siguienteBase)
                    recorrido += Environment.NewLine;
                recorrido += duracion.ToString("hh:mm") + "                 ";
                duracion = duracion.AddMinutes(actual2.minutos);
                actual2 = actual2.siguienteBase;
            }

            return recorrido;
        }

        
        public string reporte()
        {
            datos = "";
            Base actual = inicio;
            if (inicio != null)
            {
                do
                {
                    datos += actual.ToString()+ Environment.NewLine;
                    actual = actual.siguienteBase;
                } while (actual != inicio);
            }
            else
                datos = "";
            return datos;
        }

        
    }
}
