var createCalendar = (function (selector, events) {
    var container = document.querySelector(selector),
        day = document.createElement('div'),
        cellTitle = document.createElement('h4'),
        DAY_OF_WEEK = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'],
        MONTH = ' Jun 2014',
        dayToAdd,
        dayCount = 0,
        selectedDay = 1,

        createDay = (function createDay() {
            day.style.border = '1px solid black';
            day.style.width = '120px';
            day.style.height = '110px';
            day.style.display = 'inline-block';
            day.style.margin = '0';
            day.style.padding = '0';

            cellTitle.width = '100%';
            cellTitle.style.background = 'lightgrey';
            cellTitle.style.margin = '0';
            cellTitle.style.padding = '0';
            cellTitle.style.textAlign = 'center';

            day.appendChild(cellTitle);
            return day;
        });

    container.style.width = '900px';

    var addEventListeners = (function (cell) {
        var isClicked = false,
            changeBackground = function (color, item) {
                item.style.background = color;
            };

        cell.addEventListener('click', function () {
            if (!isClicked) {
                changeBackground('lightgreen', this);
                isClicked = true;
                if (selectedDay !== this.id) {
                    changeBackground('', document.getElementById(selectedDay));
                }
                selectedDay = this.id;
            } else if (isClicked) {
                changeBackground('', this);
                isClicked = false;
            }
        }, false);

        cell.addEventListener('mouseover', function () {
            if (!isClicked) {
                changeBackground('yellow', this);
            }
        }, false);

        cell.addEventListener('mouseout', function () {
            if (!isClicked) {
                changeBackground('', this);
            }
        }, false);
    });

    (function createMonth() {
        for (var i = 1; i <= 30; i++) {
            dayToAdd = createDay().cloneNode(true);
            addEventListeners(dayToAdd);
            dayToAdd.getElementsByTagName('h4')[0].innerHTML = DAY_OF_WEEK[dayCount] + MONTH;
            dayToAdd.id = i;
            dayToAdd.innerHTML += '.';

            if (dayCount !== 6) {
                dayCount++;
            } else {
                dayCount = 0;
            }

            container.appendChild(dayToAdd);
        }
    }());

    (function addEvents() {
        events.forEach(function (event) {
            var eventDay = document.getElementById(event.date);
            eventDay.innerHTML += event.hour + ' ' + event.title;
        })
    }());
});