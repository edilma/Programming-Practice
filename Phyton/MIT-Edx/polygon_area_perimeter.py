'''The area of a regular polygon is:  0.25∗n∗s2/tan(π/n) 
The perimeter of a polygon is: length of the boundary of the polygon
polysum that takes 2 arguments, n and s. 
This function should sum the area and square of the perimeter of the regular polygon. 
The function returns the sum, rounded to 4 decimal places'''

#import the math library
import math


def polysum(n,s):
    #calculate the area
    area = (0.25*n*(s**2))/(math.tan(math.pi/n))

    #calculate the perimeter
    perimet = s*n

    #Calculate the area + square perimeter 
    ans= (area + perimet**2)
    
    #Return the answer rounded to 4 decimal places
    return round(ans,4)

#tes the function
print (polysum(53,98))