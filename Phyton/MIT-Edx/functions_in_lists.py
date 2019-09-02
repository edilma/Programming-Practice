
def square(a):
    return a*a

def halve(a):
    return a/2

def inc(a):
    return a+1



def applyEachTo(L, x):
    result = []
    for i in range(len(L)):
        result.append(L[i](x))
    return result

print ('ejercicio 1  ', applyEachTo([inc, square, halve, abs], -3) )

print ('ejercicio 2   ', applyEachTo([inc, square, halve, abs], -3) )

print ('ejercicio 3  ', applyEachTo([inc, square, halve, abs], -3) )
