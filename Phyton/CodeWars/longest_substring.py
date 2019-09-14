def longest(word):
    abcd ='abcdefghijklmnopqrstuvwxyz'
    maxSubstring=''
    regString=word[0]
    size = len(word)
    for i in range(0,size-1):
        if word[i+1]<word[i]:
            if len(regString)>len(maxSubstring):
                maxSubstring = regString
                regString =word[i]
                print(maxSubstring,regString)
        else:
            regString=regString+word[i+1]
        if len(regString)>len(maxSubstring):
            maxSubstring = regString
            regString =word[i]
    return maxSubstring

print (longest('azcbobobegghakl'))

