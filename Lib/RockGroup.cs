using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    internal class RockGroup : MusicGroup
    {
        private int Stars { get; set; }

        public override string Practice()
        {
            return "play in home";
        }

        public string SaySomething(string a, string b, string c)
        {
            return a + " " + b + " "+ c;
        }
    }
}
