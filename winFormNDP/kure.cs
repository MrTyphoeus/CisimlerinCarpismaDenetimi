using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winFormNDP
{
    public class Kure
    {
        Nokta3d m;
        int r;
        public Kure()
        {
           m = new Nokta3d();
           r = 0;
        }

        public Kure(Nokta3d P, int R)
        {
            m = P;
            r = R;
        }

        public int R { get => r; set => r = value; }
        public Nokta3d M { get => m; set => m = value; }

    }
}
