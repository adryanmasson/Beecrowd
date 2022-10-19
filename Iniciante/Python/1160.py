T = int(input())

for i in range(0,T):
    PA, PB, G1, G2 = input().split()
    
    PA = int(PA)
    PB = int(PB)
    G1 = float(G1)/100
    G2 = float(G2)/100
    
    ano = 0
    
    while PA <= PB:
        PA += int(PA*G1)
        PB += int(PB*G2)
        ano += 1
        if ano > 100:
            print("Mais de 1 seculo.")
            break
    if ano <= 100:
        print("{} anos.".format(ano))