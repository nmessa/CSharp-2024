# caesar_terminal_letters.py
 
from microbit import *
 
sleep(1000)
 
print("Set your keyboard to CAPS LOCK.")
print()
 
while True:
    text = input("Enter key: ")
    key = int(text)
 
    letter = input("Enter a letter: ")
    
    letter = letter.upper()
 
    alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
 
    index = alpha.find(letter)
    index = index + key
    index = index % 26
 
    result = alpha[index]
 
    print("result =", result)
    print()
