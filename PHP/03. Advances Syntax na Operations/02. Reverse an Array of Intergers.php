<?php

$count = readline();
$numbers = [];
for ($i = 0; $i < $count; $i++) {
    array_push($numbers, intval(readline()));
}
$numbers = array_reverse($numbers);

foreach ($numbers as $number) {
    echo $number . " ";
}