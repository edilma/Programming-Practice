def applyToEach(L, f):
    for i in range(len(L)):
        L[i] = f(L[i])

def absolute(a):
    return abs(a)


def change_one(a):
    return a+1


def double(a):
    return a*a


def main():
    testList = [1, -4, 8, -9]
    applyToEach(testList, double)
    print (testList)

if __name__ == '__main__':
    main()
    