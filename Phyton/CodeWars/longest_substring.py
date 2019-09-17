def longest(word):
    #abcd ='abcdefghijklmnopqrstuvwxyz'
    maxSubstring=''
    regString =''
    size = len(word)
    for i in range(0,size-1):
        
        regString= regString + word[i]
        if word[i+1]<word[i]:
            if len(regString)>len(maxSubstring):
                maxSubstring = regString
                regString=''
                
                #print(maxSubstring,regString)
        else:
            regString=regString+word[i+1]
        #print (maxSubstring)
        #print (regString)
        if len(regString)>len(maxSubstring):
            maxSubstring = regString
            regString=''
            
            
    return maxSubstring

def longest2(word):
    longSub ='4'
    actSub = word[0]
    size =len(word)
    for i in range (0,size-1):
        #actSub = word[i]
        if word[i]<=word[i+1]:
            actSub = actSub+word[i+1]
            print (actSub)
    return longSub
    



#print (longest2('azcbobobegghakl'))
print (longest('azcbobobegghakl'))

