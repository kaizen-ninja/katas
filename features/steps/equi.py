class Equi:
    def __init__(self, array, N):
        self.array = array
        self.N = N

    def is_equilibrium(self,number):
        i = 0
        number = int(number)
        sum = 0
        for element in self.array:
            if i < number:
                sum += int(element)
            if i > number:
                sum -= int(element)
            i += 1
        return sum == 0

    def get_equilibrium_indexes(self):
        result = []
        i = 0
        for elem in self.array:
            if self.is_equilibrium(i):
                result.append(int(i))
            i += 1
        if len(result) == 0:
            result.append(-1)
        return result
