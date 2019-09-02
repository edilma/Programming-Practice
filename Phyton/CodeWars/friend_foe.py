def friend(x):
    '''function that filters a list of strings.  Only the names with
    4 letters on it are part of my list of friends'''
    friends= []
    for name in x:
        if len(name)==4:
            friends.append(name)
    return friends
    
def friend2(x):
    return [i for i in x if len(i)==4]

def main():
    lista = ["Ryan", "Kieran", "Jason", "Yous"]
    print (friend(lista))
    print (friend2(lista))


if __name__ == "__main__":
    main()