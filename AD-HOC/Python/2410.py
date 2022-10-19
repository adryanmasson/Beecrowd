N = int(input())

lista = set()

for i in range(0 , N):
    num = int(input())
    if num not in lista:
        lista.add(num)
        
print(len(lista))