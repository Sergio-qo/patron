using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron
{
    class Prediccion
    {
        /*private List<int> datos = new List<int>();
        private List<List<int>> arrayDatos = new List<List<int>>();
        private int posicion = 0;
        private int prediccion = 2;
        private int longitud = 0;
        private int posicion = 0;
        private int fallos = 0;
        private int aciertos = 0;*/
        public int insertarDato(int dato)
        {
            /*datos.Add(dato);
            arrayDatos.Add(datos);
            bool mismoPatron = false;
            bool repetido = false;
            for (int i=0; i < arrayDatos.Count; i++)
            {
                for (int j=0; j < arrayDatos[i].Count; j++)
                {
                    if (datos[i] == arrayDatos[i][j])
                    {
                        mismoPatron = true;
                    }
                }
                if (mismoPatron)
                {
                    repetido = true;
                }
            }
            if (repetido)
            {
                longitud = datos.Count;
            }
            posicion++;
            //datos.Add(dato);
            prediccion = datos[datos.Count - posicion - 1];
            posicion++;
            if (prediccion == dato)
            {
                aciertos++;
            }
            else
            {
                fallos++;
            }
            if (aciertos >= datos.Count - 1)
            {
                datos.RemoveAt(datos.Count - 1);
                posicion = 0;
            }
            if (fallos > datos.Count)
            {
                datos.Clear();
                aciertos = 0;
                fallos = 0;
                posicion = 0;
            }
            posicion*/
            List<int> patronRecurrente(List<int> patron)
            {
                bool igual = true;
                List<int> respuesta = new List<int>();
                List<int> zonaActual = new List<int>();
                for(int i = 0; i < patron.Count; i++)
                {
                    respuesta = patron.GetRange(0, i);
                    for(int j = 0; i < patron.Count; j += i)
                    {
                        zonaActual = patron.GetRange(j, i);
                        for(int x = 0; i < respuesta.Count; i++)
                        {
                            if (respuesta[x] != zonaActual[x])
                            {
                                igual = false;
                                break;
                            }
                        }
                    }
                }
                if (igual)
                {
                    return respuesta;
                    //Console.WriteLine(respuesta);
                }
                else
                {
                    respuesta.Clear();
                    return respuesta;
                }
            }
            return prediccion;
        }
    }
}
