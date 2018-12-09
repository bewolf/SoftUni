<?php

$input = readline();

for ($i = 1; $i <= 10; $i++) {
    $product = $input * $i;
    echo "$input X $i = $product \r\n";
}