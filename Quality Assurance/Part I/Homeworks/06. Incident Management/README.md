# Homework
## Incident Management

1.We have a painting program like Paint.NET and we have the following bugs
*	Set Priority and Severity

| Bug description | Severity | Priority |
| --------------- |:--------:|:--------:|
| Tool for selection doesn’t select exactly the same that it’s marking (crops 10 pixels to the left) | 3 - High | 2 - Next Release |
| When selecting a color with the color picker it replaces the first color from the palette, not the chosen one | 3 - High | 2 - Next Release |
| Shortcut for “Create New Image” (Ctrl+N) doesn’t work | 4 - Medium | 2 - Next Release |
| Spelling mistake in menu Select “Transperent selection” instead of “Transparent selection” | 5 - Low | 3 - On Occation |
| While holding Ctrl+Z and drawing with the pencil the second color is used instead of the first one, and that’s not a feature | 4 - Medium | 2 - Next Release |
| When using “Magic Wand” tool the tolerance value is changing on every mouse click | 3 - High | 2 - Next Release |
| While clicking “Rotate 90 Clockwise” the image is rotating in counterclockwise direction | 4 - Medium | 2 - Next Release |
| The button for increasing the Brush size doesn’t work. It can be increased only from the drop down | 4 - Medium | 2 - Next Release |
| Program crash on clicking the OK button while resizing an image | 2 - Critical | 1 - Immediate |

2.Imagine you have the following bug, mentioned by a customer and you have to describe it and log it in the bug tracking tool you use
*	Report the following bugs

| BUG REPORT |   #1   |
| ---------- | ------ | 
| Description | When there’s a page break in the page and you try to set dashed border on the page, the bottom border line doesn’t show |
| Steps to reproduce | <ol><li>Enter a text with one or more page breaks<li>Set dashed border on the page<li>The bottom borderder won't show (bug)</ol> |
| Acceptance criteria | All borders should be visible |
| Priority | 2 - Next Release |
| Severity | 3 - High |

| BUG REPORT |   #2   |
| ---------- | ------ | 
| Description | Application crash on clicking the Save button while creating a new user, hence unable to create a new user in the application |
| Steps to reproduce | <ol><li>Open the dialog for creating a new user<li>Click the save button<li>Application will crash (bug)</ol> |
| Acceptance criteria | Application should be able to create new users |
| Priority | 1 - Immediate |
| Severity | 1 - Blocking |

* Prepare another bug report
	* for the bug shown in this [video] (http://www.youtube.com/watch?v=xJg7k8QOGtM&feature=related)
	* for this sample defect: After logging into Gmail, it navigates to Google.com

| BUG REPORT |   #3   |
| ---------- | ------ | 
| Description | Excel 2010 doesn't replace bullets of unordered list correctly |
| Steps to reproduce | <ol><li>Open Word<li>Create unordered list<li>Copy the list to clipboard and memorize the number of items<li>Open Excel 2010<li>Mark the same number of consecutive cells in a single column<li>Paste the list<li>Copy a bullet from the pasted list<li>Open "Find and Replace" dialog<li>Paste the copied bullet to the Find field<li>Leave Replace field blank<li>Press "Replace All"<li>The text from the list will be "transformed" to greek (bug)</ol> |
| Acceptance criteria | "Find and Replace" feature should work without side effects |
| Priority | 3 - On Occation |
| Severity | 4 - Medium |

| BUG REPORT |   #4   |
| ---------- | ------ | 
| Description | Gmail redirects to Google.com after login |
| Steps to reproduce | <ol><li>Open Gmail.com<li>Login to some email account<li>You will be redirected to Google.com (bug)</ol> |
| Acceptance criteria | Gmail should redirects to inbox after login |
| Priority | 1 - Immediate |
| Severity | 2 - Critical |