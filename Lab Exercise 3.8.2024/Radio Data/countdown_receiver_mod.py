# countdown_receiver_mod.py

from microbit import *
import radio

radio.on()
radio.config(channel=7,length=50)

sleep(1000)

print("Countdown App")
print("micro:bit receiver\n")

while True:
    packet = radio.receive()
    if packet is not None:
        print("Receive: ", packet)

        print()
        print("Parse: ")

        dictionary = eval(packet)

        value = dictionary['start']
        ms = dictionary['time']
        message = dictionary['after']
        
        print("value = ", value)
        print("ms = ", ms)
        print("message = ", message, "\n")
        
        while value >= 0:
            print(value)
            sleep(ms)
            value = value - 1
            
        print(message)
        
        print()
