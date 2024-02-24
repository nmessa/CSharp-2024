#send_radio_test_message.py

from microbit import *

import radio

radio.on()
radio.config(channel = 7)

sleep(1000)

print("micro:bit radio sender")

while True:
    message = "Testing 123..."

    print("Send: ", message)

    radio.send(message)

    print("Done!")

    sleep(2000)
