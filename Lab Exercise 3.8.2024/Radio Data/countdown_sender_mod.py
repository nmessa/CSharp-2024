# countdown_sender_mod.py

from microbit import *
import radio

radio.on()
radio.config(channel=7,length=50)

sleep(1000)

print("Countdown App")
print("micro:bit sender")

while True:
    text = input("Enter countdown start: ")
    value = int(text)
    text = input("Enter ms time between counts: ")
    ms = int(text)
    message = input("Enter message after countdown: ")
    
    dictionary = {  }
    dictionary['start'] = value
    dictionary['time'] = ms
    dictionary['after'] = message

    packet = str(dictionary)
    
    print("Send: ", packet)
    radio.send(packet)
    
    print()
