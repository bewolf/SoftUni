<?php

$matrixSize = explode(", ", readline());
$matrix = [];
$sum = 0;
for ($i = 0; $i < $matrixSize[0]; $i++) {
    $matrix[$i] = explode(", ", readline());
}

foreach ($matrix as $element) {
    foreach ($element as $number) {
        $sum += intval($number);
    }
}
echo "$matrixSize[0]" . PHP_EOL . "$matrixSize[1]" . PHP_EOL . "$sum";