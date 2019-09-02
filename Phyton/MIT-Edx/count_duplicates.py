
def duplicate_count(MyList):
    count={}
    repeats=[]
    for word in MyList:
        if word not in repeats:
            repeats.append(word)
            count[word] = 1
        else:
            count[word] +=1
    unique_double=list(count.values())
    count =0
    for i in unique_double:
        if i>1:
            count+=1
    print (count)
    return count

    
    #return repeats
    
    
    #print(repeats)




def duplicate_count_dic(MyList):
    my_dict = {i:MyList.count(i) for i in MyList}
    count =0
    unique_double = list(my_dict.values())
    for i in unique_double:
        if i>1:
            count+=1
    return count 

    print (unique_double)
    print (count)


        
#duplicate_count(' abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZReturnsTwentySix')
duplicate_count_dic('abacabjhzjaccac')