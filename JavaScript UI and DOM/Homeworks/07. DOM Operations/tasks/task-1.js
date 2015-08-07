/* globals $ */

/* 
Create a function that takes an id or DOM element and an array of contents
* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight string or number
    * In that case, the content of the element must not be changed
*/

function solve() {
    return function (element, contents) {
        var div = document.createElement('div'),
            currentItemToDiv,
            docFragment = document.createDocumentFragment();

        if (typeof element !== 'string' && element.nodeType === 'undefined') {
            throw new Error('Invalid DOM element');
        }

        if (typeof element === 'string') {
            element = document.getElementById(element);
            if (!element) {
                throw new Error('Invalid ID');
            }
        }

        contents.forEach(function (item) {
            if (typeof item !== 'string' && typeof item !== 'number') {
                throw new Error('Invalid contents');
            }

            currentItemToDiv = div.cloneNode(true);
            currentItemToDiv.innerHTML = item;
            docFragment.appendChild(currentItemToDiv);
        });

        element.innerHTML = '';
        element.appendChild(docFragment);
    };
}

module.exports = solve;