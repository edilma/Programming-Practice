d='azcboegghakl'
#print (d)
tempSent=''
final = len(d)
index=1
longest=''

for scan in range (0,final,1):
    #print (d[scan], (d[index]))
        #tempSent=tempSent+d[scan]
        if (scan==final) or (d[index]>=d[scan]):
            print (d[index], d[scan],' true')
            tempSent=tempSent+d[index]
            index+=1
            print (tempSent)
        #print(tempSent)
           #scan =scan+1
        else:
            print (d[index],d[scan],'false')
            if tempSent>longest:
                longest=tempSent
                tempSent = ''
                index = index+1
                #  tempSent = tempSent+d[scan]  
       # print ('the longest is: ', longest)