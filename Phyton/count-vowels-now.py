Python 3.7.0b4 (v3.7.0b4:eb96c37699, May  2 2018, 19:02:22) [MSC v.1913 64 bit (AMD64)] on win32
Type "copyright", "credits" or "license()" for more information.
>>> 

sentence=input("enter a word: ")
vowels=0
count = 0
for char in sentence:
    if (char == 'a' or 'e' or 'i' or 'o' or 'u'):
        count+=1
print ('Number or vowels' + count)
