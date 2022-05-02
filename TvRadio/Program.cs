using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvRadio
{
    class Program
    {
        static void Main(string[] args)
        {
            Pult p = new Pult(true);
            p.ChangeVolume();
            p.ChangeVolume();
            p.ChangeVolume();
            p.ChangeChanel();
            p.ChangeChanel();
            Console.WriteLine(p);
            p.ChangePult();
            Console.WriteLine(p);
        }
    }
}
