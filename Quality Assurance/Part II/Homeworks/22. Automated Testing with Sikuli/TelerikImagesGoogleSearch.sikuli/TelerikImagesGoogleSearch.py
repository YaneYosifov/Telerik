type('r', Key.WIN)
type("chrome https://www.google.bg/search?tbm=isch&q=telerik+academy" + Key.ENTER)
image_telerikLogo = "1453050496964.png"
wait(image_telerikLogo, 10)
rightClick(image_telerikLogo)
label_copyLink = "1453050800336.png"
wait(label_copyLink, 5)
click(label_copyLink)
type(Key.F6)
type('v', Key.CTRL)
type(Key.ENTER)
wait("1453051718990.png", 10)
type(Key.F4, Key.CTRL)