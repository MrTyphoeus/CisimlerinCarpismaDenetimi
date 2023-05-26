using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winFormNDP
{
    public class dikdortgen
    {
        Nokta3d m; int en, boy, sag, sol, ust, alt;
        public dikdortgen()
        {
            M = new Nokta3d();
            en = 0;
            boy = 0;
            sag = 0;
            sol = 0;
            ust = 0;
            alt = 0;
            

        }
        public dikdortgen(Nokta3d M, int En, int Boy)
        {
            M.Z = 0;  // iki boyutlu
            m = M;
            en = En; 
            boy = Boy;
            sag = M.X + en;
            sol = M.X;
            ust = M.Y + boy;
            alt = m.Y;



        }
        public Nokta3d M { get => m; set => m = value; }
        public int En { get => en; set => en = value; }
        public int Boy { get => boy; set => boy = value; }
        public int Sag { get => sag; set => sag = value; }
        public int Sol { get => sol; set => sol = value; }
        public int Ust { get => ust; set => ust = value; }
        public int Alt { get => alt; set => alt = value; }

    }
}
