def oddTuples(aTup):
    '''
    aTup: a tuple
    
    returns: tuple, every other element of aTup. 
    '''
    # Your Code Here
    newTup=()
    for i in range(0,len(aTup),2):
        newTup=newTup+(aTup[i],)
    return newTup

data = ('I', 'am', 'a', 'test', 'tuple')
print (oddTuples(data))