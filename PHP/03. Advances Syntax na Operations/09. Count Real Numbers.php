<?php

$lane = readline();
$numbers = explode(" ", $lane);
$sorted = [];

for ($i = 0; $i < count($numbers); $i++) {
    if (!array_key_exists($numbers[$i], $sorted)) {
        $sorted[$numbers[$i]] = 1;
    } else {
        $sorted[$numbers[$i]] ++;
    }

}
foreach ($sorted as $key => $value) {
    echo "$key -> $value" . PHP_EOL;
}