using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace _1_1_hur_manga_versaler.Model
{
    static class TextAnalyzer
    {
        public static int GetNumberofCapitals(string text)
        {
            int uppercaseCount;

            Regex myReg = new Regex("[A-ZÅÄÖ]");
            uppercaseCount = myReg.Matches(text).Count;

            return uppercaseCount;
        }
    }
}