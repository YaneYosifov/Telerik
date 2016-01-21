from sikuli import *


class TAP:
    button_CreateApp = "button_CreateApp.png"
    field_AppName = "field_AppName.png"
    button_DoCreateApp = "button_DoCreateApp.png"
    image_HomeView = "image_HomeView.png"
    label_Code = "label_Code.png"
    label_Properties = "label_Properties.png"
    label_Plugins = "label_Plugins.png"
    label_Battery = "label_Battery.png"
    checkbox_DebugEnabled = Pattern("checkbox_DebugEnabled.png").similar(0.98)
    label_BatteryChanged = Pattern("label_BatteryChanged.png").similar(0.85)
    checkbox_DebugDisabled = Pattern("checkbox_DebugDisabled.png").similar(0.98)