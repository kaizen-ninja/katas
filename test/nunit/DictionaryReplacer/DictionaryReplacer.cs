using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Katas.DictionaryReplacer
{
    public class DictionaryReplacer
    {
        public string RunDictionaryReplacer(string text, Dictionary<string, string> dict)
        {
            string pattern = @"\$([^\$]*)\$";
            var matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                text = text.Replace(match.Value, dict[match.Value.Trim('$')]);
            }

            return text;
        }
    }
}
