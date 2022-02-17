using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Color
    {
        protected string name_color;
        protected string hash_color;

        public string GetNameColor { get { return name_color; } }
        public string GetHashColor { get { return hash_color; } }
    }
}
