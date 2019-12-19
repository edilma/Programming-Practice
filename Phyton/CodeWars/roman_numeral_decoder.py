
def solution(roman):
    roman_values={"I":1 ,"V":5, "X":10, "L":50, "C":100 ,"D":500 ,"M":1000}
    letterRoman= list (roman)
    total=0
    values=[]
    #Create a list with the values instead of the letters
    for i in range ( 0,len(letterRoman)):
        if letterRoman[i] in roman_values:
            valueLetter=roman_values[letterRoman[i]]
            values.append(valueLetter)
    size = (len(values))
    for i in range(0,size):
        if i==size-1:
            total = total+ values[i]
        else:
            if values[i]>=values[i+1]:
                total= total+ values[i]
                #print(total)
            else:
                total= total- values[i]
    return total

def solutione(romano):
    d={'I':1, 'V':5 ,'X':10, 'L':50 ,'C':100, 'D':500,'M':1000}
    total = 0
    for i in range ( 0,len(romano)-1):
        x= romano[i]
        y= romano[i+1]
        print (x,y)
        total = lambda x,y: x+y if x>=y else x-y 
    return total

    #return reduce(lambda x,y: x+y if x>=y else y-x , (d[c] for c in roman))

def main():
    roman = "MDCLXVI"
    romano = "MDCLXVI"
  
    print (solution(roman))
    #print (solutione(romano))
if __name__ == "__main__":
    main()