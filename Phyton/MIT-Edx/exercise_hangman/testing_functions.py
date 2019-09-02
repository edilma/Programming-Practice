import string


def isWordGuessed(secretWord, lettersGuessed):

    '''secretWord: string, the word the user is guessing
    lettersGuessed: list, what letters have been guessed so far
    returns: boolean, True if all the letters of secretWord are in lettersGuessed;  false otherwise'''

    for i in lettersGuessed:
        print (i )
        if i in secretWord:
            answer=True
        else:
            answer=False
    return answer

def getGuessedWord(secretWord, lettersGuessed):
    '''
    secretWord: string, the word the user is guessing
    lettersGuessed: list, what letters have been guessed so far
    returns: string, comprised of letters and underscores that represents
    what letters in secretWord have been guessed so far.
'''
    #Make the map of _ with the same # of characters of the secret word
    sizeWord = len(secretWord)
    answer = secretWord
    
    for i in range (sizeWord):
        if secretWord[i] not in lettersGuessed:
            
            answer = answer.replace(secretWord[i],' _')
           
    return answer
 

def getAvailableLetters(lettersGuessed):
    '''
    lettersGuessed: list, what letters have been guessed so far
    returns: string, comprised of letters that represents what letters have not
      yet been guessed.
    '''
    # FILL IN YOUR CODE HERE...  
    available = string.ascii_lowercase
    for i in range(len(lettersGuessed)):
        if lettersGuessed[i] in available:
            #print (lettersGuessed[i])
            available = available.replace(lettersGuessed[i],'')
    return available    


def hangman(secretWord):
    '''
    secretWord: string, the secret word to guess.

    Starts up an interactive game of Hangman.

    * At the start of the game, let the user know how many 
      letters the secretWord contains.

    * Ask the user to supply one guess (i.e. letter) per round.

    * The user should receive feedback immediately after each guess 
      about whether their guess appears in the computers word.

    * After each round, you should also display to the user the 
      partially guessed word so far, as well as letters that the 
      user has not yet guessed.

    Follows the other limitations detailed in the problem write-up.
    '''
    # FILL IN YOUR CODE HERE...
    numberGuesses=3
    guessesTaken =0
    lettersGuessed = []
    print("The secret letter word has ",len(secretWord), "letters ")
    print (" You have ", numberGuesses, "guesses.  Let's start ")
    # start counting the guesses
    while guessesTaken< numberGuesses:
        guess= input("Please enter a letter ")
        guessInLowerCase = guess.lower()
        guessesTaken +=1
        lettersGuessed.append(guess)
        print (getGuessedWord(secretWord, lettersGuessed))
        print ('your letters available are: ')
        print (getAvailableLetters(lettersGuessed))
        
    if guessesTaken == numberGuesses:
        print ('Sorry you lost ')
    


    
    

def main():
    
    secretWord = 'implementations ' 
#   lettersGuessed = ['e', 'i', 'k',  'r', 'p','s']
#   print (getAvailableLetters(lettersGuessed))
    #secretWord = chooseWord(wordlist)
    print (secretWord)
    hangman(secretWord)

if __name__ == "__main__":
    main()