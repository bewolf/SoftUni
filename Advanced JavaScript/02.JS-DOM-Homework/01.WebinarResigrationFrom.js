var invoiceInfo = document.getElementById('invoiceInfo');
var checkedElement = document.getElementById('invoice');

checkedElement.addEventListener('change', function () {
    if (checkedElement.checked) {
        invoiceInfo.style.visibility = 'visible';
    } else {
        invoiceInfo.style.visibility = 'hidden';
    }
});
