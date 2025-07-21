using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Horarios_onibus
    {
        public string Id { get; set; } = string.Empty;
        public  string origem { get; set; }  
        public string destino { get; set; }
        public bool seg { get; set; }
        public bool ter { get; set; }
        public bool qua { get; set; }
        public bool qui { get; set; }
        public bool sex { get; set; }
        public bool sab { get; set; }
        public bool dom { get; set; }
        public bool feriado { get; set; }
        public TimeSpan horario { get; set; }
    }
}
