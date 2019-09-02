def biggest(aDict):
    '''
    aDict: A dictionary, where all the values are lists.

    returns: The key with the largest number of values associated with it
    '''
    #Make a list of the value items
    list_values =aDict.values()
    key_values = aDict.keys()
    #print(list_values)
    
    #make a list with the values
    #size_values = map(len,list_values)
    list_values1 =list(list_values)
    list_keys1 = list(key_values)
    print(list_values1)

    #count how many in each value
    #find the biggest value (3 of items) in the list 
    biggest_value = max(map(len,list_values))
        



def main():
    animals ={'a': ['aardvark'], 'b': ['baboon'], 'c': ['coati'], 'd': ['donkey', 'dog', 'dingo']}
    print (animals.items())

    #print(max(animals.items())[0])
    #biggest(animals)


if __name__ == "__main__":
    main()
