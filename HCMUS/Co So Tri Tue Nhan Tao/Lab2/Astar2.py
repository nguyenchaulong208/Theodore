from collections import deque

#2.1
class Graph:
    # example of adjacency list (or rather map)
    # adjacency_list = {
    # 'A': [('B', 1), ('C', 3), ('D', 7)],
    # 'B': [('D', 5)],
    # 'C': [('D', 12)]
    # }

    def __init__(self, adjacency_list,heuristic):
        self.adjacency_list = adjacency_list
        self.h = heuristic

    def get_neighbors(self, v):
        return self.adjacency_list[v]

    # heuristic function with equal values for all nodes


    def a_star_algorithm(self, start_node, stop_node):
        # open_list is a list of nodes which have been visited, but who's neighbors
        # haven't all been inspected, starts off with the start node
        # closed_list is a list of nodes which have been visited
        # and who's neighbors have been inspected
        open_list = set([start_node])
        closed_list = set([])

        # g contains current distances from start_node to all other nodes
        # the default value (if it's not found in the map) is +infinity
        g = {}

        g[start_node] = 0

        # parents contains an adjacency map of all nodes
        parents = {}
        parents[start_node] = start_node

        while len(open_list) > 0:
            n = None

            # find a node with the lowest value of f() - evaluation function
            for v in open_list:
                if n == None or g[v] + self.h[v] < g[n] + self.h[n]:
                    n = v
                
            if n == None:
                print('Path does not exist!')
                return None

            # if the current node is the stop_node
            # then we begin reconstructin the path from it to the start_node
            if n == stop_node:
                reconst_path = []

                while parents[n] != n:
                    reconst_path.append(n)
                    n = parents[n]

                reconst_path.append(start_node)

                reconst_path.reverse()

                print('Path found: {}'.format(reconst_path))
                return reconst_path

            # for all neighbors of the current node do
            for (m, weight) in self.get_neighbors(n):
                # if the current node isn't in both open_list and closed_list
                # add it to open_list and note n as it's parent
                if m not in open_list and m not in closed_list:
                    open_list.add(m)
                    parents[m] = n
                    g[m] = g[n] + weight

                # otherwise, check if it's quicker to first visit n, then m
                # and if it is, update parent data and g data
                # and if the node was in the closed_list, move it to open_list
                else:
                    if g[m] > g[n] + weight:
                        g[m] = g[n] + weight
                        parents[m] = n

                        if m in closed_list:
                            closed_list.remove(m)
                            open_list.add(m)

            # remove n from the open_list, and add it to closed_list
            # because all of his neighbors were inspected
            open_list.remove(n)
            closed_list.add(n)

        print('Path does not exist!')
        return None

# adjacency_list = {
#     'A': [('B', 1), ('C', 3), ('D', 7)],
#     'B': [('D', 5)],
#     'C': [('D', 12)],
#     'D': []
# }
# heuristic1 = {
#     'A': 1,
#     'B': 1,
#     'C': 1,
#     'D': 1
# }
#Do thi 1:

doThi1 ={
    'S':[("A",2),("B",1),("F",3)],
    'A':[("C",2),("D",3)],
    'B':[("D",2),("E",4)],
    'C':[("G",4)],
    'D':[("G",4)],
    'E':[],
    'F':[("G",6)],
    'G':[]
}
h1={
    'S': 6,
    'A': 4,
    'B': 5,
    'C': 2,
    'D': 2,
    'E': 8,
    'F': 4,
    'G': 0
}

# graph1 = Graph(adjacency_list,heuristic1)
# graph1.a_star_algorithm('A', 'D')
#-----------------------------------------------
#Do thi 2:
doThi02 = {
    'S': [('A', 2), ('B', 1), ('F', 3)],
    'A': [('C', 2), ('D', 3)],
    'B': [('D', 2), ('E', 4)],
    'C': [('G', 4)],
    'D': [('G', 4)],
    'E': [],
    'F': [('G', 6)],
    'G': []
}
h02 = {
    'S': 6,
    'A': 4,
    'B': 5,
    'C': 2,
    'D': 2,
    'E': 8,
    'F': 4,
    'G': 0
}

# #-----------------------------------------------
#Do thi 3:

doThi3 ={
    'A':[( "B", 1), ("C", 4)],
    'B':[("A", 1), ("C", 1), ("D", 5)],
    'C':[("A", 4), ("B", 1), ("D", 3)],
    'D':[("B", 5), ("C", 3), ("E", 8), ("F", 3), ("G", 9)],
    'E':[("D", 8), ("G", 2)],
    'F':[("D", 3), ("G", 5)],
    'G':[("D", 9), ("E", 2), ("F", 5)]
}
h2={
    'A': 9.5,
    'B': 9,
    'C': 8,
    'D': 7,
    'E': 1.5,
    'F': 4,
    'G': 0
}
h2_a={
    'A': 10,
    'B': 12,
    'C': 10,
    'D': 8,
    'E': 1,
    'F': 4.5,
    'G': 0
}

#-----------------------------------------------
#Do thi 4:

doThi4 ={
   'Arad':[("Zerind", 75), ("Sibiu", 140), ("Timisoara", 118)],
    'Zerind':[("Arad", 75), ("Oradea", 71)],
    'Oradea':[("Zerind", 71), ("Sibiu", 151)],
    'Sibiu':[("Arad", 140), ("Oradea", 151), ("Fagaras", 99), ("Rimnicu Vilcea", 80)],
    'Timisoara':[("Arad", 118), ("Lugoj", 111)],
    'Lugoj':[("Timisoara", 111), ("Mehadia", 70)],
    'Mehadia':[("Lugoj", 70), ("Dobreta", 75)],
    'Dobreta':[("Mehadia", 75), ("Craiova", 120)],
    'Craiova':[("Dobreta", 120), ("Rimnicu Vilcea", 146), ("Pitesti", 138)],
    'Rimnicu Vilcea':[("Sibiu", 80), ("Craiova", 146), ("Pitesti", 97)],
    'Fagaras':[("Sibiu", 99), ("Bucharest", 211)],
    'Pitesti':[("Rimnicu Vilcea", 97), ("Craiova", 138), ("Bucharest", 101)],
    'Bucharest':[("Fagaras", 211), ("Pitesti", 101), ("Giurgiu", 90), ("Urziceni", 85)],
    'Giurgiu':[("Bucharest", 90)],
    'Urziceni':[("Bucharest", 85), ("Hirsova", 98), ("Vaslui", 142)],
    'Hirsova':[("Urziceni", 98), ("Eforie", 86)],
    'Eforie':[("Hirsova", 86)],
    'Vaslui':[("Urziceni", 142), ("Iasi", 92)],
    'Iasi':[("Vaslui", 92), ("Neamt", 87)],
    'Neamt':[("Iasi", 87)]
}
h3={
    'Arad': 366,
    'Bucharest': 0,
    'Craiova': 160,
    'Dobreta': 242,
    'Eforie': 161,
    'Fagaras': 178,
    'Giurgiu': 77,
    'Hirsova': 151,
    'Iasi': 226,
    'Lugoj': 244,
    'Mehadia': 241,
    'Neamt': 234,
    'Oradea': 380,
    'Pitesti': 98,
    'Rimnicu Vilcea': 193,
    'Sibiu': 253,
    'Timisoara': 329,
    'Urziceni': 80,
    'Vaslui': 199,
    'Zerind': 374,
}

#chay thuat toan voi do thi 1:
print("Thuật toán A*")
print("Do thi 1 với h1:")
graph1 = Graph(doThi1,h1)
graph1.a_star_algorithm('S', 'G')
# #chay thuat toan voi do thi 2:
print("Do thi 02 với h2:")
graph2 = Graph(doThi02,h02)
graph2.a_star_algorithm('S', 'G')



#chay thuat toan voi do thi 3:
print("Do thi 3 với h1:")
graph2 = Graph(doThi3,h2)
graph2.a_star_algorithm('A', 'G')
print("Do thi 2 với h2:")
print("Do thi 3 với h2:")
graph2 = Graph(doThi3,h2_a)
graph2.a_star_algorithm('A', 'G')

#chay thuat toan voi do thi 4:
print("Do thi 4 với h1:")
graph3 = Graph(doThi4,h3)
graph3.a_star_algorithm('Arad', 'Bucharest')

#-----------------------------------------------
#2.2
#Thuat toan UCS:
class UCS:  
    def __init__(self, adjacency_list):
        self.adjacency_list = adjacency_list
    def ucs(self, start, goal):
        open_list = set([start])
        closed_list = set([])
        
        g = {}
        g[start] = 0
        parents = {}
        parents[start] = start
        while len(open_list) > 0:
            n = None
            for v in open_list:
                if n == None or g[v] < g[n]:
                    n = v
            if n == None:
                print('Path does not exist!')
                return None
            if n == goal:
                reconst_path = []
                while parents[n] != n:
                    reconst_path.append(n)
                    n = parents[n]
                reconst_path.append(start)
                reconst_path.reverse()
                print('Path found: {}'.format(reconst_path))
                return reconst_path
            for (m, weight) in self.adjacency_list[n]:
                if m not in open_list and m not in closed_list:
                    open_list.add(m)
                    parents[m] = n
                    g[m] = g[n] + weight
                else:
                    if g[m] > g[n] + weight:
                        g[m] = g[n] + weight
                        parents[m] = n
                        if m in closed_list:
                            closed_list.remove(m)
                            open_list.add(m)
            open_list.remove(n)
            closed_list.add(n)
        
   
#-----------------------------------------------
print("-----------------------------------------------\n")
print("That toan UCS")
print("Do thi 1:")
graph1 = UCS(doThi1)
print("UCS:")
print(graph1.ucs('S', 'G'))
#-----------------------------------------------
print("do thi 2:")
graph2 = UCS(doThi02)
print("UCS:")
print(graph2.ucs('S', 'G'))

#-----------------------------------------------
print("do thi 3:")
graph2 = UCS(doThi3)
print("UCS:")
print(graph2.ucs('A', 'G'))
#-----------------------------------------------
print("do thi 4:")
graph3 = UCS(doThi4)
print("UCS:")
print(graph3.ucs('Arad', 'Bucharest'))
#-----------------------------------------------

class Greedy:
    def __init__(self, adjacency_list,heuristic):
        self.adjacency_list = adjacency_list
        self.h = heuristic
    def greedy(self, start, goal):
        open_list = set([start])
        closed_list = set([])
        g = {}
        g[start] = self.h[start]
        parents = {}
        parents[start] = start
        while len(open_list) > 0:
            n = None
            for v in open_list:
                if n == None or self.h[v] < self.h[n]:
                    n = v
            if n == None:
                print('Path does not exist!')
                return None
            if n == goal:
                reconst_path = []
                while parents[n] != n:
                    reconst_path.append(n)
                    n = parents[n]
                reconst_path.append(start)
                reconst_path.reverse()
                print('Path found: {}'.format(reconst_path))
                return reconst_path
            for (m, weight) in self.adjacency_list[n]:
                if m not in open_list and m not in closed_list:
                    open_list.add(m)
                    parents[m] = n
                    g[m] = g[n] + weight
                else:
                    if g[m] > g[n] + weight:
                        g[m] = g[n] + weight
                        parents[m] = n
                        if m in closed_list:
                            closed_list.remove(m)
                            open_list.add(m)
            open_list.remove(n)
            closed_list.add(n)

         
#-----------------------------------------------
print("-----------------------------------------------\n")
print("Thuat toan Greedy")           
#Chay thuat toan Greedy voi do thi 1:
print("do thi 1:")
graph1 = Greedy(doThi1,h1)
print("Greedy:")
print(graph1.greedy('S', 'G'))
#-----------------------------------------------
#Chay thuat toan Greedy voi do thi 2:
print("do thi 2:")
graph2 = Greedy(doThi02,h02)
print("Greedy:")
print(graph2.greedy('S', 'G'))
#-----------------------------------------------
#Chay thuat toan Greedy voi do thi 3:
print("do thi 3:")
graph2 = Greedy(doThi3,h2)
print("Greedy:")
print(graph2.greedy('A', 'G'))
graph2 = Greedy(doThi3,h2_a)
print("Greedy:")
print(graph2.greedy('A', 'G'))
#-----------------------------------------------
#Chay thuat toan Greedy voi do thi 4:
print("do thi 4:")
graph3 = Greedy(doThi4,h3)
print("Greedy:")
print(graph3.greedy('Arad', 'Bucharest'))
#-----------------------------------------------
# print("TEST:")
# test = {
#     'S': [('A', 3), ('D', 2)],
#     'A': [('B', 5), ('G', 10)],
#     'D': [('B', 1), ('E', 4)],
#     'B': [('C', 2), ('E', 1)],
#     'E': [('G', 3)],
#     'C': [('G', 4)],
#     'G': []
# }

# print("TEST:")
# graph2 = UCS(test)
# print(graph2.ucs('S', 'G'))
#-----------------------------------------------
#Dùng  pandas tao bang chua ket qua cuar cac thuat toan:


