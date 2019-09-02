def how_many(animals):
    values=animals.values()
    total=0
    for i in values:
        len(i)

        #for j in (values[i],):
         #   total = total+1
    return total

animals ={'a': ['aardvark'], 'b': ['baboon'], 'c': ['coati'], 'd': ['donkey', 'dog', 'dingo']}
total = how_many(animals)
print (total)
