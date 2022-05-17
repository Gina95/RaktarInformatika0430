using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaktarInformatika0430.Models
{
    public class AruKeres
    {
        public string Megnevezes { get; set; }
        public string Beszallito { get; set; }
        public List<Aru> AruLista { get; set; }
        public SelectList BeszallitoLista { get; set; }
    }
}
