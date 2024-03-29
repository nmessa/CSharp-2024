#terminal_chat_through_microbits.py
#For Transeiver A

from microbit import *
import radio

radio.on()
radio.config(channel=7)

sleep(1000)

print("micro:bit transceiver A")

print("Type messages, press enter to send.")
print("Received messages will also be displayed.")

while True:
    if uart.any():
        tx = input("Send: ")
        radio.send(tx)
    message = radio.receive()
    if message is not None:
        print("Receive: ", message)
    
