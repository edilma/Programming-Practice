def get_sum(a,b):
    if a==b:
        return a
    elif a>b:
        big=a
        small=b
    else:
        big=b
        small = a
    sum =0
    for i in range (small,big+1):
        sum = sum+i
    return sum
    

def main():
    print (get_sum(-1,2))

if __name__ == "__main__":
    main()
