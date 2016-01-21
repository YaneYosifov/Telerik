type('r', Key.WIN)
type("chrome http://www.dhtmlgoodies.com/scripts/drag-drop-custom/demo-drag-drop-3.html" + Key.ENTER)
wait("1453001692806.png", 10)

dragDrop(Pattern("1452992377092.png").similar(0.95), Pattern("1452992824153.png").similar(0.93))
sleep(1)

dragDrop(Pattern("1452992334420.png").similar(0.80), Pattern("1452992851415.png").similar(0.90))
sleep(1)

dragDrop(Pattern("1452992304229.png").similar(0.81), Pattern("1452992870992.png").similar(0.95))
sleep(1)

dragDrop(Pattern("1452992367550.png").similar(0.90), Pattern("1452998449471.png").similar(0.90))
sleep(1)

dragDrop(Pattern("1452992408789.png").similar(0.88), Pattern("1452992839192.png").similar(0.85))
sleep(1)

dragDrop(Pattern("1452992351076.png").similar(0.90), Pattern("1452992861921.png").similar(0.85))
sleep(1)

dragDrop(Pattern("1452992319072.png").similar(0.80), Pattern("1452992883533.png").similar(0.80))

find("1453001201644.png")
type('w', Key.CTRL)