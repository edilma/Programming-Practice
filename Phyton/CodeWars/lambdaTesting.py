
#create a lambda expression with 2 numbers
def testingLambda(n1,n2):
    total= lambda n1,n2: n1+n2 if n1>n2 else n1*n2 
    return total(n1,n2)



def main():
    s=8
    p=5

    print (testingLambda(s,p))
    #other example
    

   
if __name__ == "__main__":
    main()

