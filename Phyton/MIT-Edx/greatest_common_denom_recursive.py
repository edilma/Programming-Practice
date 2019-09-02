def gcdRecur(a, b):
    '''
    a, b: positive integers
    
    returns: a positive integer, the greatest common divisor of a & b.
    
    '''
    #greater_demominador=1
    if b==0:
        return a
    else:
        return gcdRecur(b, a%b)
   
    print (gcdRecur(a, b))



print ( "the common denominator is ", gcdRecur(14,210))
    