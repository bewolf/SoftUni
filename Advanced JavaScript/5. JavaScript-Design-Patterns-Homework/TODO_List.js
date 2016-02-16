(function () {
    var dayHeader = document.getElementById('day-of-week');
    var d = new Date();
    var weekday = ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'];
    dayHeader.innerText = weekday[d.getDay()] + ' TODO list.';

})();

var FormFiller = (function () {

    var createSection = function () {
        var sectionName, formParent, dfrag, createInnerSection, createH2, createButton, createInputForAddingItems, itemsClass;

        sectionName = document.getElementById('create-section-input').value;
        formParent = document.getElementById('sections');

        dfrag = new DocumentFragment();
        createInnerSection = document.createElement('section');
        createH2 = document.createElement('h2');
        createButton = document.createElement('input');
        createInputForAddingItems = document.createElement('input');
        createH2.innerText = sectionName;

        if (createH2.innerText === '') {
            alert('Add Section Name');
            console.log(createH2)
        } else {
            itemsClass = createH2.innerText.split(/\s+/).join('');
            createInnerSection.id = itemsClass;
            createButton.type = 'button';
            createButton.value = '+';
            createButton.className = itemsClass;
            createInputForAddingItems.type = 'text';
            createInputForAddingItems.className = itemsClass
            createInputForAddingItems.setAttribute('placeholder', 'Add Item...');
            formParent.style.display = 'block';

            createInnerSection.appendChild(createH2);
            dfrag.appendChild(createInnerSection);
            dfrag.appendChild(createInputForAddingItems);
            dfrag.appendChild(createButton);
            return formParent.appendChild(dfrag);
        }
    }

    var createItem = function () {
        var dfrag, createLabel, createCheckbox;
        dfrag = new DocumentFragment();
        createLabel = document.createElement('label');
        createCheckbox = document.createElement('input');
        createCheckbox.type = 'checkbox';

    }
    return {
        createSection: createSection,
        createItem: createItem
    }
})();
var createSectionButton = document.getElementById('create-new-section');
createSectionButton.addEventListener('click', FormFiller.createSection);