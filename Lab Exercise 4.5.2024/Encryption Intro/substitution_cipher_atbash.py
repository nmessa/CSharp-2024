# substitution_cipher_atbash.py
 
from microbit import *
 
# Atbash cipher.
def atbash(text):
    alpha  = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    crypta = "ZYXWVUTSRQPONMLKJIHGFEDCBA"
    result = ""
 
    for letter in text:
        letter = letter.upper()
        index = alpha.find(letter)
        result = result + crypta[index]
 
    return result
 
# The script starts executing statements from here.
 
sleep(1000)
 
print("Set your keyboard to CAPS LOCK.")
print()
 
while True:
    plaintext = input("Enter a CAPS LOCK string: ")
    
    result = atbash(plaintext)
 
    print("result =", result)
