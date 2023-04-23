using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    public interface Group
    {
        string Name { get; set; }
        string PlayMusic();
        string StopMusic();
    }
}
