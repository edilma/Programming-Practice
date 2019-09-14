def vowels(s):
    vowels='aeiou'
    total =0
    string=s.lower()
    for ch in string:
        if ch in vowels:
            total+=1
    return total

def main():
    s = 'azcbobobegghakl'
    print (vowels(s))



if __name__ == "__main__":
    main()
    
