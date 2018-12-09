<?php

$lane = readline();
$letters = str_split($lane);
$sorted = [];

for ($i = 0; $i < count($letters); $i++) {
    if (!array_key_exists($letters[$i], $sorted)) {
        $sorted[$letters[$i]] = 1;
    } else {
        $sorted[$letters[$i]]++;
    }
}
foreach ($sorted as $key => $value) {
    echo "$key -> $value" . PHP_EOL;
}