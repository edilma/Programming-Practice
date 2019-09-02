
totalPayments=0
balance = 0
annualInterestRate=0
monthlyPaymentRate=0

def calculateCcardBalance(balance,annualInterestRate,monthlyPaymentRate):
    '''Function that calculates the debt of a credit card'''
    totalPayments=0
    for month in range(0,12):
        payment = balance*monthlyPaymentRate
        totalPayments=totalPayments+payment
        balance = balance-payment
        interest = balance*(annualInterestRate/12)
        balance=balance+interest
        #print ('remainder balance',balance)
    return (balance)
print (round(balance,2))
#print (monthlyPaymentRate)


print (round((calculateCcardBalance(484,0.2,0.04)),2))

print(calculateCcardBalance.__doc__)