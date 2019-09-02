
def how_many(aDict):
    total = list(aDict.values())
    sum = 0
    for i in range(0,len(total)):
        sum = sum + len(total[i])
    return sum      
  


def contar_items(aDict):
    values = aDict.values()
    return (sum(map(len, values)))

#print (contar_items())

def main():

    animals ={'a': ['aardvark'], 'b': ['baboon'], 'c': ['coati'], 'd': ['donkey', 'dog', 'dingo']}
    print (how_many(animals))

    print ('Usando map function ')
    print (contar_items(animals))



if __name__ == "__main__":
    main()