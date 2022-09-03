using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVEPIPlan
{
    internal class PI
    {
        Dictionary<string, int> Req;
        int lvl;

        public int GetLvl() { return lvl; }
        public void SetLvl(int lvl ) { this.lvl = lvl; }

        public void Add(string name, int number)
        {
            Req.Add(name, number);
        }

        public Dictionary<string, int> GetReq()
        {
            return Req;
        }

    }
}
