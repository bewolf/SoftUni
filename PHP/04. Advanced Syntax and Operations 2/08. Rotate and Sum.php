<?php

$numbers = array_map("intval", explode(" ", readline()));
$rotate = intval(readline());
$temp = null;
$sum = array_fill(0, count($numbers), 0);

for ($i = 0; $i < $rotate; $i++) {
    $temp = $numbers[count($numbers) - 1];
    array_pop($numbers);
    array_unshift($numbers, $temp);

    for ($j = 0; $j < count($numbers); $j++) {
        $sum[$j] += $numbers[$j];
    }
}
foreach ($sum   as $value){
    echo "$value ";
}
