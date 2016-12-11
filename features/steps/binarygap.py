class BinaryGap:

    def __init__(self, n):
        self.n = n

    def convert_to_binary(self, number):
        number = int(number)
        return bin(number)

    def get_binary_gap(self):
        binary = str(self.convert_to_binary(self.n))
        max_count = 0
        current = 0
        for i in binary:
            if i == '0':
                current += 1
            if i == '1':
                max_count = max(max_count, current)
                current = 0
        return max_count
