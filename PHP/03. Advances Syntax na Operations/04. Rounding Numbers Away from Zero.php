<?php

$input = readline();
$numbers = array_map("floatval", explode(" ", $input));

for ($i = 0; $i < count($numbers); $i++) {
    if ($numbers[$i] < -1) {
        echo $numbers[$i] . " => " . round($numbers[$i]) . PHP_EOL;
    } elseif ($numbers[$i] > -1 && $numbers[$i] < 0) {
        echo $numbers[$i] . " => -1" . PHP_EOL;
    } elseif ($numbers[$i] == 0) {
        echo $numbers[$i] . " => 0" . PHP_EOL;
    } else if ($numbers[$i] > 0 && $numbers[$i] < 1) {
        echo $numbers[$i] . " => 1" . PHP_EOL;
    } elseif ($numbers[$i] > 1) {
        echo $numbers[$i] . " => " . round($numbers[$i]) . PHP_EOL;
    }
}