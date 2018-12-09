<?php

$input = readline();
$times = readline();

for ($i = $times; $i <= 10; $i++) {
    $product = $input * $i;
    echo "$input X $i = $product \r\n";
}
if ($times > 10) {
    $product = $input * $times;
    echo "$input X $times = $product";
}