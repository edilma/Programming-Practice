s='azcbobobegghakl'
sub=''
long=''
size=len(s)-2


for i in range(0,size,1):
    sub=sub + s[i]
    if s[i+1]>=s[i] :
        sub=sub+s[i+1]
        print(sub)
    else:
        sub =''
        
       
    if len(sub)>len(long) :
        long = sub
        sub=''
        
        
print ('longest is ', long)