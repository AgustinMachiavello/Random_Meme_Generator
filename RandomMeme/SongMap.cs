using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMeme
{
    public class SongMap
    {
        public string name = "";
        public int[] beats = null;

        public SongMap(string nm, int[] bt)
        {
            name = nm;
            beats = bt;
        }
    }
}
