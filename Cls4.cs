using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationProGrams
{
    class Program3
    {
        static void Main(string[] args)
        {
            Movie m = new Movie();
            m.SetMovieInfo("hello", 200, "akhil", "rashmika");
            m.GetMoiveInfo();
        }
    }
}
