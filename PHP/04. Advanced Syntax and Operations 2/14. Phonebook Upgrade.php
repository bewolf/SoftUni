<?php

$input = explode(" ", readline());
$command = $input[0];
$name = null;
$phoneNumber = null;
$phoneBook = [];

while ($input[0] != "END") {
    switch ($input[0]) {
        case "A":
            if (count($input) < 3) {
                break;
            } else {
                $name = $input[1];
                $phoneNumber = $input[2];
                $phoneBook[$name] = $phoneNumber;
            }
            break;
        case "S":
            if (!key_exists($input[1], $phoneBook)) {
                echo "Contact $input[1] does not exist." . PHP_EOL;
            } else {
                echo "$input[1] -> " . $phoneBook[$input[1]] . PHP_EOL;
            }
            break;
        case "ListAll":
           ksort($phoneBook);
            foreach ($phoneBook as $key => $value) {
                echo "$key -> $value" . PHP_EOL;
            }
            break;
    }
    $input = explode(" ", readline());
}
