
def count_letter_string(sentence):
    alphabeth = 'abcdefghijklmnopqrstuvwxyz'
    ocurrences ={}
    count = 0
    for letter in sentence:
        if letter in alphabeth:
            count +=1
        ocurrences[letter] = count
        count =0
    return ocurrences



def main():
    sentence = 'ThiS is a String with Upper and lower case Letters.'
    print (count_letter_string(sentence))


if __name__ == "__main__":
    main()