


def funcionx():
    list = [1,2,3,4]
    word = 'The crow flies at midnight'
    represent = 'boom'
    newWord =''
    for ch in word:
        index = word.index(ch)%len(represent)
        if not ((ch>='a' and ch<= 'z') or  (ch>='A' and ch<='Z')):
            newWord= newWord + ch         
        else:
            newWord= newWord + represent[index]
        print (newWord)
    return  (newWord)


#print (funcionx())


def funcion2():
    list = [1,2,3,4]
    word = 'The crow flies at midnight'
    represent = 'boom'
    abcd = 'abcdefghijklmnopqrstuvwxyz'
    newWord = ''
    indexNotSpace=0
    for ch in word:
        
        if not ((ch>='a' and ch<= 'z') or  (ch>='A' and ch<='Z')):
            newWord= newWord + ch         
        else:
            index = indexNotSpace%len(represent)
            newWord= newWord + str(list[index])
            indexNotSpace = indexNotSpace+1
        
    return  (newWord)


print (funcion2())
