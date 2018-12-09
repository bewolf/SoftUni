<?php

$size = explode(", ", readline());
$subMatrix = [];
$matrix = [];
$sum = null;
$max = null;
for ($i = 0; $i < $size[0]; $i++) {
    $matrix[$i] = explode(", ", readline());
}
for ($i = 0; $i < ($size[0] - 1); $i++) {
    for ($j = 0; $j < ($size[1] - 1); $j++) {
        $sum =
            $matrix[$i][$j] +
            $matrix[$i + 1][$j] +
            $matrix[$i][$j + 1] +
            $matrix[$i + 1][$j + 1];
        if ($sum > $max) {
            $max = $sum;
            $subMatrix[0][0] = $matrix[$i][$j];
            $subMatrix[1][0] = $matrix[$i + 1][$j];
            $subMatrix[0][1] = $matrix[$i][$j + 1];
            $subMatrix[1][1] = $matrix[$i + 1][$j + 1];
        }
    }
}
for ($i = 0; $i < (count($subMatrix)); $i++) {
    for ($j = 0; $j < (count($subMatrix)); $j++) {
        echo $subMatrix[$i][$j] . " ";
    }
    echo PHP_EOL;
}
echo $max;