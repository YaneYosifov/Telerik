from sikuli import *


class TAP:
    title = "title.png"
    dropdown_Model = "1453206701948.png"
    label_Mercedes = "1453206857787.png"
    dropdown_MercedesSelected = "1453206987040.png"
    checkbox_Checked = Pattern("checkbox_Checked.png").similar(0.85)
    checkbox_Unchecked = Pattern("checkbox_Unchecked.png").similar(0.85)
    text_Dots = Pattern("text_Dots.png").similar(0.85)