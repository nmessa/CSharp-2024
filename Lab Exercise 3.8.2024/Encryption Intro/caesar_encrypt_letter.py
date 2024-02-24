# caesar_encrypt_letter.py
 
from microbit import *
 
sleep(1000)
 
key = 5
letter = "M"
 
alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
index = alpha.find(letter)
 
print("key =", key)
print("letter =", letter, ", index =", index)
 
index = index + key
index = index % 26
result = alpha[index]
 
print("new index =", index, ", result =", result)
 
print()
