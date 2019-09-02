def number_of_digits(n):
    digits = 0
    b = str(n)
    for char in b:
        digits+=1
    return digits

def main():
    print (number_of_digits('452'))

if __name__ == "__main__":
    main()
