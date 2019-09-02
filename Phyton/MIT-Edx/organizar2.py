s='azcbobobegghakl'
length = len(s)-1
frase = ''
longest=''
for i in range(0,length):
  frase = frase + s[i]
  if i==length or s[i+1]<s[i]: # is the next one wrong
    print ('frase now',frase)
    if len(frase)>len(longest):
      longest = frase
      print('this is now the longest ')
    frase=''
print ('The longest letters are', longest)