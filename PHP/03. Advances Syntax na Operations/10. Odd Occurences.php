<?php

$lane = readline();
$numbers = explode(" ", strtolower($lane));
$sorted = [];

for ($i = 0; $i < count($numbers); $i++) {
    if (!array_key_exists($numbers[$i], $sorted)) {
        $sorted[$numbers[$i]] = 1;
    } else {
        $sorted[$numbers[$i]]++;
    }

}
foreach ($sorted as $key => $value) {
    if ($value % 2 != 0) {
        echo "$key ";
    }
}