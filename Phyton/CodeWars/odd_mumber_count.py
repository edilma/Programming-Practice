def find_it(seq):
    '''Function creates a dictionary of items and count of those items
    receives a list of numbers'''
    number_count = {}
    for num in seq:
        if num not in number_count.keys():
            number_count[num] = 1
        else:
            number_count[num] +=1
            #returns a dictionary 
    return number_count

def find_the_odd(dictionary_number):
    '''Function that returns the number that appears odd times in the list
    Receives a dictionary'''
    listKeys = list(dictionary_number.keys())
    listValues = list(dictionary_number.values())
    #print (listKeys)
    #print (listValues)
    for value in listValues:
        if value%2 !=0:
            #print (value)
            oddValue = value
            break
    for key in listKeys:
        if dictionary_number[key] == oddValue:
            return key
    return ("No item is odd times")



def main():
    lista = [1,4,2,7,5,4,1,3,5,4,1,1,4,3,1,7,2]
    #lista =['a','b','c','d','a','b','c','d','c']
    dict_list =find_it(lista)
    print(dict_list)
    print (find_the_odd(dict_list))

if __name__ == "__main__":
    main()