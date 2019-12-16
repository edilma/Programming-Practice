def digital_root(n):
    stringN = str(n)
    sum = 0 
    for num in stringN:
        sum = int(num) + sum
    if sum%10 !=0:
        digital_root(sum)
    return sum 

def digital_root2(n):
    if n%10 <1:
        return n
    elif n%10==1:
        return 1
    else:
        return n%10 + digital_root2(n)



def main():
    n = 4

    print (digital_root2(n))



if __name__ == "__main__":
    main()