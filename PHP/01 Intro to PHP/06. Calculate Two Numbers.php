<?php
$firstNum = readline();
$secondNum = readline();
$command = readline();

switch ($command) {
    case "sum":
        echo $firstNum + $secondNum;
        break;
    case "divide":
        if ($secondNum != 0) {
            echo $firstNum / $secondNum;
        } else {
            echo "Cannot divide by zero";
        }
        break;
    case "subtract":
        echo $firstNum - $secondNum;
        break;
    case "multiply":
        echo $firstNum * $secondNum;
        break;
    default:
        echo "Wrong command";
}
