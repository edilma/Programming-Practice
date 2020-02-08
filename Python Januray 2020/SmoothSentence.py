'''A smooth sentence is one where the last letter of each word is identical to the first letter the following word'''

def IsSmooth(sentence):
    words= sentence.split()
    answer = True
    
    for i in range(0, (len(words)-1)):
        if words[i][-1]==words[i+1][0]:
            answer = True
        else:
            answer=False
            break
    return answer


def main():
    word = input("Enter a sentence to analize ")
    if IsSmooth(word) == True:
        print ( word+" is a smooth sentence")
    else:
        print ( word + " is not a smooth sentence")

   


if __name__ == '__main__':
    main()
    