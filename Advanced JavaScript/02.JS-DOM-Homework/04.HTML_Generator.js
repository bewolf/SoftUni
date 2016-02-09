var HTMLGen = (function HTMLGen() {

    var createParagraph = function createParagraph(parentId, text) {
        var dfrag = new DocumentFragment();
        var parent = document.getElementById(parentId);
        var pElement = document.createElement('p');
        pElement.textContent = text;
        dfrag.appendChild(pElement);
        parent.appendChild(dfrag);
    }

    var createDiv = function createDiv(parentId, divClass) {
        var dfrag = new DocumentFragment();
        var parent = document.getElementById(parentId);
        var divElement = document.createElement('div');
        divElement.className = divClass;
        dfrag.appendChild(divElement);
        parent.appendChild(dfrag);

    }
    var createLink = function createLink(parentId, linkText, link) {
        var dfrag = new DocumentFragment();
        var parent = document.getElementById(parentId);
        var aElement = document.createElement('a');
        aElement.textContent = linkText;
        aElement.href = link;
        dfrag.appendChild(aElement);
        parent.appendChild(dfrag);


    }
    return {
        createParagraph: createParagraph,
        createDiv: createDiv,
        createLink: createLink
    }
})();


HTMLGen.createParagraph('wrapper', 'Soft Uni');
HTMLGen.createDiv('wrapper', 'section');
HTMLGen.createLink('book', 'C# basics book', 'http://www.introprogramming.info/');
