import unittest

bdLibPath = os.path.abspath(sys.argv[0] + "..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _lib import *


class SmokeTests(unittest.TestCase):
    def setUp(self):
        pass

    def tearDown(self):
        pass

    def test_001_NavigateToUrl(self):
        run_browser_to_url("chrome",
                           "\"D:\Telerik Academy\Quality Assurance\Part II\My Exam\Problem 3. Sikuli\Exam.html\"")
        wait(TAP.title, 10)

    def test_002_DropdownNavigation(self):
        click(TAP.dropdown_Model)
        click(TAP.label_Mercedes)
        find(TAP.dropdown_MercedesSelected).highlight(1)

    def test_003_UncheckAllItems(self):
        findAll(TAP.checkbox_Checked)
        matches = SCREEN.getLastMatches()
        while matches.hasNext():
            click(matches.next())

    def test_004_CheckDottedItems(self):
        findAll(TAP.text_Dots)
        matches = SCREEN.getLastMatches()
        while matches.hasNext():
            target = matches.next().left().exists(TAP.checkbox_Unchecked)
            click(target)


if __name__ == '__main__':
    suite = unittest.TestLoader().loadTestsFromTestCase(SmokeTests)

    outfile = open("report.html", "w")
    runner = HTMLTestRunner.HTMLTestRunner(stream=outfile, title='SmokeTests Report')
    runner.run(suite)
    outfile.close()
