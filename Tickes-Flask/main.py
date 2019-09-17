from flask import Flask, request, redirect, render_template
from scripts import add_member
import os
import cgi

app= Flask(__name__)
app.config['DEBUG'] = True


members={}


@app.route('/')
def index():
    return render_template('form.html')




@app.route('/', methods=['POST'])
def add_member(members):
    email = request.form ('email')
    answer = add_member (email)
    
    return render_template (meanswer + 'a new member')




app.run()

