#Do thi 1

#BFS
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
graph3 = {
    "A":["B","C"],
    "B":["A","D","C"],
    "C":["A","B","D"],
    "D":["B","C","E","F","G"],
    "E":["D","G"],
    "F":["D","G"],
    "G":["D","E","F"],
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
def bfs(graph, start, end):
#Tao queue va mang luu cac dinh da duyet
    visited = [] # mang luu cac dinh da duyet
    queue = [] # hang doi
   #lay dinh dau tien vao queue
    queue.append([start])
    
    while queue:
    # lay dinh dau tien trong queue
        #Path luu tru duong di tu dinh dau tien den dinh cuoi cung
        path = queue.pop(0) #Lay gia tri o day queue
   
    # lay dinh cuoi cung trong path
        vertex = path[-1]
   # kiem tra xem dinh cuoi cung co phai la dinh can tim
        if vertex == end:
            return path
        visited.append(vertex)
  
        for neighbour in graph.get(vertex, []):
            if neighbour not in visited:
                new_path = list(path)
                new_path.append(neighbour)
                queue.append(new_path)
    
    return "Khong tim thay duong di"
print("Chon do thi can tim duong di:")
print("1. Do thi 1")
print("2. Do thi 2")
print("3. Do thi 3")
print("Nhap Q de thoat")

#Menu chon do thi
while True:
    select = input("Nhap lua chon: ")
    
    if select == "1":
        print ("BFS: ",bfs(graph1, "s", "g"))
    elif select ==2:
        print ("BFS: ",bfs(graph1, "s", "g"))
    elif select == "3":
        print ("BFS: ",bfs(graph3, "A", "G"))
    elif select == "q" or select == "Q":
        break
    else:
        print("Nhap sai, vui long nhap lai")
        continue

    




