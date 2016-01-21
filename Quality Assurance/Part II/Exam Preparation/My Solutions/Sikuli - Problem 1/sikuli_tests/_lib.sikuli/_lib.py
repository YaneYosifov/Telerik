from sikuli import *
import HTMLTestRunner

bdLibPath = os.path.abspath(sys.argv[0] + "..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _uimap import *


def run_browser_to_url(browser, url):
    type('r', Key.WIN)
    type(browser + " " + url)
    type(Key.ENTER)


def create_app(name):
    click(TAP.button_CreateApp)
    wait(TAP.field_AppName, 10)
    type(TAP.field_AppName, name)
    click(TAP.button_DoCreateApp)
    wait(TAP.image_HomeView, 40)


def go_to_plugins():
    wait(TAP.label_Properties, 30)
    doubleClick(TAP.label_Properties)
    wait(TAP.label_Plugins, 20)
    click(TAP.label_Plugins)
    wait(TAP.label_Battery, 15)
    click(Pattern(TAP.label_Battery).targetOffset(-75, 0))


def disable_battery_debug_build():
    wait(TAP.checkbox_DebugEnabled, 5)
    click(TAP.checkbox_DebugEnabled)
    sleep(2)


def refresh_browser():
    type(Key.F5)
    sleep(3)


def verify_battery_debug_disabled():
    find(TAP.label_BatteryChanged).highlight(1)
    find(TAP.checkbox_DebugDisabled).highlight(1)
