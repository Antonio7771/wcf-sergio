using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace antoniopractica3
{
    public class Animes
    {
        int id;
        int total;
        string nombre;
        string descripcion;

        public int id_anime{
            get { return id; }
            set { id = value; }
        }
        public int total_capitulos_anime {
            get { return total; }
            set { total = value; }
        }
        public string nombre_anime {
            get { return nombre; }
            set { nombre = value; }
        }
        public string des_anime {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}