using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    internal class DjazGroup : MusicGroup
    {
        private int Stars { get; set; }

        public override string Practice()
        {
            return "play in school";
        }

        public string SaySomething(string a, string b, string c)
        {
            return a + " " + b + " " + c;
        }
    }
}
