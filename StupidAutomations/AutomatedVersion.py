import pyautogui
import time
import keyboard
import pyperclip

print("Default size of monitor is " + str(pyautogui.size()))
print("Starting Program in 2 seconds")
time.sleep(1)
print("Starting Program in 1 seconds")
time.sleep(1)


def PasteInfoPage(xExcel, xChrome, yChrome):
    pyautogui.click(xExcel, 963)
    time.sleep(0.6)
    pyautogui.click(xExcel, 963)
    pyautogui.hotkey("ctrlleft", "c")

    #chrome add first name
    pyautogui.click(xChrome, yChrome)
    pyautogui.hotkey("ctrlleft", "v")

def PasteInfoPage2():
    #address
    pyautogui.click(521, 963)
    time.sleep(0.6)
    pyautogui.click(521, 963)
    pyautogui.hotkey("ctrlleft", "c")

    
    pyautogui.click(1178, 433)
    pyautogui.hotkey("ctrlleft", "v")
    pyautogui.click(641, 963)
    time.sleep(0.6)
    pyautogui.click(641, 963)
    pyautogui.hotkey("ctrlleft", "c")

    pyautogui.click(1178, 581)
    pyautogui.hotkey("ctrlleft", "v")

        
pyautogui.click(1043, 318)
time.sleep(25)

print(pyautogui.position())

previousFirstName = ""
previousLastName = ""
previousEmail = ""


while (True) : 
    if (keyboard.is_pressed("esc")):
        break

    #get first/last name + email
    PasteInfoPage(72, 1388, 283)
    if (keyboard.is_pressed("esc")):
        break
    PasteInfoPage(173, 1388, 372)
    if (keyboard.is_pressed("esc")):
        break
    PasteInfoPage(333, 1388, 510)

    if (keyboard.is_pressed("esc")):
        break
    #save and move on to next page
    pyautogui.click(1785, 663)
    time.sleep(15)

    if (keyboard.is_pressed("esc")):
        break
    #open adress editing
    pyautogui.click(1865, 577)
    
    if (keyboard.is_pressed("esc")):
        break
    #fill in adress if avaliable
    PasteInfoPage2()
    if (keyboard.is_pressed("esc")):
        break

    #get state information
    pyautogui.click(763, 963)
    time.sleep(0.6)
    pyautogui.click(763, 963)
    if (keyboard.is_pressed("esc")):
        break
    pyautogui.hotkey("ctrlleft", "c")

    stateYValue = 0

    currentState = pyperclip.paste()

    if "ACT" in currentState:
            stateYValue = 691
    if "NSW" in currentState:
            stateYValue = 709
    if "NT" in currentState:
            stateYValue = 732
    if "QKD" in currentState:
            stateYValue = 758
    if "SA" in currentState:
            stateYValue = 779
    if "TAS" in currentState:
            stateYValue = 806
    if "VIC" in currentState:
            stateYValue = 829
    if "WA" in currentState:
            stateYValue = 853
    if (keyboard.is_pressed("esc")):
        break
    #click on state
    pyautogui.click(1178, 632)
    time.sleep(0.5)
    pyautogui.click(1178, stateYValue)
    if (keyboard.is_pressed("esc")):
        break

    PasteInfoPage(811, 1178, 686)
    PasteInfoPage(887, 1178, 736)
    if (keyboard.is_pressed("esc")):
        break

    pyautogui.click(1727,837)
    time.sleep(6)
    pyautogui.click(1068,522)
    time.sleep(1)
    pyautogui.click(1727,837)


    #go back to excel and mark the completed person
    pyautogui.click(72,963)
    time.sleep(0.6)
    if (keyboard.is_pressed("esc")):
        break

    pyautogui.mouseDown()
    pyautogui.drag(887,0,0.4)
    pyautogui.mouseUp()
    if (keyboard.is_pressed("esc")):
        break
    pyautogui.click(229,144)


    pyautogui.click(72,963)
    time.sleep(0.6)
    pyautogui.click(72,963)
    pyautogui.hotkey('down')

    if (keyboard.is_pressed("esc")):
        break
    
    pyautogui.click(1043, 318)
    time.sleep(25)