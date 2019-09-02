def gcdIter(a, b):
    '''
    a, b: positive integers
    
    returns: a positive integer, the greatest common divisor of a & b.
    '''
    greater_demominador =1
    if a>b:
        smallest= b
        biggest = a
        original=b
    else:
        smallest= a
        biggest = b
        original = a
    
    while smallest>0:
        if (biggest%smallest==0 and original%smallest==0):
            greater_demominador = smallest
            break
        else:
            smallest=smallest-1
    print ("Greates Commun Denominator is ", greater_demominador)
    return   greater_demominador 

gcdIter(42, 48)