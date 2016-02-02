function Exam(input) {
    var searchedCourse = (input[input.length - 1]).trim();
    var totalPoints = 0;
    var counter = 0;
    var studentInfo = [];
    var averagePoints;
    for (var i = 0; i < input.length - 1; i++) {
        input[i] = input[i].trim().replace(/\s+/g, ' ');
        studentInfo = input[i].split(' ');
        var studentName = studentInfo[0].trim();
        var studentCourse = studentInfo[1].trim();
        var studentExamPoints = Number(studentInfo[2]);
        var studentCourseBonuses = Number(studentInfo[3]);
        var studentCoursePoints = (studentExamPoints / 4) * 0.8 + studentCourseBonuses;
        studentCoursePoints = parseFloat(studentCoursePoints.toFixed(2).replace(/\.0+$/, ''));
        var studentExamGrade = (((studentCoursePoints / 80) * 4) + 2).toFixed(3);
        studentExamGrade = parseFloat(studentExamGrade).toFixed(2);

        if (studentCourse === searchedCourse) {
            totalPoints += studentExamPoints;
            counter++;

        }

        if (studentExamGrade > 6) {
            studentExamGrade = (6).toFixed(2);
        }

        if (studentExamPoints < 100) {
            console.log(studentName + ' failed at "' + studentCourse + '"');
        } else {
            console.log(studentName + ': Exam - "' + studentCourse + '"; Points - ' + studentCoursePoints + '; Grade - ' + studentExamGrade);
        }
    }
    averagePoints = (totalPoints / counter).toFixed(2);
    averagePoints = parseFloat(averagePoints);
    console.log('"' + searchedCourse + '" average points -> ' + averagePoints);
}

var input = [
    'Pesho C#-Advanced 100 3',
    'Gosho Java-Basics 157 3',
    'Tosho HTML&CSS 317 12',
    'Minka C#-Advanced 57 15',
    'Stanka C#-Advanced 157 15',
    'Kircho C#-Advanced 300 0',
    'Niki C#-Advanced 400 10',
    'C#-Advanced'];

Exam(input);