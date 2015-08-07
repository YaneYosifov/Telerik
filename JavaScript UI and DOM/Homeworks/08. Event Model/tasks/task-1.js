/* globals $ */

/* 
Create a function that takes an id or DOM element and:
* If an id is provided, select the element
* Finds all elements with class button or content within the provided element
  * Change the content of all .button elements with "hide"
* When a .button is clicked:
  * Find the topmost .content element, that is before another .button and:
    * If the .content is visible:
      * Hide the .content
      * Change the content of the .button to "show"       
    * If the .content is hidden:
      * Show the .content
      * Change the content of the .button to "hide"
    * If there isn't a .content element after the clicked .button and before other .button, do nothing
* Throws if:
  * The provided DOM element is non-existant
  * The id is either not a string or does not select any DOM element
*/

function solve() {
    return function (selector) {
        var buttons,
            contents;

        if (typeof selector !== 'string' && selector.nodeType === 'undefined') {
            throw new Error('Invalid DOM element');
        }

        if (typeof selector === 'string') {
            selector = document.getElementById(selector);
            if (!selector) {
                throw new Error('Invalid ID');
            }
        }

        buttons = selector.getElementsByClassName('button');
        contents = selector.getElementsByClassName('content');

        for (var i = 0, len = buttons.length; i < len; i += 1) {
            buttons[i].innerHTML = 'hide';
            buttons[i].addEventListener('click', function(ev) {
                var clickedButton = ev.target,
                    content = clickedButton.nextElementSibling;

                while (content.className !== 'content') {
                    content = content.nextElementSibling;
                }

                if (clickedButton.innerHTML === 'hide') {
                    content.style.display = 'none';
                    clickedButton.innerHTML = 'show';
                } else if (clickedButton.innerHTML === 'show') {
                    content.style.display = '';
                    clickedButton.innerHTML = 'hide';
                }
            }, false)
        }
    };
}

module.exports = solve;