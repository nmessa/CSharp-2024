# caesar_cipher_function.py

from microbit import *

''' Function converts plaintext to ciphertext using key '''

def caesar(key, word):
    alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    result = ""

    for letter in word:
        
        letter = letter.upper()
        index = ( alpha.find(letter) + key ) % 26
        result = result + alpha[index]
    
    return result

''' Script starts from here... '''

sleep(1000)

print("Set your keyboard to CAPS LOCK.")
print()

while True:
    text = input("Enter key: ")
    key = int(text)

    letters = input("Enter character(s) in A...Z range: ")

    result = caesar(key, letters)
    
    print("result:", result)
    print()
