def bmi(weight, height):
    bmi = weight/(height*height)
    if  bmi <=18.5: 
        return "Underweight"
    elif bmi<=25.0:
        return "Normal"
    elif  bmi<=30.0:
        return "Overweight"
    else:
        return "Obese"




def main():
    weight = 110
    height = 1.80
    answer = bmi(weight, height)
    print (answer)



if __name__ == "__main__":
    main()