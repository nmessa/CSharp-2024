# Braille Translator
# Author: nmessa
# Date: 11.4.2022
# This program inputs user defined text and output Braille

# ASCII 
asciicodes = [' ','!','"','#','$','%','&','','(',')','*','+',',','-','.','/',
          '0','1','2','3','4','5','6','7','8','9',':',';','<','=','>','?','@',
          'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q',
          'r','s','t','u','v','w','x','y','z','[','\\',']','^','_']

# Braille symbols
brailles = ['⠀','⠮','⠐','⠼','⠫','⠩','⠯','⠄','⠷','⠾','⠡','⠬','⠠','⠤','⠨','⠌',
            '⠴','⠂','⠆','⠒','⠲','⠢','⠖','⠶','⠦','⠔','⠱','⠰','⠣','⠿','⠜','⠹',
            '⠈','⠁','⠃','⠉','⠙','⠑','⠋','⠛','⠓','⠊','⠚','⠅','⠇','⠍','⠝','⠕',
            '⠏','⠟','⠗','⠎','⠞','⠥','⠧','⠺','⠭','⠽','⠵','⠪','⠳','⠻','⠘','⠸']

#Create Braille conversion dictionary
convert = {}

#Build dictionary
for i in range(len(asciicodes)):
    convert[asciicodes[i]] = brailles[i]
#print(convert)
    
phrase = input("Enter a phrase: ").lower() #convert to only lower case

#create empty Braille string
braille = ""

#convert each letter in the phrase into Braille
for letter in phrase:
    braille += convert[letter]

#print the new Braille string
print(braille)


    
