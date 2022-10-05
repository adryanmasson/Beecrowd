import math

pi = 3.141592654

while True:
    try:
        a, b, c = map(float, input().split())
        radiano = a*pi/180
        tanAngle = math.tan(radiano)
        treeHeight = (tanAngle * b) + c
        print("{:.2f}".format(treeHeight*5))
    except:
        break
    