using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminDashboard.Wasm.Models
{
    public class Evento
    {
        public string Id { get; set; }
        public string Inicio { get; set; }
        public string Duracion { get; set; }
        public string Ejecucion { get; set; }
        public string Estado { get; set; }
        public string Logo { get; set; }
        public string Skin { get; set; }
        public string Tema { get; set; }
        public string Texto { get; set; }
        public string[] Urls { get; set; }
        public string Machine { get; set; }
        public string User { get; set; }
        public string[] Mesas { get; set; }

    }
}
