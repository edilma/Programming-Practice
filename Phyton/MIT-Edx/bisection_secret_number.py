guess=50
max=100
flag =False
value= input ('Please enter a number ')

while not flag :
    print ('Is your number ' , guess,'?')
    answer= input('higher, lower or correct')
    if answer=='y':
        print('Great I won')
        flag:True
    elif answer=='h':
        guess=guess+(guess/2)
        max=guess
    elif answer=='l':
        min=guess
        guess=guess-(guess//2)
        
