<?php
if (isset($_POST['submit'])) {
    if (is_numeric($_POST['number1']) && is_numeric($_POST['number2'])) {
        $calculate = $_POST['calculate'];
        $firstNum = $_POST['number1'];
        $secondNum = $_POST['number2'];

        switch ($calculate) {
            case 'Sum':
                $result = $firstNum + $secondNum;
                break;
            case 'Subtract':
                $result = $firstNum - $secondNum;
                break;
            default:
                $result = "Invalid operation!";
                break;
        }
    }
}
include "calculator-frontend.php";


