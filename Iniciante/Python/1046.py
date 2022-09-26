a,b = map(int, input().split())

if a > b:
    print("O JOGO DUROU {} HORA(S)".format(24 - a + b))
elif a == b:
    print("O JOGO DUROU 24 HORA(S)")
else:
    print("O JOGO DUROU {} HORA(S)".format(b - a))