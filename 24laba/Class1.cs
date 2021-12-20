using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24laba
{
    class Thermometr
    {
        public delegate void d();
        public event d tChanged;

        private double t;
        public Thermometr()
        {
            t = 0;
        }
        public double t_
        {
            get
            {
                return t;
            }
            set
            {
                t = value;
                if (tChanged != null)
                
                   tChanged();
                
                    
            }
        }
    }



}
