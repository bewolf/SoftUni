function createParagraph(id, text) {
    var dfrag = new DocumentFragment();
    var parent = document.getElementById(id);
    var innerText = document.createTextNode(text);
    var node = document.createElement('P');
    node.appendChild(innerText);
    dfrag.appendChild(node);
    parent.appendChild(dfrag);
}

createParagraph('wrapper', 'Some text');