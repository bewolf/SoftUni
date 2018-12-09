<?php

$input = readline();
$numbers = array_map("intval", explode(" ", $input));

for ($i = 0; $i < count($numbers); $i++) {

    for ($j = $i + 0; $j < (count($numbers) - 1); $j++) {
        echo $numbers[$i] + numbers[$j];
    }
}