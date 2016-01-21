type('r', Key.WIN)
type("chrome https://www.google.com" + Key.ENTER)
input_searchBar = "1452989632232.png"
wait(input_searchBar, 10)
type(input_searchBar, "Telerik Academy" + Key.ENTER)
text_results = "1452990056241.png"
wait(text_results, 10)
find(text_results)
type('w', Key.CTRL)