# Windows 10 calculator
calcApp = App("calculator")
calcApp.open("calc");
button_Menu = "1453040719803.png"
wait(button_Menu, 10)
click(button_Menu)
sleep(1)
click(Pattern(button_Menu).targetOffset(0, 50))
sleep(1)

def verifyCalculations(expression, resultSmall = None, resultBig = None):
    type(expression)
    button_NoThanks = "1453043769093.png"
    if exists(button_NoThanks):
        click(button_NoThanks)
    type('c', Key.CTRL)
    if Env.getClipboard() == "Cannotdividebyzero":
        return
    elif exists(resultSmall) or exists(resultBig):
        return
    else:
        raise Exception("Test failed: calculations are wrong")

numberSmall = "1453042383667.png"
numberBig = "1453042417309.png"
verifyCalculations("2+3=", numberSmall, numberBig)
verifyCalculations("8-3=", numberSmall, numberBig)
verifyCalculations("1*5=", numberSmall, numberBig)
verifyCalculations("25/5=", numberSmall, numberBig)
verifyCalculations("4/0=")
calcApp.close()