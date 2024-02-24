# receive_radio_test_message.py

from microbit import *
import radio

radio.on()
radio.config(channel = 7)

sleep(1000)

print("micro:bit radio receiver")

while True:
    message = radio.receive()
    if message is not None:
        print("Receive: ", message)
