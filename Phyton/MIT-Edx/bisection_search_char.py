def isIn(char, aStr):
    '''
    char: a single character
    aStr: an alphabetized string
    
    returns: True if char is in aStr; False otherwise
    '''
    #if the string is empty
    if aStr == '':
        return False
    #if the string is one character
    if len(aStr) ==1:
        middle_character = aStr[0]
    #if the middle character is the one I am looking for
        if char==middle_character:
            return True
        else:
            return False
    #Calculate the middle of the string
    middle=(len(aStr))//2  
    #check if the middle character is the one we are looking
    if char==aStr[middle]:
          return True
      
    elif char>aStr[middle]:
      return isIn(char, aStr[middle:])
    elif char<aStr[middle]:
      return isIn(char, aStr[:middle])
    else:
      return False
    


print (isIn('k', 'hijlm'))