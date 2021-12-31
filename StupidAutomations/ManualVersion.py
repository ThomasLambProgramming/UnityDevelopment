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
keyboard.wait('Enter')

print(pyautogui.position())

previousFirstName = ""
previousLastName = ""
previousEmail = ""


while (True) : 
    
    #get first/last name + email
    PasteInfoPage(72, 1388, 283)
    PasteInfoPage(173, 1388, 372)
    PasteInfoPage(333, 1388, 510)

     
    #save and move on to next page
    pyautogui.click(1785, 663)
    keyboard.wait('Enter')
    
     
    #open adress editing
    pyautogui.click(1865, 577)
    
     
    #fill in adress if avaliable
    PasteInfoPage2()
     

    #get state information
    pyautogui.click(763, 963)
    time.sleep(0.6)
    pyautogui.click(763, 963)
     
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
     
    #click on state
    pyautogui.click(1178, 632)
    time.sleep(0.5)
    pyautogui.click(1178, stateYValue)
     

    PasteInfoPage(811, 1178, 686)
    PasteInfoPage(887, 1178, 736)
     

    pyautogui.click(1727,837)
    keyboard.wait('Enter')
    pyautogui.click(1068,522)
    time.sleep(0.5)
    pyautogui.click(1727,837)


    #go back to excel and mark the completed person
    pyautogui.click(72,963)
    time.sleep(0.6)
     

    pyautogui.mouseDown()
    pyautogui.drag(887,0,0.4)
    pyautogui.mouseUp()
     
    pyautogui.click(229,144)


    pyautogui.click(72,963)
    time.sleep(0.6)
    pyautogui.click(72,963)
    pyautogui.hotkey('down')
    pyautogui.hotkey("ctrlleft", "s")
     
    
    pyautogui.click(1043, 318)
    keyboard.wait('Enter')