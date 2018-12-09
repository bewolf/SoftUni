<?php

$lane = explode(" ", readline());
$temp = [];

for ($i = 0; $i < count($lane); $i++) {
    for ($i = 0; $i < count($lane) - 1; $i++) {
        $temp[$i] = $lane[$i] + $lane[$i + 1];
    }
    $lane = $temp;
}
echo $lane[0] . PHP_EOL;
print_r($lane);