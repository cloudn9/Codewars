using System.Text;
using System.Collections.Generic;

namespace Codewars
{
    public static class DnaStrand
    {
        public static string Solution(string dna)
        {
            var _dic = new Dictionary<char, char>(){
                {'A','T'},
                {'T','A'},
                {'C','G'},
                {'G','C'},
            };

            var temp = new StringBuilder();
            for (var i = 0; i < dna.Length; i++)
            {
                _dic.TryGetValue(dna[i], out var result);
                temp.Append(result);
            }
            return temp.ToString();
        }
    }
}