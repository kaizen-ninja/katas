using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.BearAndSteadyGene
{
    class BearAndSteadyGene
    {
        public static int getMinimumSubstring(int n, string s)
        {
            int mx = n / 4;

            int[] cnt = new int[256];

            foreach (char c in s)
            {
                cnt[c]++;
            }

            string t = "ACGT";
            bool ok = true;
            foreach (char c in t)
            {
                if (cnt[c] > mx)
                {
                    ok = false;
                }
            }

            if (ok)
                return 0;

            int r = 0;

            int ans = n;
            for (int l = 0; l < n; l++)
            {
                while (cnt['A'] > mx || cnt['C'] > mx || cnt['T'] > mx || cnt['G'] > mx)
                {
                    if (r == n)
                    {
                        return ans;
                    }

                    --cnt[s[r]];
                    ++r;
                }
                ans = Math.Min(ans, r - l);
                ++cnt[s[l]];
            }

            return ans;
        }
    }
}
