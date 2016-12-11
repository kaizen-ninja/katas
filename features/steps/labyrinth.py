class Labyrinth:
        def __init__(self,n,array):
            self.array = array
            self.n = int(n)

        def s_e_search(self):
            i = 0
            for row in self.array:
                j = 0
                for current in row:
                    if current == 's':
                        self.s = Point(i, j)
                    elif current == 'e':
                        self.e = Point(i, j)
                    j += 1
                i += 1
            return [self.s.x, self.s.y], [self.e.x, self.e.y]

        def get_element(self, x, y):
            x = int(x)
            y = int(y)
            return self.array[x][y]

        def start(self):
            result = self.get_path(self.s,self.createUsed())
            result.insert(0,'S')
            return result

        def createUsed(self):
            i = 0
            j = 0
            used = []
            while i < int(self.n):
                buf = []
                while j < int(self.n):
                    buf.append(False)
                    j += 1
                j = 0
                i += 1
                used.append(buf)
            return used

        def get_path(self, start, used):
            path = []
            used[start.x][start.y] = True
            if self.get_element(start.x,start.y) == 'e':
                return ['E']
            changes = False
            if int(start.x+1) < self.n:
                if (self.get_element(start.x+1,start.y)=='e' or self.get_element(start.x+1,start.y)=='_')and used[int(start.x+1)][int(start.y)]==False:
                    path.append('D')
                    changes = True
                    new_path = self.get_path(Point(start.x+1, start.y), used)
                    if new_path is not None:
                        path += new_path
            if int(start.y+1) < self.n:
                if (self.get_element(start.x, start.y+1) == 'e' or self.get_element(start.x, start.y+1) == '_') and used[start.x][start.y+1]==False:
                    path.append('R')
                    changes = True
                    new_path = self.get_path(Point(start.x, start.y+1), used)
                    if new_path is not None:
                        path += new_path
            if int(start.x-1) >= 0:
                if (self.get_element(start.x-1,start.y) == 'e' or self.get_element(start.x-1,start.y)=='_') and used[start.x-1][start.y]==False:
                    path.append('U')
                    changes = True
                    new_path = self.get_path(Point(start.x-1, start.y), used)
                    if new_path is not None:
                        path += new_path
            if int(start.y-1) >= 0:
                if (self.get_element(start.x, start.y-1) == 'e' or self.get_element(start.x, start.y-1)=='_') and used[start.x][start.y-1]==False:
                    path.append('L')
                    changes = True
                    new_path = self.get_path(Point(start.x, start.y-1), used)
                    if new_path is not None:
                        path += new_path
            if not changes:
                return None
            return path




class Point:
    def __init__(self,x,y):
        self.x = int(x)
        self.y = int(y)
