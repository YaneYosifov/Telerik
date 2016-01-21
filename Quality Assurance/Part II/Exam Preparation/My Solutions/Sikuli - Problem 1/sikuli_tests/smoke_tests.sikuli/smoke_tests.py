import unittest
import random

bdLibPath = os.path.abspath(sys.argv[0] + "..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _lib import *


class SmokeTests(unittest.TestCase):
    def setUp(self):
        pass

    def tearDown(self):
        pass

    def test_001_NavigateToUrl(self):
        run_browser_to_url("chrome", "https://platform.telerik.com/")
        wait(TAP.button_CreateApp, 30)

    def test_002_CreateApp(self):
        app_name = "SampleApp_" + str(random.randrange(100000, 999999, 5))
        create_app(app_name)

    def test_003_DisablePlugin(self):
        click(TAP.label_Code)
        go_to_plugins()
        disable_battery_debug_build()

    def test_004_VerifyConfiguration(self):
        refresh_browser()
        go_to_plugins()
        verify_battery_debug_disabled()


if __name__ == '__main__':
    suite = unittest.TestLoader().loadTestsFromTestCase(SmokeTests)

    outfile = open("report.html", "w")
    runner = HTMLTestRunner.HTMLTestRunner(stream=outfile, title='SmokeTests Report')
    runner.run(suite)
    outfile.close()
