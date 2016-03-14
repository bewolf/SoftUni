(function () {
    var hasVisited = localStorage.getItem('washere'),
        name;
    if (!hasVisited) {
        name = prompt('Enter your name:');
        localStorage.setItem('name', name);
        localStorage.setItem('washere', true);
    } else if (!sessionStorage.sessionVisitCount) {
        alert('Hello ' + localStorage.getItem('name') + ' you visit site for ' + localStorage.getItem('totalCount') + ' total time(s) and for first session visit time');
    } else {
        alert('Hello ' + localStorage.getItem('name') + ' you visit site for ' + localStorage.getItem('totalCount') + ' total time(s) and ' + sessionStorage.getItem('sessionVisitCount') + ' session visit counts');
    }

    function totalCounts() {
        if (!localStorage.totalCount) {
            localStorage.setItem('totalCount', 1);
        }

        var currentCount = parseInt(localStorage.getItem('totalCount'));
        currentCount++;
        localStorage.setItem('totalCount', currentCount);
    }

    function sessionVisitCount() {
        if (!sessionStorage.sessionVisitCount) {
            sessionStorage.setItem('sessionVisitCount', 1);
        }

        var currentCount = parseInt(sessionStorage.getItem('sessionVisitCount'));
        currentCount++;
        sessionStorage.setItem('sessionVisitCount', currentCount);
    }

    totalCounts();
    sessionVisitCount();
})();

//If we use only session storage we can't have total visit counts. One every new oppened session we loose all old data.