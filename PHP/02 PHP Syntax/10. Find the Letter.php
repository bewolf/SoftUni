<?php

$input = str_split(readline());
$search = explode(" ", readline());
$symbol = $search[0];
$possition = $search[1];
$counter = 0;
for ($i = 0; $i < count($input); $i++) {
    if ($input[$i] == $symbol) {
        $counter++;
        if ($counter == $possition) {
            echo key($input);
            break;
        }
    }
}