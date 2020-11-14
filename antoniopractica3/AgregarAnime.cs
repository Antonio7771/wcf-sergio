using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace antoniopractica3
{
    public class AgregarAnime
    {
        public Animes registrar() {
            Animes anime = new Animes();
            anime.id_anime = 0;
            anime.nombre_anime = "to aru majutsu no index";
            anime.total_capitulos_anime = 12;
            anime.des_anime = "una escuela especial...";
            return anime;
        }
        public int devolver_entero() {
            return 23;
        }
        public Animes manual_datos(Animes anime) {
            return anime;
        }
    }
}