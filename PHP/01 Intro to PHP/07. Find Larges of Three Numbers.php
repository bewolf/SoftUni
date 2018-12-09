<?php
$firstNum = readline();
$secondNum = readline();
$thirdNum = readline();
$largestNum = null;

if ($firstNum >= $secondNum) {
    $largestNum = $firstNum;
}
if ($thirdNum >= $largestNum) {
    $largestNum = $thirdNum;
}
echo $largestNum;