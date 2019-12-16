
def ips_between(start, end):
    start = str.split(start, '.')
    end = str.split(end, '.') 
    num4 = int(end[3])-int(start[3])
    num3 = int(end[2])-int(start[2])
    num2 = int(end[1])-int(start[1])
    num1 = int(end[0])-int(start[0])
    total = (num1*256*256*256 + num2*256*256 + num3*256 +num4)
    return total
    

    
    




def main():
    start = '91.173.148.39'
    end = '91.174.222.10'
    answer = ips_between(start, end)
    print (answer)

if __name__ == "__main__":
    main()