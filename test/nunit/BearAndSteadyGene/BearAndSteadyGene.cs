using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.BearAndSteadyGene
{
    public class BearAndSteadyGene
    {
        string ElementsOfGene = "AGCT";

        public bool FourFold(string gene)
        {
            return gene.Length % 4 == 0;
        }

        public int TheAmountOfEachGene(string gene)
        {
            {
                return gene.Length / 4;
            }
        }
        public int[] ResultCountOfEachOfGens(string gene)
        {
            int[] countOfEachOfGene = new int[ElementsOfGene.Length];
            if (FourFold(gene))
            {
                for (int i = 0; i < ElementsOfGene.Length; i++)
                {
                    int counter = 0;
                    for (int j = 0; j < gene.Length; j++)
                    {
                        if (ElementsOfGene[i] == gene[j])
                            counter++;
                    }
                    countOfEachOfGene[i] = counter;
                }
            }
            return countOfEachOfGene;
        }
        public int ReplaceableNumberOfGenes(string gene)
        {
            int counter = 0;
            for (int i = 0; i < ResultCountOfEachOfGens(gene).Length; i++)
            {
                if (ResultCountOfEachOfGens(gene)[i] > TheAmountOfEachGene(gene))
                    counter += ResultCountOfEachOfGens(gene)[i] - TheAmountOfEachGene(gene);
            }
            return counter;
        }
    }
}
