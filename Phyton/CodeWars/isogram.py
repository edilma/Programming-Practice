def is_isogram(string):
    word = string.lower()
    repeats=[]
    for char in word:
        if char in repeats:
            return False
        else:
            repeats.append(char)
    return True

def main():
    palabra = 'moOse'
    print (is_isogram(palabra))


if __name__ == '__main__':
    main()
    
    