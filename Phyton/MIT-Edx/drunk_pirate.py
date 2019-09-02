'''Drunk pirate moving in angles and forward 100 steps'''
import turtle

#create the enviroment and the turtle
wn= turtle.Screen()
wn.bgcolor("yellow")

#create turtle
drunk=turtle.Turtle()
drunk.shape("circle")
drunk.pensize(8)

#Make the drunk guy move
angles=[160, -43, 270, -97, -43, 200, -940, 17, -86]

for angle in angles:
    drunk.forward(100)
    drunk.right(angle)




#close window
wn.exitonclick()