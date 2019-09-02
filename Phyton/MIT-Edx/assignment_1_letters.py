s='nfwlcxfajgbvkkjgazduum'
sub=''
long=''
size=len(s)-2


for i in range(0,size,1):
    sub=sub + s[i]
    if len(sub)>len(long) :
        long = sub
    if s[i+1]<=s[i] :
        print(sub)
        sub =''
print ('Longest substring in alphabetical order is: ', long)