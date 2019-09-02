'''Program with a function that return sum = (n*(n+1))/2'''

def sum_to(n):
        for i in range(1,n+1):
                sum =  (n * (n + 1)) / 2
                return int(sum)


def sum_to_accum(n):
    accumulator = 0
    for i in range (n+1):
        accumulator+=i
    return accumulator




def main():
        number = 10
        print ("With Formula total is : ", (sum_to(number)))
        print ("With Accumulator total is : ", (sum_to_accum(number)))

if __name__ == "__main__":
    main()