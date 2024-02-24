# caesar_terminal_words.py
 
from microbit import *
 
sleep(1000)
 
print("Set your keyboard to CAPS LOCK.")
print()
 
while True:
    text = input("Enter key: ")
    key = int(text)
 
    word = input("Enter character(s) in A...Z range: ")
 
    alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    result = ""
 
    for letter in word:
        
        letter = letter.upper()
        index = ( alpha.find(letter) + key ) % 26
        result = result + alpha[index]
 
    print("result:", result)
    print()
