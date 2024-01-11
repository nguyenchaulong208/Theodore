graph1 = {
    "s": ["d","e","p"],
    "a":[],
    "b":["a"],
    "c":["a"],
    "d":["b","c","e"],
    "e":["h","r"],
    "f":["g","c"],
    "p":["q"],
    "h":["p","q"],
    "r":["f"],
    "q":[],
    "g":[],
}
graph2 = {
    "s":["h","f"],
    "f":["p"],
    "h":["k"],
    "k":["c"],
    "c":["a"],
    "a":["b"],
    "b":["d"],
    "d":["e"],
    "e":["n"],
    "n":["m"],
    "g":["g"],
    "p":["q"],
    "q":["r"],
    "r":["t"],
    "t":["g"],
    "g":[],
}
    #Test
# graph2 = {
#     "S":["A","D"],
#     "A":["B","G"],
#     "B":["C","E"],
#     "C":["G"],
#     "D":["B","E"],
#     "E":["G"],
# }
graph3 = {
    "A":["B","C"],
    "B":["A","D","C"],
    "C":["A","B","D"],
    "D":["B","C","E","F","G"],
    "E":["D","G"],
    "F":["D","G"],
    "G":["D","E","F"],
}
#DFS
def dfs(graph,start,end):
    visited = []
    stack = []
    stack.append([start])
    while stack:
        path = stack.pop()#Lấy giá trị trên đỉnh stack
        vertex = path[-1]
        if vertex == end:
            return path
        visited.append(vertex)
        for neighbour in graph.get(vertex,[]):
            if neighbour not in visited:
                new_path = list(path)
                new_path.append(neighbour)
                stack.append(new_path)
                stack.reverse()
    return "Khong tim thay duong di"
#Menu
print("Chon do thi can tim duong di:")
print("1. Do thi 1")
print("2. Do thi 2")
print("3. Do thi 3")
print("Nhap Q de thoat")
while True:
    select = input("Nhap lua chon: ")
    if select == "1":
        print ("DFS: ",dfs(graph1, "s", "g"))
    elif select == "2":
        print ("DFS: ",dfs(graph2, "s", "g"))
    elif select == "3":
        print ("DFS: ",dfs(graph3, "A", "G"))
    elif select == "Q" or select == "q":
        print("Chuong trinh ket thuc")
        break
    else:
        print("Lua chon khong hop le")
