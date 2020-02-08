
def IsAscending (number):
    ascending = False
    original = str(number)
    digits = [int(x) for x in str(number)]
    size = len(digits)
    for i in range(0,size-1 ):
        if digits[i]<=digits[i+1]:
            ascending = True
        else:
            ascending = False
            break;
    return ascending

def IsDescendent (digits):
    descending = False
    size = len(digits)
    for i in range(0, size-1 ):
        if digits[i]>=digits[i+1]:
            descending = True
        else:
            descending = False
            break;
    return descending

def MakeList(number):
    original = str(number)
    digits = [int(x) for x in str(number)]
    return digits

def AreDoubles(digitList):
    uniques = len(set(digitList))
    total = len(digitList)
    if uniques==total:
        return False # There are not doubles
    else:
        return True #there are doubles
    
def main():
    number = 9874441
    digits = MakeList(number)
    doubles = AreDoubles (digits)
    ascending = IsAscending(number)
    descending = IsDescendent(digits)

    if ascending and not doubles:
        print ( "Metadrome")
    elif ascending and doubles:
        print ( "Plaindrome")
    elif descending and not doubles:
        print ( "Katadrome")
    elif descending and doubles:
        print ( "Nialpdrome")
    else: 
        print ("Nondrome")


if __name__ == "__main__":
    main()