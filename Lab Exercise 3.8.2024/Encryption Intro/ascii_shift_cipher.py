# ascii_shift_cipher.py
 
from microbit import *
 
''' Function converts plaintext to ciphertext using key '''
 
def ascii_shift(key, text):
    result = ""
    for letter in text:
        ascii = ( ord(letter) + key - 32 ) % 94 + 32
        result = result + chr(ascii)
    return result
 
''' Script starts from here... '''
 
sleep(1000)
 
while True:
    text = input("Enter key: ")
    key = int(text)
 
    text = input("Enter printable character(s): ")
 
    result = ascii_shift(key, text)
    
    print("result:", result)
    print()
