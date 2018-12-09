<?php

$input = explode(" : ", readline());
$phones = [];
$name = null;
$number = null;
while ($input[0] != "Over") {
    if (ctype_digit($input[1])) {
        $name = $input[0];
        $number = $input[1];
    } else {
        $name = $input[1];
        $number = $input[0];
    }
    $phones[$name] = $number;
    $input = explode(" : ", readline());
}
ksort($phones);
foreach ($phones as $key => $value) {
    echo "$key -> $value" . PHP_EOL;
}