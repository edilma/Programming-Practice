def is_square(n):
    '''Function that tells if a number is a perfect square.  An integer is received
    I use the formula n**2 = Sumatoria (k=1 to n)of (2k-1)'''
    if n<0:
        return False 
    else:
        sum=0
        top = int(n**0.5)
        for k in range (1,top+1):
            temp = (2*k)-1
            #print (temp)
            sum = temp + sum
            #print (sum)
        if n == sum:
            return True
        else: 
            return False
def main():
    print (is_square(0))

if __name__ == "__main__":
    main()