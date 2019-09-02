lowest=0
highest=100
found=False
guess=50
print ('Please think of a number between 0 and 100!  ' )
while not found :
    print ('Is your secret number', guess, ' ?')
    answer= input ('Enter "h" to indicate the guess is too high. Enter "l" \
to indicate the guess is too low.  Enter "c" to indicate I guessed correctly ')
    if answer=='c':
        print ('Game over. Your secret number was: ', guess)
        found=True
    if answer=='h' or  answer=='H':
        highest=guess
        guess=(highest+lowest)//2
        #print('answer to low')
        
    if answer=='l' or  answer=='L':
        lowest=guess
        guess=(highest+lowest)//2
        #print ('answer to high')
    if answer != 'h' and answer != 'H' and answer != 'l' and answer != 'L' and answer != 'c':
        print("Sorry I don't understand ")
