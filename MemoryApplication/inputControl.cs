using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MemoryApplication
{
    class inputControl
    {
        Regex desen = new Regex("^[0-9]*$");
        String deger;

        public bool c(String deger)
        {
            this.deger = deger;
            if (desen.IsMatch(deger))
            {

                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
