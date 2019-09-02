def hola ():
    word = 'mellamoedilma'
    key = 'boom'
    newWord=''
    for i in range (len(word)):
        index= i%(len(key))
        newWord = newWord + key[index]
    print (newWord)



def transform_text_back_to_message(message, text):
    '''Function that returns the message with their original non alphabetical characters
    Inputs are the original message and the encrypted text.  It returns a string '''
    changed_indexes = []

    final_version = ''
    for i in range (len(message)):
        if((message[i]>='a' and message[i]<= 'z') or (message[i]>='A' and message[i]<='Z')):
            changed_indexes = changed_indexes
        else:
            changed_indexes.append(i)
    newText = [ch for ch in text]
    for item in changed_indexes:
       newText[item:item] = message[item]
    return ''.join(newText)

def main():
    message = The crow flies at midnight!
    text = Uvs osck rmwse bh auebwsih 
    answer = (encrypt('The crow flies at midnight!', 'boom') )
   
    

main()
