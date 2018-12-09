<?php

$patern = explode(" ", readline());
$size = intval($patern[0]);
$startWay = $patern[1];
$matrix = [];
$i = null;
$j = null;

for ($i = 1; $i <= $size; $i++) {
    $matrix[$i] = [];
    if ($startWay == 'A') {
        for ($j = 0; $j < $size; $j++) {
            echo $matrix[$i][$j] = ($j * $size) + $i . " ";
        }
    }
    if ($startWay == 'B') {
        for ($j = 0; $j < $size; $j++) {
            if ($i % 2 == 0) {
                echo $matrix[$i][$j] = ($j * $size) + $i . " ";
            } else {
                echo $matrix[$j][$i] = ($j * $size) + $i . "s ";
            }
        }
    }
    Echo PHP_EOL;
}
