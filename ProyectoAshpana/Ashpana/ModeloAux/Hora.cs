using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Hora
    {
        private int h;
        private int m;
        private int s;
        


        public Hora(int h, int m, int s)
        {
            this.h = h;
            this.m = m;
            this.s = s;
        }

        public int H { get => h; set => h = value; }
        public int M { get => m; set => m = value; }
        public int S { get => s; set => s = value; }
    }
}
