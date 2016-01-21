# Windows 10 titlebar buttons
type('d', Key.WIN)
if exists("1453004378031.png", 5) or exists("1453007431294.png", 5):
    raise Exception("Test failed: not all windows are minimized!")