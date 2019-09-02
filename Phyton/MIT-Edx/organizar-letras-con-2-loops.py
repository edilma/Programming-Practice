s='azcbobobegghakl'
length = len(s)-1
frase = ''
longest=''
for i in range(0,length):
  frase = frase + s[i]
  if s[i]<s[i+1]: # is the next one wrong
    print ('frase now',frase)
    if len(frase)>len(longest):
      longest = frase
      print('this is now the longest ')
    frase=''
print ('The longest letters are', longest)


