varA=input("entre a")
varB=input("other")
a= type(varA)
b= type(varB)
if ((a or b)== str):
    print ("string involved")
elif varA>varB:
    print ("bigger")
elif varA==varB:
    print ("equal")
else:
    print ("smaller")
