using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_3_LAB_POO
{
    class traductorClase
    {
        string ingreso;
        string devolucion;
        public bool encontrar;

        public string Ingreso
        {
            get { return ingreso; }
            set { ingreso = value; }
        }

        public string Devolucion
        {
            get { return devolucion; }
            set { devolucion = value; }
        }

        public string[] ingles = { "dog", "bed", "nose", "tree", "leg",
         "water", "light", "sea", "dog", "battery"};
        public string[] español = { "perro", "cama", "nariz", "arbol", "pierna",
        "agua" , "luz", "mar", "perro", "bateria"};


        public string traduce()
        {
            encontrar = false;
            int cont = 0;

            while (cont != español.Length)
            {
                if (ingreso == español[cont])
                {
                    Devolucion = ingles[cont];
                    encontrar = true;
                }
                cont++;
            }
            return Devolucion;
        }
    }
}
