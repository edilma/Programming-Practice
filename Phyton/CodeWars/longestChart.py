def longest(word):
    newlong=0
    longestString = 1
    for i in range (0,(len(word)-1)):
        
        if (word[i+1]==word[i]):
            # print(word[i])
            longestString=longestString+1
            #print (longestString)
        else:
            if (longestString)>(newlong):
                newlong=longestString
                longestString = 1
                
    return (newlong)

def longest2(s):
    max=0
    now = 1
    for i in range (0,(len(s)-1)):
        if s[i]==s[i+1]: #or i==(len(s)-1):
            now = now+1
        else:
            if now>=max:
                max = now
                now = 1
    
    return max

def longest3(s):
    i=0
    count=1
    max=0
    while i<=(len(s)-1):
        if s[i]==s[i+1]:
            count = count +1
            i=i+1
        if count >= max:
            max= count
            count= 1
            i= i+1
    return max
            
    

def main():
    mystring="abcdefghijklmnopqrstuvwxyz"
    s ="aaa"
    #print (longest(mystring))
    #print (longest2(s))
    print (longest3(s))

if __name__ == "__main__":
    main()