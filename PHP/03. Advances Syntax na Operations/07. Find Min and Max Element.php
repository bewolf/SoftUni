<?php

$patern = explode(" ", readline());
$x = trim(intval($patern[0]));
$y = trim(intval($patern[1]));
$max = null;
$min = null;
$matrix = [];

for ($i = 0; $i < $x; $i++) {
    $matrix[$i] = explode(", ", readline());
}
for ($i = 0; $i < $x; $i++) {
    for ($j = 0; $j < $y; $j++) {
        if ($matrix[$i][$j] > $max) {
            $max = $matrix[$i][$j];
        }
        if ($min == null || $matrix[$i][$j] < $min) {
            $min = $matrix[$i][$j];
        }
    }
}

echo "Min: $min" . PHP_EOL;
echo "Max: $max";