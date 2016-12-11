class BearAndSteadyGene:
    def __init__(self, n, base_gene):
        self.n = n
        self.base_gene = base_gene
        if not n % 4 == 0:
            raise NameError('bad_n')

    def calc_count_of_repetitions(self, cortege):
        result = [0, 0, 0, 0]
        for i in cortege:
            if i == 'A':
                result[0] += 1
            elif i == 'C':
                result[1] += 1
            elif i=='G':
                result[2] += 1
            elif i=='T':
                result[3] += 1
            else:
                raise NameError("bad_gene")
        return result

    def get_excess_elements(self,cortege):
        newcort = []
        norm = self.n / 4
        for i in cortege:
            if i > norm:
                newcort.append(i - norm)
            else:
                newcort.append(0)
        return newcort

    def contains_cortege(self, big, small):
        i = 0
        while i < 4:
            if small[i] > big[i]:
                return False
            i += 1
        return True

    def get_minimal_substring_length(self):
        base_cortege = self.calc_count_of_repetitions(self.base_gene)
        excess = self.get_excess_elements(base_cortege)
        i = int(self.get_sum(excess))
        if i == 0:
            return 0
        while True:
            j = 0
            if self.contains_cortege(
                    self.calc_count_of_repetitions(self.base_gene[j:j+i]),
                    excess):
                return i
            j += 1
            if j + i == self.n:
                j = 0
                i += 1
            if i == self.n -1:
                raise NameError("Fatal error")

    def get_sum(self,array):
        summa=0
        for i in array:
            summa += i
        return summa
