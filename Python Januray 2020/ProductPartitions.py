'''Given a natural number n, we want to know in how many ways we may express these numbers as product of other numbers'''

def prod_int_part(n): # n the integer to be partitioned in products
    ways =0
    factors=[]
    
    while count < n/2:
        factor = 2
        if n%factor==0:
            factors.append[factor]
        count +1
    return factors


    
    #return [(1), [(2)]] # (1) - Amount of different products equals to n
                        # (2) - List of list - products that have maximum length sorted
                        # (if there is only one list, do not use two levels of braces)



def main():
    number = 18
    factors = prod_int_part(number)

    print (factors)

if __name__ == "__main__":
    main()