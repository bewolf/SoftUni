<?php

$lane = explode(" ", readline());
$numbers = [];
$max = 0;
$mostFrequent = null;
for ($i = 0; $i < count($lane); $i++) {
    if (!array_key_exists($lane[$i], $numbers)) {
        $numbers[$lane[$i]] = 1;
    } else {
        $numbers[$lane[$i]]++;
    }
}
foreach ($numbers as $key => $number) {
    if ($number > $max) {
        $max = $key;
        $mostFrequent = $number;
    }
}
echo intval($max);
