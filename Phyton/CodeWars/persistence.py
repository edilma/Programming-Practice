'''Function that takes a positive parameter and returns
its multipicative persistence.  Number of times that you must multiply 
the digits un num until you reach a sigle digit'''

def persistence(n):
    answer = str(n*10)
    len_answer = len (answer)
    counter =0
    while len_answer>1:
            repeat_mul(n)
            count =+=1
            n = 
    # digits = str(n)
    # while len(digits)>1:
    #     for i in len()
    #     repeat_mul(digits)
    #     count +=1


def repeat_mul(n):
    digits= str(n)
    mult = 1
    for i in digits:
        mult = mult* int(digits[i])
        return mult
    


persistence(25)