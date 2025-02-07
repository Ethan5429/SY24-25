using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VM
{
    internal class CoinSlots
    {
        private double m_Total;
        public void insert(string coin)
        {
            if (coin == "quarter"){m_Total += .25;}
            if (coin == "dime") { m_Total += .10; }
            if (coin == "nickel") { m_Total += .05; }
            if (coin == "dollar") { m_Total += 1; }
        }

        public void coinReturn()
        {
            m_Total = 0;
        }

        public double total()
        {
            return m_Total;
        }

    }
}
