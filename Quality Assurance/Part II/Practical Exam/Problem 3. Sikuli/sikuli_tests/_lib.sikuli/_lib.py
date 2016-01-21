from sikuli import *
import HTMLTestRunner

bdLibPath = os.path.abspath(sys.argv[0] + "..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _uimap import *


def run_browser_to_url(browser, url):
    type('r', Key.WIN)
    type(browser + " " + url)
    type(Key.ENTER)
