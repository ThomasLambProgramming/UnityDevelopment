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
    pyautogui.click(560, 963)
    time.sleep(0.6)
    pyautogui.click(560, 963)
    pyautogui.hotkey("ctrlleft", "c")

    pyautogui.click(1178, 581)
    pyautogui.hotkey("ctrlleft", "v")

        
#press add contact
    #pyautogui.click(1043, 318)

print(pyautogui.position())

previousFirstName = ""
previousLastName = ""
previousEmail = ""

while (True) : 
    if (keyboard.is_pressed("esc")):
        break

    #get first/last name + email
    PasteInfoPage(72, 1388, 283)
    PasteInfoPage(173, 1388, 372)
    PasteInfoPage(333, 1388, 510)

    #save and move on to next page
    pyautogui.click(1785, 663)
    time.sleep(30)

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

    if (pyperclip.paste() == "ACT"):
            stateYValue = 691
    if (pyperclip.paste() == "NSW"):
            stateYValue = 709
    if (pyperclip.paste() == "NT"):
            stateYValue = 732
    if (pyperclip.paste() == "QLD"):
            stateYValue = 758
    if (pyperclip.paste() == "SA"):
            stateYValue = 779
    if (pyperclip.paste() == "TAS"):
            stateYValue = 806
    if (pyperclip.paste() == "VIC"):
            stateYValue = 829
    if (pyperclip.paste() == "WA"):
            stateYValue = 853

    #click on state
    pyautogui.click(1178, 632)
    pyautogui.click(1178, stateYValue)


    PasteInfoPage(811, 1178, 686)
    PasteInfoPage(887, 1178, 736)
    
    pyautogui.click(1727,837)
    time.sleep(5)
    pyautogui.click(1727,837)



    keyboard.read_key()

    #pyperclip.paste()
    #pyautogui.typewrite("Hello Mara")
    #pyautogui.hotkey("down")
    #print(pyautogui.position())
    #pyautogui.click(pyautogui.position())
    #time.sleep(3)
    #pyautogui.scroll(-1)
    #pyautogui.hotkey("ctrlleft", "v")
    #pyautogui.hotkey("ctrlleft", "c")
    #pyautogui.moveTo(100,100, duration = 1)
    