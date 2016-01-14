function replaceATag() {
    var element = document.getElementsByTagName('a')[0].outerHTML;
    console.log(element);
    element = element.replace('<a', '[URL').replace('</a>', '[/URL]');
    console.log(element);
    document.getElementsByTagName('li')[0].innerHTML = element;
}