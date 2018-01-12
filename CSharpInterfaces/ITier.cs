using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfaces
{
    interface ITier
    {
        string GibLaut { get; set; }

        int AnzahlBeine();
    }
}
