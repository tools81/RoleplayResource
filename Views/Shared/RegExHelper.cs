using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Views.Shared
{
    public static class RegExHelper
    {
        public static string Wordwrap(string text, int limit)
        {
            Regex rgx = new Regex("(.{" + limit + "}\\s)");
            return rgx.Replace(text.Replace("/line", Environment.NewLine), "$1\n");
        }
    }
}
