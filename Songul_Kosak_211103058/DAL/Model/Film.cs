using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songul_Kosak_211103058.DAL.Model
{
    public class Film
    {
        public int FilmId { get; set; }
        public string FilmAdi { get; set; }
        public string Yonetmen { get; set; }
        public string FilmTuru { get; set; }
        public string FilmSuresi { get; set; }
        public DateTime FilmVizyonTarihi { get; set; }
        public string Oyuncular { get; set; }
        public string Afis { get; set; }

    }
}
