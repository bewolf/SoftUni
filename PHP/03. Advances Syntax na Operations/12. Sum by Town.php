<?php

$lane = readline();
$numbers = explode(", ", $lane);
$sorted = [];

for ($i = 0; $i < count($numbers - 1); $i + 2) {
    if (!array_key_exists($numbers[$i], $sorted)) {
        $sorted[$numbers[$i]] = $numbers[$i + 1];
    } else {
        $sorted[$numbers[$i]] += $numbers[$i + 1];
    }

}
foreach ($sorted as $key => $value) {
    echo "$key => $value" . PHP_EOL;
}