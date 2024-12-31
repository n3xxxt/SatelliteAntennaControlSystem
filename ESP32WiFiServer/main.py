import network
import socket
from machine import Pin, ADC, PWM
from time import sleep

angle = ADC(Pin(34))
angle.atten(ADC.ATTN_11DB)
horizont = ADC(Pin(35))
horizont.atten(ADC.ATTN_11DB)

# Настройка WiFi в режиме Access Point
ap = network.WLAN(network.AP_IF)
ap.active(True)
ap.config(essid='ESP32_AP', password='12345678')

# Создание TCP сервера
addr = socket.getaddrinfo('0.0.0.0', 8080)[0][-1]
s = socket.socket()
s.bind(addr)
s.listen(1)
print('Listening on:', ap.ifconfig()[0])

ACTUAL_ANGLE_INDEX = 1
ACTUAL_HORIZONT_INDEX = 2

MAX_ANGLE = 90
MIN_ANGLE = 0

MAX_HORIZONT = 180
MIN_HORIZONT = 0

SYSTEM_ACTIVATED = False

CONNECTED = False

DELAY = 0.01
STEP = 0.3

# Инициализация пина светодиода
led = Pin(2, Pin.OUT)


def blink_led(times, delay):
    for i in range(times*2):
        led.value(not led.value())
        sleep(delay)
    led.value(False)

def check_system_response():    
    ACTUAL_ANGLE_VALUE = 90/4095 * angle.read()
    ACTUAL_HORIZONT_VALUE = 180/4095 * horizont.read()
    return "SYSTEM_INFORMATION;"+str(ACTUAL_ANGLE_VALUE)+";"+str(ACTUAL_HORIZONT_VALUE)+";"+str(SYSTEM_ACTIVATED)+";"+str(MAX_ANGLE)+";"+str(MIN_ANGLE)+";"+str(MAX_HORIZONT)+";"+str(MIN_HORIZONT)
    

def activate_system_response():
    global SYSTEM_ACTIVATED
    SYSTEM_ACTIVATED = True
    return "SYSTEM_ACTIVATED"

def deactivate_system_response():
    global SYSTEM_ACTIVATED
    SYSTEM_ACTIVATED = False
    return "SYSTEM_DEACTIVATED"

def error_set_position_response():
    return "ERROR_IN_SETTING_POSITION"

def position_is_set_response():
    return "POSITION_IS_SET"

# def angle_rotate(value: float):
#     if not (MIN_ANGLE < value < MAX_ANGLE):
#         return False
    
#     up = PWM(Pin(19))
#     up.freq(5000)
#     down = PWM(Pin(18))
#     down.freq(5000)
    
#     #считываем значение угла с датчика
#     angle_info = 90/4095 * angle.read()
#     print(angle_info)

#     delay = DELAY
#     if angle_info < value:
        
#         led.value(True)
#         while angle_info < value:
#             blink_led(1, 0.05)
#             #подать однократный сигнал(двинуть вверх по углу)
#             up.duty(1023)
#             up
#             angle_info = 90/4095 * angle.read()
#             sleep(delay)
#             if (value - angle_info) < 10.0:
#                 delay = delay + STEP
#         up.duty(0)
#         up 
#         led.value(False)
    
#     else:

#         led.value(True)
        
#         while angle_info > value:
#             blink_led(1, 0.05)
#             #подать однократный сигнал(двинуть вниз по углу)
#             down.duty(1023)
#             down
#             angle_info = 90/4095 * angle.read()
#             sleep(delay)
#             if (angle_info - value) < 10.0:
#                 delay = delay + STEP

#         down.duty(0)
#         down 
#         led.value(False)
     
#     return True
    
# def horizont_rotate(value:float):
#     if not (MIN_HORIZONT < value < MAX_HORIZONT):
#         return False
    
#     up = PWM(Pin(23))
#     up.freq(5000)
#     down = PWM(Pin(22))
#     down.freq(5000)
#     #считываем значение угла с датчика
#     horizont_info = 180/4095 * horizont.read()
#     print(horizont_info)
    
#     delay = DELAY
#     if horizont_info < value:
#         led.value(True)
#         while horizont_info < value:
#             blink_led(1, 0.05)
#             up.duty(1023)
#             up
#             horizont_info = horizont_info = 180/4095 * horizont.read()
#             sleep(delay)
            
#             if (value - horizont_info) < 10.0:
#                 delay = delay + STEP
            
        
#         up.duty(0)
#         up            
#         led.value(False)
    
#     else:
        
#         led.value(True)
#         while horizont_info > value:
#             blink_led(1, 0.05)
#             #подать однократный сигнал(двинуть вниз по азимуту)
#             down.duty(1023)
#             down
#             horizont_info = horizont_info = 180/4095 * horizont.read()
#             sleep(delay)
            
#             if (horizont_info - value) < 10.0:
#                 delay = delay + STEP
#         down.duty(0)
#         down 
#         led.value(False)
    
#     return True 

def angle_rotate(value: float):
    angle_info = 90/4095 * angle.read()
    print(angle_info)
    
    
    if not (MIN_ANGLE <= value <= MAX_ANGLE):
    #or (angle_info - 0 < 0.1):
        return False
    
    up = PWM(Pin(19))
    up.freq(5000)
    up.duty(0)
    up
    down = PWM(Pin(18))
    down.freq(5000)
    up.duty(0)
    up
    
    #считываем значение угла с датчика
    
    

    if angle_info < value:
        shim_rotate(up, angle, angle_info, value)
    else:
        shim_rotate(down, angle, angle_info, value)
     
    return True
    
def horizont_rotate(value:float):
    horizont_info = 180/4095 * horizont.read()
    print(horizont_info)

    if not (MIN_HORIZONT <= value <= MAX_HORIZONT):
    #or (horizont_info - 0 < 0.1):
        return False
    
    up = PWM(Pin(23))
    up.freq(5000)
    up.duty(0)
    up
    down = PWM(Pin(22))
    down.freq(5000)
    down.duty(0)
    down
    
    
    
    if horizont_info < value:
        shim_rotate(up, horizont, horizont_info, value)
    else:
        shim_rotate(down, horizont, horizont_info, value)
    
    return True 


def shim_rotate(pin, angle_pin, start_value, finish_value):

    pin.freq(5000)
    
    LED_pin = PWM(Pin(2,Pin.OUT))
    LED_pin.freq(5000)
    LED_pin.duty(0)
    LED_pin

    info = 180/4095 * angle_pin.read()

    if (start_value - finish_value) > 0.1:
        step = (start_value - finish_value)/1024
        
        #Увеличиваем скорость
        shim_step = 0
        pre_value = 0
        while shim_step < 1023:
            info = 180/4095 * angle_pin.read()
            #if ((pre_value - info) > step) or (pre_value == 0):
            shim_step = shim_step + 1
            
            pin.duty(shim_step)
            pin
            LED_pin.duty(shim_step)
            LED_pin
            pre_value = info
            sleep(DELAY)

        #Уменьшаем скорость
        while shim_step > 0:
            info = 180/4095 * angle_pin.read()
            #if ((pre_value - info) > step) or (pre_value == 0):
            shim_step = shim_step - 1

            pin.duty(shim_step)
            pin
            LED_pin.duty(shim_step)
            LED_pin
            pre_value = info
            sleep(DELAY)

    else:
        
        step = (finish_value - start_value)/1024
        
        #Увеличиваем скорость
        shim_step = 0
        pre_value = 0
        while shim_step < 1023:
            info = 180/4095 * angle_pin.read()
            #if ((info - pre_value) > step) or (pre_value == 0):
            shim_step = shim_step + 1

            pin.duty(shim_step)
            pin
            LED_pin.duty(shim_step)
            LED_pin
            pre_value = info
            sleep(DELAY)

        print('Переход')
        #Уменьшаем скорость
        while shim_step > 0:
            info = 180/4095 * angle_pin.read()
            #if ((info - pre_value) > step) or (pre_value == 0):
            shim_step = shim_step - 1
            
            pin.duty(shim_step)
            pin
            LED_pin.duty(shim_step)
            LED_pin
            pre_value = info
            sleep(DELAY)
    

def read_client(cl):
    global CONNECTED
    while CONNECTED:
        try:
            blink_led(1, 0.1)
            data = cl.recv(1024).decode()  # Получение данных от клиента
            
            data = data.split(';')
            
            try:
                
                if not data[0]:
                    CONNECTED = False
                    
                print(data[0])
                if data[0] == 'CHECK_SYSTEM':
                    response = check_system_response()
                    print(response)
                    cl.sendall(response.encode())
                    blink_led(1, 0.1)
                elif data[0] == 'ACTIVATE_SYSTEM':
                    if not(SYSTEM_ACTIVATED):
                        #подать постоянный ток на пин питания
                        response = activate_system_response()
                        print(response)
                        cl.sendall(response.encode())
                        blink_led(2, 0.1)
                    else:
                        blink_led(10, 0.1)
                elif data[0] == 'DEACTIVATE_SYSTEM':
                    if not(SYSTEM_ACTIVATED):
                        #подать постоянный ток на пин питания
                        response = deactivate_system_response()
                        print(response)
                        cl.sendall(response.encode())
                        blink_led(3, 0.1)
                    else:
                        blink_led(10, 0.1)
                elif data[0] == 'SET_POSITION':
                    
                    set_angle = float(data[1].replace(",","."))
                    set_horizont = float(data[2].replace(",","."))
                    
                    horizont_success = horizont_rotate(float(set_horizont))
                    angle_success = angle_rotate(float(set_angle))
                    
                    if not (horizont_success and angle_success):
                        response = error_set_position_response()
                    else:
                        response = position_is_set_response()
                                
                    print(response)
                    cl.sendall(response.encode())
            
            except Exception:
                print("READ_CLIENT_ERR")
        except Exception:
            break
    print('Client_disconnect')

def wait_connection():
    global CONNECTED
    # Ожидание подключения клиента
    cl, addr = s.accept()
    CONNECTED = True
    print('Client connected from', addr)
    blink_led(1, 0.1)
    return cl

blink_led(2, 0.1)

while True:    
    if CONNECTED:
        read_client(cl)
    else:
        cl = wait_connection()      


        
        



 

