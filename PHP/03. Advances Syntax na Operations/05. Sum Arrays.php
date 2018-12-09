<?php

$array1 = explode(" ", readline());
$array2 = explode(" ", readline());

$max = max(count($array1), count($array2));

for ($i = 0; $i < $max; $i++) {
    echo  $array1[$i] + $array2[$i] . " ";
}