using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Helper
    {
        public string Ellipsis(string input, int len) 
        {
            //return "He...";
            return len > 5 ? "He..." : "Hel..";
        }
    }
}
