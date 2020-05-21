using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Контрольная_работа_2
{
    class Functions
    {
        public bool CheckAddress(string adr)
        {
            int countt = 0;
            int t_pos = -1;
            int counta = 0;
            int a_pos = -1;
            for (int i=0;i<adr.Length;i++)
            {
                if (adr[i] == '.')
                {
                    countt++;
                    t_pos = i;
                }
                if ((adr[i] == '!') || (adr[i] == '/') || (adr[i] == ',')) countt = 10;
            }
            for (int i = 0; i < adr.Length; i++)
            {
                if (adr[i] == '@')
                {
                    counta++;
                    a_pos = i;
                }
            }
            if ((countt == 1) && (counta == 1) && (a_pos < t_pos)) return true;
            else return false;
        }
    }
}
