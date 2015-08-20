function solve() {
    return function (selector, isCaseSensitive) {
        var container = document.querySelector(selector);
        container.style.border = '1px solid black';
        container.style.width = '500px';

        var xBtn = document.createElement('div');
        xBtn.className = 'button';
        xBtn.style.width = '50px';
        xBtn.style.height = '50px';
        xBtn.innerHTML = 'X';
        xBtn.style.border = '1px solid black';

        var itemsList = document.createElement('ul'),
            listItem = document.createElement('li');
        itemsList.className = 'items-list';
        listItem.className = 'list-item';

        var elementsAdd = document.createElement('div');
        elementsAdd.className = 'add-controls';
        elementsAdd.style.border = '1px solid black';
        elementsAdd.style.height = '80px';
        elementsAdd.style.textAlign = 'center';
        elementsAdd.innerHTML = 'Enter text';
        var inputText = document.createElement('input');
        inputText.type = 'text';
        var button = document.createElement('button');
        button.className = 'button';
        button.innerHTML = 'Add';
        button.style.display = 'block';
        button.style.margin = 'auto';
        elementsAdd.appendChild(inputText);
        elementsAdd.appendChild(button);

        var elementsSearch = document.createElement('div');
        elementsSearch.className = 'search-controls';
        elementsSearch.style.border = '1px solid black';
        elementsSearch.style.height = '80px';
        elementsSearch.style.textAlign = 'center';
        elementsSearch.innerHTML = 'Search';
        var inputSearch = document.createElement('input');
        inputSearch.type = 'text';

        var elementsResult = document.createElement('div');
        elementsResult.className = 'result-controls';
        elementsResult.style.border = '1px solid black';
        elementsResult.style.height = '50px';
        elementsResult.appendChild(itemsList);

        container.appendChild(elementsAdd);
        container.appendChild(elementsSearch);
        container.appendChild(elementsResult);

        button.addEventListener('click', function (ev) {
            var newLi = listItem.cloneNode(true);
            newLi.innerHTML = this.previousElementSibling.value;
            elementsResult.appendChild(newLi);
        }, false);

        elementsSearch.appendChild(inputSearch);
    };
}

module.exports = solve;