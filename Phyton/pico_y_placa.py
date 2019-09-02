s='azcbobobegghakl'
index=1
lenght=len(s)-1
#print (lenght)
temporalSentence=''
longest=''
next=''
for i in range(0,lenght,1):
   #print (s[lenght])
   
    if (i==lenght) or s[i]<=s[i+1]:
       #print (s[i],"menor que", s[i+1])
       temporalSentence = temporalSentence+s[i]
       next=s[i+1]
       print ('next is ', next)
       if temporalSentence>longest:
            longest=temporalSentence
            temporalSentence =''
            print ('temporarl : ', temporalSentence)
            print ('longest : ', longest)
    elif next !=s[i+1]:
            temporalSentence=temporalSentence+next
            temporalSentence=''
            print('temporal despues del if next :', temporalSentence)
            if temporalSentence>longest:
                longest=temporalSentence
                temporalSentence =''
                print ('temporarl : ', temporalSentence)
                print ('longest : ', longest)
    print ( 'The Total longest is ', longest)
    #if temporalSentence>longest:
     #           longest=temporalSentence
      #          temporalSentence=''
       #         print (temporalSentence)
       
       