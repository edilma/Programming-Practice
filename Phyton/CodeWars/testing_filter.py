
def main():
   
    my_list = [1, 5, 4, 6, 8, 11, 3, 12]
    aLIst = [10,15,20,25,30,35,40]
    #new_list = list(filter(lambda x: (x%2 == 0) , my_list))
    #print(new_list)
    
    evenNumbers = list(filter(lambda x :(x%2==0),aLIst))
    print (evenNumbers)

   
if __name__ == "__main__":
    main()

